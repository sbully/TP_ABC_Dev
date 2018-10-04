using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce3
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            do
            {



                Console.Clear();
                int age=0;
                int nbjeune=0;
                Console.WriteLine("Déterminé le nombre de personne de - de 20ans sur un echantillon de 20 personnes");
                int nombrepersonne = 0;
                Console.WriteLine("combien de personne font parti de l echantillons? :");
                nombrepersonne = int.Parse(Console.ReadLine());

                for (int i = 0; i < nombrepersonne; i++)
                {
                    Console.Write("entrer votre âge :");
                    age = int.Parse(Console.ReadLine());
                    if (age<20)
                    {
                        nbjeune++;
                    }

                }
                Console.WriteLine("il y a "+nbjeune+" personne(s) de moins de 20 ans dans l'échantillons");

                               
                


                Console.WriteLine("d'autre échantillon à verifier? o/n");
                test = Console.ReadLine();





            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
        }
    }
}
