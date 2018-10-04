using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entrer le montant initial du compte :");
            double S = double.Parse(Console.ReadLine());
            Console.WriteLine("entrer l'intérêt de la banque :");
            double interet = double.Parse(Console.ReadLine());
            double i = interet / 100;
            Console.WriteLine("entrer le nombre d'année de placement :");
            double n = double.Parse(Console.ReadLine());
            double total = S * (1 + n * i);
            total = Math.Round(total,2);
            Console.WriteLine("valeur intérêt simple apres "+n+" année(s) de placement est de : "+ total+" euro");
            double total2 = S * Math.Pow((1 + i), n);
            total2 = Math.Round(total2, 2);
            Console.WriteLine("valeur intérêt composé apres " + n + " année(s) de placement est de :" + total2+" euro");
            Console.ReadKey();
        }
    }
}
