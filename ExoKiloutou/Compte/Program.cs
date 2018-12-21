using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compte
{
    class Program
    {
        static void Main(string[] args)
        {
            Compte compte1 = new Compte("Bob",1012);
            Compte compte2 = new Compte("Fred",1096);

            compte1.Affichage();
            compte2.Affichage();

            compte2.Dispose();
            compte1.Affichage();
            compte2.Affichage();
            compte2.Numero = 1000;
            compte2.Affichage();




            Console.ReadKey();
        }
    }
}
