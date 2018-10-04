using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce5_palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            int compare;
            int curseur2 = 0;
            int borne;
            int longeur;
            bool comp = true;
            int compteur = 0;
            Console.WriteLine("entrer un nombre / expression :");
            string phrase = Console.ReadLine();


            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == '.')
                {
                    compteur++;
                }
            }

            if (compteur==phrase.Length)
            {
                Console.WriteLine("La phrase est vide, petit malin tu croyais vraiment m'avoir??");
            }
            else
            {



            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == ' '||phrase[i] == '.')
                {
                    phrase = phrase.Remove(i, 1);
                    i--;
                }
            }

            phrase = phrase.ToUpper();
            string phrase2 = (string)phrase.Clone();
            longeur = phrase.Length;
            Console.WriteLine("affichage phrase1 :"+phrase);
            Console.WriteLine("affichage phrase2 :" + phrase2);



            do
            {
                borne = longeur - curseur2-1;
                compare = phrase[curseur2].CompareTo(phrase2[borne]);

                if (compare != 0)
                {
                    comp = false;
                }
                curseur2++;
            } while (curseur2 < longeur && comp);





            if (comp)
            {
                Console.WriteLine(" l'expression rentrée est un paladrome");
            }
            else
            {
                Console.WriteLine(" l'expression rentrée n'est pas un paladrome");
            }
            }

            Console.ReadKey();



        }
    }
}
