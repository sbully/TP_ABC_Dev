using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("entrer la longueur du 1er coté :");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("entrer la longueur du 2eme coté :");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("entrer la longueur du 3eme coté :");
            double c = double.Parse(Console.ReadLine());
            double p = a + b + c;
            double aire = Math.Sqrt((p / 2) * (p - a) * (p - b) * (p - c));
            Console.WriteLine("le périmètre du triangle est de :" + p + " cm");
            Console.WriteLine("l air du triangle est de :" + aire + " cm carré");
            Console.ReadKey();

        }
    }
}
