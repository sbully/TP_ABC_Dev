using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce4
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            Random monaleas = new Random();

            int nombsecret = monaleas.Next(0, 101);
            int essai=0;
            bool entier = false;
            int positif=100;
            int négatif = 0;
            int coup = 1;
            do
            {

            Console.Clear();

            Console.WriteLine("Jeu de la Fourchette, Deviner un nombre généré aléatoirement par l'ordinateur");
            
            do
            {

                Console.WriteLine("nombre compris entre "+négatif+" et "+positif);
                essai= int.Parse(Console.ReadLine());

                if (nombsecret == essai)
	            {
                    Console.WriteLine("bien joué vous avez trouvé le nombre secret en "+coup+" coup");
                    entier = true;
		 
	            }
                else
	            {
                    if (nombsecret>essai)
	                {
		                Console.WriteLine("Raté le nombre secret est plus grand");
                        négatif = essai;
                       
	                }
                    else
	                {
                        Console.WriteLine("Raté le nombre secret est plus petit");
                        positif = essai;
                       
	                }

	            }


                coup++;
                    

            }
            while (entier==false);


                   







                Console.WriteLine("voulez vous rejouer? o/n");
                test = Console.ReadLine();

            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
    }
    }
    }

