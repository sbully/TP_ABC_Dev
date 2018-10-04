using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce4_tri_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int inc = 0;
            int tempo=0;
            int parc = 1 ;
            int nbpetit;
            
            Random aleas = new Random();

            Console.Clear();
            Console.WriteLine(".............................");
            Console.WriteLine("Tri d un tableau de 10 nombre");
            Console.WriteLine(".............................");
            
            int[] tableau = new int[10];

            do
            {
                tableau[inc] = aleas.Next(0, 101);
                Console.WriteLine(tableau[inc]);
                inc++;
            } while (inc<10);

            Console.WriteLine(".............................");
            Console.WriteLine("\tTableau trié");
            Console.WriteLine(".............................");            

            for (int curseur = 0; curseur < 10; curseur++)
            {
                parc = curseur;

                nbpetit = tableau[curseur];

                do                                              // recherche du nombre le plus petit dans le tableau
                {
                    if (nbpetit<tableau[parc])
	                {
		                parc++;
	                }
                    else
	                {
                    tempo = nbpetit;
                    nbpetit = tableau[parc];
                    tableau[parc] = tempo;
                    parc++;
	                }


                } while (parc<10);

                tableau[curseur]=nbpetit;               //assignation du plus petit nombre dans tableau[curseur]



            }

            inc = 0;
            do
            {
                Console.WriteLine(tableau[inc]);
                inc++;
            } while (inc < 10);

            Console.ReadKey();

        }
    }
}
