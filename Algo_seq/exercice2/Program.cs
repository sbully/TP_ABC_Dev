using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, a,v;
            Console.WriteLine("entré le rayon de la sphère en cm:");
            r = double.Parse(Console.ReadLine());
            a = (4 * Math.PI) * r * r;
            v = (4 * Math.PI) / 3 * r * r * r;

            Console.WriteLine("l'air de la sphère est de : {0:#,###.000} cm carré" , a);

            Console.WriteLine("le volume de la sphère est de : {0:#,###.000} cm cube", v );
            Console.ReadKey();
        }

    }
}
