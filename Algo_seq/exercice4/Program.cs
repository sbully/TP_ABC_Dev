using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entrer le rayon du secteur circulaire :");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("entrer l'angle du secteur circulaire :");
            double a = double.Parse(Console.ReadLine());
            double air = Math.PI * r * r * (a / 360);
            Console.WriteLine("l air du secteur circulaire est de :" + air + " cm carré");
            Console.WriteLine("l air du secteur circulaire est de {0: ##.###,00}" , air );
            Console.ReadKey();
        }
    }
}
