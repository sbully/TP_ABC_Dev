using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce5
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            double s;                      // somme de départ
            double Sommeentré;             // somme à l'entré du magasin
            double sommesortie;             // somme sortie du magasin 
            int nombre = 1;                // nombre de magasin visité 
            do
            {

                Console.Clear();

                Console.WriteLine("Nous allons déterminé le nombre de magasins visité par Barnabé");
                Console.Write("Barnabé a combien sur lui au départ :");
                s = double.Parse(Console.ReadLine());
                if ( s > 1)
                {
                    Sommeentré = s;

                    for ( nombre = 0; Sommeentré>1 ; nombre++)
                    {//Sn+1=Sn -(Sn/2 +1)=Sn/2-1 
                        sommesortie = Sommeentré - ((Sommeentré / 2) + 1);
                        Sommeentré = sommesortie;
                    }
                    nombre += 1;
                    Console.WriteLine("Au total Barnabé a visité " + nombre + " magasins");

                }
                else
                {
                    if (s<0)
                    {
                        Console.WriteLine("Barnabé c'est fait raqueter!!!!");
                    }
                    else
                    {
                        Console.WriteLine("Barnabé a visité juste 1 magasin");        
                    }

                    
                }




                Console.WriteLine("Barnabé avec une autre somme de départ?? o/n");
                test = Console.ReadLine();

            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();

        }
    }
}
