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
            string test;
            do
            {

                Console.Clear();
                bool fract = false;
                int reste ;
                Console.WriteLine("Nous allons déterminé si un nombre entier et un nombre premier");
                Console.Write("entrer un entier :");
                int nombre = int.Parse(Console.ReadLine());

                for (int i = 2; (i < Math.Sqrt(nombre)) ; i++)             // 2 est le 1er des nombre premier
                {                                                                          //calcule du reste de la division de nombre/i jusqu a racine carré de nombre 
                    reste = nombre % i;
                    if (reste ==0)
                    {
                        fract = true;
                        break;
                    }
  //                  Console.WriteLine("valeur de i :"+i);
  //                  Console.WriteLine("valeur fract: "+fract);
 
                }

                if (fract == true || (nombre==1))
                {
                    Console.WriteLine("ce n'est pas un nombre premier");
                }
                else
                {
                    Console.WriteLine("c'est un nombre premier");
                }
                                

























                Console.WriteLine("d'autre nombre à verifier? o/n");
                test = Console.ReadLine();
                
            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
        }
    }
}
