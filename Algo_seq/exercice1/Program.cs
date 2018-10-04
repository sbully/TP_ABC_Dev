using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nba,nbb;

            Console.WriteLine("entré le nombre a");
            nba = Console.ReadLine();
            double a = double.Parse(nba);
            Console.WriteLine("entré le nombre b");
            nbb = Console.ReadLine();
            double b = double.Parse(nbb);
            double moyenne = (a+b)/2 ;
            Console.WriteLine("la moyenne des nombres "+a+" et "+b+" est de = {0:#,###.00} ",moyenne);
            Console.ReadKey();
        }
    }
}
