using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce2
{
    class Program
    {
        static void Main(string[] args)
        {


            char search;
            int nombre = 0;
            int point = 0;
            Console.Clear();
            Console.WriteLine("entrer un texte et terminé par un point:");
            string phrase = Console.ReadLine();
            int longueur = phrase.Length;
            Console.WriteLine("quelle lettre voulez vous rechercher? :");
            search = char.Parse(Console.ReadLine());

            for (int i = 0; i < longueur; i++)
            {
                if (phrase[i] == search)
                {
                    nombre++;
                }
                if (phrase[i] == '.')
                {
                    point++;
                }
            }
            if (point == longueur)
            {
                Console.WriteLine("LA CHAINE EST VIDE");
            }
            else
            {
                if (nombre==0)
                {
                    Console.WriteLine("La lettre n'est pas présente");
                }
                else
                {
                    Console.WriteLine("il y a " + nombre + "lettre " + search + " dans la chaine de caractères");
                }
            }

            
            
            
            
            Console.ReadKey();
            



        }
    }
}
