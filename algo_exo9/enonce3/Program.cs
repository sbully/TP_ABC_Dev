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

            string test;
            do
            {
                
                Console.Clear();
                Console.WriteLine("entrer l'année:");
                int a = int.Parse(Console.ReadLine());
                if (a%4 == 0)                                                   // test division par 4
                {
                    if (a%100==0 && a%400 !=0)                                   // année divisible par 100 mais pas par 400
                    {
                       Console.WriteLine("l'année n'est pas bisextile");        // si oui renvoi "année non bisextile"
                    }
                    else
                    {
                        Console.WriteLine("l'année est bisextile");             // si non renvoi "année bisextile"
                    }
 
                }
                else
                {
                    Console.WriteLine("l'année n'est pas bisextile");           // si l'année n est pas divisble par 4 renvoi "année non bisextile"
                }



                Console.WriteLine("d'autre année à verifier? o/n");

                test = Console.ReadLine();









            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
        }
    }
}
