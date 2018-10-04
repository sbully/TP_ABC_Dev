using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce4
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            double resultat;
            do
            {



                Console.Clear();
                Console.WriteLine("entré un nombre (positif ou négatif)");
                double n = double.Parse(Console.ReadLine());                        // recuperation du nombre et conversion en double
                resultat = Math.Abs(n);
                Console.WriteLine("la valeur absolue de "+n+" est :" +resultat);
               



                Console.WriteLine("d'autre nombre à tester? o/n");
                test = Console.ReadLine();

            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
        }
    }
}
