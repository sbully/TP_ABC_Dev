using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce1
{
    class Program
    {
        static void Main(string[] args)
        {

            int inc = 0;
            int nbr;
            int i=0;
            Random aleas = new Random();



            Console.Clear();
            Console.WriteLine("Recherche d'un nombre");
            int[] tableau = new int[10];

            do
            {
                tableau[inc] = aleas.Next(0, 101);
                Console.WriteLine(tableau[inc]);
                inc++;
            } while (inc<10);

            Console.WriteLine("..........Tableau trié............");
            System.Array.Sort(tableau);
            inc = 0;
            do
            {
                Console.WriteLine(tableau[inc]);
                inc++;
            } while (inc < 10);

            Console.WriteLine("quel nombre voulez vous rechercher ? :");
            nbr = int.Parse(Console.ReadLine());


            foreach (int nombre in tableau)
            {

                if (nombre == nbr)
                {
                    Console.WriteLine("le nombre "+nbr+" se trouve à tableau["+i+"]");
                }
                i++;
            }

            Console.ReadKey();


        }
    }
}
