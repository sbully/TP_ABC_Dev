using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce5
{
    class Program
    {
        static void Main(string[] args)
        {

            string test;
            
            do
            {


                double x;
                Console.Clear();
                Console.WriteLine("Résolution de l'équation du 1er degré : a*x + b = 0");
                Console.Write("entré le nombre A :");
                double a = double.Parse(Console.ReadLine());                        // recuperation du nombre A
                Console.Write("entré le nombre B :");
                double b = double.Parse(Console.ReadLine());                        // recuperation du nombre B
                
                if (a==0)
                {
                    if (b==0)
                    {
                        Console.WriteLine("équation indéterminé car a et b =0");                        
                    }
                    else
                    {
                        Console.WriteLine("équation impossible car A=0");
                    }

                }
                
                else
                {
                    x = -b / a;
                    Console.WriteLine("X est égale à :"+x);
                }


                Console.WriteLine("d'autre équation à résoudre?");
                test = Console.ReadLine();

            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
        }
    }
}
