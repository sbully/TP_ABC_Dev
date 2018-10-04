using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            do
            {
                double c;
                
                Console.Clear();
                Console.WriteLine("entrer la valeur de A :");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("entrer la valeur de B:");
                double b = double.Parse(Console.ReadLine());
                c = a;
                a = b;
                b = c;
                Console.WriteLine("apres échange la valeur de A est : " + a + " et la valeur de B :" + b);
                Console.WriteLine("d'autre nombre à échanger? o/n");
                test = Console.ReadLine();

            } while ( test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
        }
    }
}
