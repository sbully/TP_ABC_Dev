using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recherche_prenom
{
    class Program
    {

        static void Main(string[] args)
        {

            string prenom;
            int min = 0, max = 0;
            bool exit = false;
            int compare = 0;
            bool find = false;
            int middle = 0;
            string[] tableau = new string[7] { "agathe", "berthe", "chloé", "cunégonde", "olga", "raymonde", "sidonie" };


            Console.WriteLine("Entrer un prénom :");
            prenom = Console.ReadLine();
            max = tableau.GetLength(0) - 1;
            middle = (tableau.GetLength(0) - 1) / 2;
            Console.WriteLine("position du curseur :" + middle);


            do
            {

                compare = prenom.CompareTo(tableau[middle]);
                Console.WriteLine("min = " + min+" max = " + max);
                if (max - min == 1)
                {
                    exit = true;
                }

                if (compare == 0)
                {
                    find = true;
                }
                else
                {
                    if (compare < 0) // prénom dans la 1ere parti du tableau
                    {
                        max = middle;
                        middle = max - ((max - min) / 2) - 1;
                        Console.WriteLine("position du curseur :" + middle);
                    }
                    else            //prénom dans la 2eme partie du tableau
                    {
                        min = middle;
                        middle = min + ((max - min) / 2);
                        Console.WriteLine("position du curseur :" + middle);
                    }

                }
            } while (!find && !exit);

            
            if (find)
            {
                Console.WriteLine("le prénom " + prenom + " se trouve a l index :" + middle);
            }
            else
            {
                Console.WriteLine("le prenom " + prenom + " n est pas présent dans le tableau");
            }

            Console.ReadKey();



        }
    }
}
