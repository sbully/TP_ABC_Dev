using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce3b
{
    class Program
    {
        static void Main(string[] args)
        {

            string test;
            do
            {



                Console.Clear();
                int age = 0;
                int nbjeune = 0;
                bool entier = true;
                Console.WriteLine("Déterminé le nombre de personne de - de 20ans sur un echantillon de 20 personnes");
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("entrer votre âge :");
                    
                    do 
                    {
                        Console.Write("entrer votre âge :");
                        entier = int.TryParse(Console.ReadLine(), out age);

                        if ( entier == false)
                        {
                            Console.Write("!!Nombre entré incorrect!!");
                        }

                    }
                    while (!entier);
                    

                    if (age < 20)
                    {
                        nbjeune++;
                    }
             
                }
 

              switch (nbjeune)
                {
                    case 0:
                        Console.WriteLine("TOUTE LES PERSONNES ONT PLUS DE 20 ANS");
                        break;
                    case 20 :
                        Console.WriteLine("TOUTES LES PERSONNES ONT MOINS DE 20 ANS");
                        break;

                    default:
                        Console.WriteLine("il y a " + nbjeune + " personne(s) de moins de 20 ans dans l'échantillon");
                        break;
                }






                Console.WriteLine("d'autre échantillon à verifier? o/n");
                test = Console.ReadLine();





            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
        }


    }
}
