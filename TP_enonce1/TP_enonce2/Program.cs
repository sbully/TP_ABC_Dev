using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_enonce2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ciel;
            string etat;
            string repa;
            string salon;
            string dispo;

            Console.WriteLine ("Fera t il beau demain? o/n");
            ciel = Console.ReadLine();
            if (ciel == "o")
            {
                Console.WriteLine("je vais me balader! Bicyclette en bon état? o/n");
                etat = Console.ReadLine();
                if (etat == "n")
                {
                    Console.WriteLine ("je vais au garage, les réparations sont immédiates? o/n");
                    repa = Console.ReadLine();
                    if (repa =="n")
                    {
                        Console.WriteLine ("Je vais à pied jusqu'au lac pour cueillir des joncs ");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Je vais me balader en byclette (apres reparations)");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Je vais me balader en byclette (sans reparation)");
                    Console.ReadKey();

                }
            }
            else
            {
                Console.WriteLine("Je vais lire Madame Bovary, est il dans le salon? o/n");
                salon = Console.ReadLine();
                if (salon =="n")
                {
                    Console.WriteLine("Je vais a la bibliothète, est il dispo? o/n");
                    dispo = Console.ReadLine();
                    if (dispo == "o")
                    {
                        Console.WriteLine("je l emprunte, je rentre chez moi directement et je m'installe confortablement dans un fauteuil et je lis");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("je prend un livre policier, je rentre chez moi directement et je m'installe confortablement dans un fauteuil et je lis");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("je m'installe confortablement dans un fauteuil et je lis");
                    Console.ReadKey();
                }
            }
        }
    }
}
