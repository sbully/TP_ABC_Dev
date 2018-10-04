using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_enonce1
{
    class Program
    {
        static void Main(string[] args)
        {
            string reponse;
            
            Console.WriteLine("lecture de l'énoncé");
            Console.WriteLine("Avez vous compris l'énoncé O/N");
            reponse = Console.ReadLine();
            if (reponse == "n")
            {
                Console.WriteLine("relecture de l'énoncé");
                Console.WriteLine("Avez vous compris l'énoncé O/N");
                reponse = Console.ReadLine();
                
                if (reponse == "n")
                {
                    Console.WriteLine("Appel du formateur"); 
                    Console.WriteLine("Passer à l'énoncé suivant sortie 1 formateur");

                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Passer à l'énoncé suivant sortie 2 relecture");

                    Console.ReadKey();

                }

            }
            else
            {
                Console.WriteLine("Passer à l'énoncé suivant sortie 3 comprehension");

                Console.ReadKey();
            }

        }
    }
}
