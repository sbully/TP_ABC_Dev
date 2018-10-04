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

            string test;
            do
            {

                Console.Clear();
                int reste;
                Console.WriteLine("Nous allons déterminé les diviseurs d'un nombre");
                Console.Write("entrer un entier :");
                int nombre = int.Parse(Console.ReadLine());
                for (int div = 2; (div < nombre); div++)              
                {
                    
                    reste = nombre % div;
                    if (reste == 0)
                    {
                        Console.WriteLine("le nombre est divisible par :"+div);
                    }


                }


                Console.WriteLine("d'autre nombre à verifier? o/n");
                test = Console.ReadLine();

            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
        }
    }
}
