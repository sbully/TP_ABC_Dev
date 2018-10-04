using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce6
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            do
            {

                Console.Clear();
                int scorepc = 0;
                int scoreplayer = 0;
                int nombrepc = new Random().Next(0, 3);
                int nombreplayer=0;
                Console.WriteLine("................................................................................");
                Console.WriteLine(":                               JEU DU 0-1-2                                   :");
                Console.WriteLine("................................................................................");

                do
                {
                    //nombrepc = new Random().Next(0, 3);
                    Random alea = new Random();
                    nombrepc = alea.Next(0, 3);

                    Console.Write("choisi un nombre entre 0 et 2 compris : ");
                    nombreplayer = int.Parse(Console.ReadLine());
                    int score = Math.Abs( nombrepc-nombreplayer);
                    if (nombreplayer > 0)
                    {


                        switch (score)
                        {
                            case 0:
                                Console.WriteLine("Egalité, aucun points marqué");
                                break;
                            case 1:
                                if (nombrepc > nombreplayer)
                                {
                                    Console.WriteLine("player gagne 1 pts");
                                    scoreplayer++;
                                }
                                else
                                {
                                    Console.WriteLine("PC gagne 1 pts");
                                    scorepc++;
                                }
                                break;

                            case 2:
                                if (nombrepc < nombreplayer)
                                {
                                    Console.WriteLine("player gagne 1 pts");
                                    scoreplayer++;
                                }
                                else
                                {
                                    Console.WriteLine("PC gagne 1 pts");
                                    scorepc++;
                                }
                                break;

                            default:
                                break;
                        }

                        Console.WriteLine("score actuel :" + scorepc + " à " + scoreplayer);
                    }

                }while ((scorepc<5) && (scoreplayer<5) && (nombreplayer>0));


                if (nombreplayer < 0)
                {
                    Console.WriteLine("................................................................................");
                    Console.WriteLine("                         Le joueur a abandonné                                  ");
                    Console.WriteLine("................................................................................");
                }
                else
                {


                    Console.WriteLine("................................................................................");
                    Console.WriteLine("le score final est de " + scorepc + " pour l'ordi à " + scoreplayer + " pour le joueur");

                    if (scorepc > scoreplayer)
                    {
                        Console.WriteLine("!!!!! LES MACHINES VONT PRENDRE LE CONTROLE!!!!!");
                    }
                    else
                    {
                        Console.WriteLine("!!!!!LES HUMAINS SONT LES PLUS FORT!!!!!!");
                    }

                    Console.WriteLine("................................................................................");

                }




                Console.Write("tu veux rejouer?? o/n :");
                test = Console.ReadLine();

            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();


        }
    }
}
