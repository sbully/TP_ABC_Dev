using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce3
{
    class Program
    {
        static void Main(string[] args)
        {

            int curseur = 0;
            int cptlettre = 0;
            int compare;
            int i = 0;
            Console.Clear();
            Console.WriteLine("entrer un texte ");
            string phrase = Console.ReadLine();
            int longueur = phrase.Length;
            
            char[] alpha = new char[26] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            int[] compteur = new int[26];
            Console.WriteLine(longueur);


            for (int curseur2 = 0; curseur2 < 26; curseur2++)
            {
                do
                {
                    compare = phrase[i].CompareTo(alpha[curseur]);

                    if (compare ==0)
	                {
                        cptlettre++;
	                }
                    i++;
                } while (i < longueur);

            compteur[curseur2] = cptlettre;
            curseur ++;
            i = 0;
            cptlettre = 0;

            }
            Console.WriteLine(" lettre | nb de lettre");
            Console.WriteLine("......................");
            for (int j = 0; j < 26; j++)
            {

                Console.WriteLine("   "+alpha[j] + "\t|\t" + compteur[j]);
                Console.WriteLine("......................");
                                
            }



            Console.ReadKey();
        }
    }
}
