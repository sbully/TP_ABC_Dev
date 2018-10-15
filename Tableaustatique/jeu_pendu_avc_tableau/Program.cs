using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce6_jeu_du_pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
            string secret;
            int compteur = 0;
            bool question = false;
            bool testchar = false;
            bool lettretrouve = false;
            bool testcharint = false;
            bool tete = false;
            bool corp = false;
            bool brasdroit = false;
            bool brasgauche = false;
            bool jambedroite = false;
            bool jambegauche = false;
            int nbr;
            int testnbr;
            char test;
            int compare;
            bool comp = false;
            int coup = 6;
            int curseur = 0;
            int curseur2 = 0;
            Console.WriteLine("...............................");
            Console.WriteLine("\tJEU DU PENDU");
            Console.WriteLine("...............................");

            char[,] dessintab = new char[19, 21];

            for (int i = 0; i < 21; i++)
            {
                dessintab[0, i] = ' ';
            }
            for (int i = 0; i < 21; i++)
            {
                if (i > 1 && i < 16)
                {
                    dessintab[1, i] = (char)219;
                }
                else
                {
                    dessintab[1, i] = ' ';
                }

            }
            int j = 2;
            do
            {
                for (int i = 0; i < 21; i++)
                {
                    if (i == 2)
                    {
                        dessintab[j, i] = (char)219;
                    }
                    else
                    {
                        dessintab[j, i] = ' ';
                    }
                }
                j++;
            } while (j < 15);

            for (int i = 0; i < 21; i++)
            {
                if (i != 0 && i < 21)
                {
                    dessintab[15, i] = (char)219;
                }
                else
                {
                    dessintab[15, i] = ' ';
                }
            }
            j = 16;
            do
            {
                for (int i = 0; i < 21; i++)
                {
                    if (i == 2 || i == 9 || i == 19)
                    {
                        dessintab[j, i] = (char)219;
                    }
                    else
                    {
                        dessintab[j, i] = ' ';
                    }
                }
                j++;
            } while (j < 19);



            //verification SI un mot de 5 caractère mini a bien été rentré

            do
            {
                compteur = 0;
                Console.WriteLine("entrer un mot " + (char)133 + " faire deviner (5 caract" + (char)138 + "re mini):");
                secret = Console.ReadLine();

                for (int i = 0; i < secret.Length; i++)
                {
                    if (secret[i] == '.' || secret[i] == ' ')
                    {
                        compteur++;
                    }
                }
                if (int.TryParse(secret, out testnbr))
                {
                    Console.WriteLine("J'ai dit UN MOT, pas un nombre!!");
                    question = false;
                }
                else
                {
                    if (compteur != 0 || secret.Length < 5)
                    {
                        Console.WriteLine("J'ai dit UN MOT de 5 caract" + (char)138 + "res, sans caract+ (char)138 +res speciaux ni espace ni point!!");
                    }
                    else
                    {
                        question = true;
                    }
                }
            } while (!question);



            compteur = 0;
            //transformation en minuscule et clonage de la chaine rentré passage en tableau de char
            secret = secret.ToLower();
            int longueur = (secret.Length) - 1;
            string secret2 = (string)secret.Clone();
            char[] motsecret = secret2.ToCharArray();


            //affichage 1ere et derniere lettre du mot secret
            foreach (int item in secret2)
            {
                if (compteur == 0)
                {
                    compteur++;
                }
                else
                {
                    if (compteur == longueur)
                    {
                        compteur++;
                    }
                    else
                    {
                        motsecret[compteur] = '_';
                        compteur++;
                    }
                }
            }


            //tour de l adversaire 
            Console.Clear();

            do
            {

                //demande d'une lettre, et verification 
                do
                {
                    Console.WriteLine(".........TOUR DE L ADVERSAIRE...............\n");
                    j = 0;
                    do                             // AFFICHAGE PENDU
                    {
                        for (int i = 0; i < 21; i++)
                        {
                            if (coup == 6)
                            {
                                Console.Write(dessintab[j, i]);

                            }
                            else
                            {
                                test_tete(j, i, dessintab);
                            }

                        }

                        if (j == 10)            //affichage mot secret a droite du pendu a la ligne 11
                        {
                            for (int i = 0; i < motsecret.Length; i++)
                            {
                                Console.Write(" " + motsecret[i]);
                            }
                        }
                        Console.Write("\n");
                        j++;

                    } while (j < 19);












                    Console.WriteLine("Proposez une lettre (il vous reste {0}) erreur(s):", coup);
                    string stringtest = Console.ReadLine();
                    testchar = char.TryParse(stringtest, out test);
                    testcharint = int.TryParse(stringtest, out nbr);
                } while (!testchar || testcharint);

                //Console.Clear();


                curseur = 0;
                curseur2 = 0;
                lettretrouve = false;

                foreach (char nombre in secret)
                {
                    if (nombre == test)
                    {
                        motsecret[curseur] = nombre;
                        lettretrouve = true;
                    }
                    curseur++;
                }
                if (!lettretrouve)
                {
                    coup--;
                }


                //verification jeu terminé
                do
                {
                    compare = secret[curseur2].CompareTo(motsecret[curseur2]);
                    if (compare != 0)
                    {
                        comp = false;
                    }
                    else
                    {
                        comp = true;
                    }
                    curseur2++;
                } while (curseur2 < longueur && comp);



                //dessin du pendu
                switch (coup)
                {
                    case 5:
                        tete = true;
                        dessintab[2, 14] = (char)186;
                        dessintab[3, 13] = (char)219;
                        dessintab[3, 14] = (char)219;
                        dessintab[3, 15] = (char)219;
                        dessintab[4, 13] = (char)219;
                        dessintab[4, 14] = (char)219;
                        dessintab[4, 15] = (char)219;
                        dessintab[5, 14] = (char)219;
                        break;
                    case 4:
                        corp = true;
                        dessintab[6, 13] = (char)176;
                        dessintab[6, 14] = (char)176;
                        dessintab[6, 15] = (char)176;
                        dessintab[7, 13] = (char)176;
                        dessintab[7, 14] = (char)176;
                        dessintab[7, 15] = (char)176;
                        dessintab[8, 13] = (char)176;
                        dessintab[8, 14] = (char)176;
                        dessintab[8, 15] = (char)176;
                        dessintab[9, 13] = (char)176;
                        dessintab[9, 14] = (char)176;
                        dessintab[9, 15] = (char)176;
                        break;
                    case 3:
                        brasdroit = true;
                        dessintab[6, 10] = (char)219;
                        dessintab[6, 11] = (char)219;
                        dessintab[6, 12] = (char)219;
                        dessintab[7, 10] = (char)219;
                        break;
                    case 2:
                        brasgauche = true;
                        dessintab[6, 16] = (char)219;
                        dessintab[6, 17] = (char)219;
                        dessintab[6, 18] = (char)219;
                        dessintab[7, 18] = (char)219;

                        break;
                    case 1:
                        jambedroite = true;
                        dessintab[10, 13] = (char)219;
                        dessintab[11, 13] = (char)219;
                        dessintab[12, 13] = (char)178;
                        dessintab[12, 12] = (char)178;

                        break;
                    case 0:
                        jambegauche = true;
                        dessintab[10, 15] = (char)219;
                        dessintab[11, 15] = (char)219;
                        dessintab[12, 15] = (char)178;
                        dessintab[12, 16] = (char)178;
                        dessintab[15, 14] = ' ';
                        dessintab[15, 15] = ' ';
                        dessintab[15, 16] = ' ';
                        dessintab[15, 13] = ' ';
                        dessintab[15, 12] = ' ';
                        dessintab[15, 11] = ' ';
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (coup > 0 && !comp);
            Console.Clear();
            j = 0;
            //do
            //{
            //    for (int i = 0; i < 21; i++)
            //    {
            //        Console.Write(dessintab[j, i]);
            //    }
            //    Console.Write("\n");
            //    j++;

            //} while (j < 19);
            do                             // AFFICHAGE PENDU
            {
                for (int i = 0; i < 21; i++)
                {
                    if (coup == 6)
                    {
                        Console.Write(dessintab[j, i]);

                    }
                    else
                    {
                        test_tete(j, i, dessintab);
                    }

                }

                if (j == 10)            //affichage mot secret a droite du pendu a la ligne 11
                {
                    for (int i = 0; i < motsecret.Length; i++)
                    {
                        Console.Write(" " + motsecret[i]);
                    }
                }
                Console.Write("\n");
                j++;

            } while (j < 19);

            if (comp)
            {
                Console.WriteLine("......................................");
                Console.WriteLine("Bien jou" + (char)130 + ", tu as trouver le mot cach" + (char)130 + " ");
                Console.WriteLine("......................................");
            }
            else
            {
                Console.WriteLine("Dommage tu n as pas r" + (char)130 + "ussi le mot secret " + (char)130 + "tait :");
                for (int i = 0; i < motsecret.Length; i++)
                {
                    Console.Write(" " + secret[i]);
                }

            }



            Console.ReadKey();


        }


        static void test_tete(int a, int b, char[,] tab)
        {
            Console.ResetColor();
            if (((a == 3 && b == 13) || (a == 3 && b == 14) || (a == 3 && b == 15) || (a == 4 && b == 13) || (a == 4 && b == 14) || (a == 4 && b == 15) || (a == 5 && b == 14)))
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
                //Console.Write(tab[a, b]);
            }
            if (((a == 6 && b == 13) || (a == 6 && b == 14) || (a == 6 && b == 15) || (a == 7 && b == 13) || (a == 7 && b == 14) || (a == 7 && b == 15 || (a == 8 && b == 13) || (a == 8 && b == 14) || (a == 8 && b == 15) || (a == 9 && b == 13) || (a == 9 && b == 14) || (a == 9 && b == 15))))
            {
                Console.ForegroundColor = System.ConsoleColor.DarkGreen;
            }
            if ((a == 6 && b == 10) || (a == 6 && b == 11) || (a == 6 && b == 12) || (a == 7 && b == 10))
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
            }
            if ((a == 6 && b == 16) || (a == 6 && b == 17) || (a == 6 && b == 18) || (a == 7 && b == 18))
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
            }
            if ((a == 10 && b == 13) || (a == 11 && b == 13) )
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
            }
            if ((a == 12 && b == 12) || (a == 12 && b == 13))
            {
                Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            }
            if ((a == 10 && b == 15) || (a == 11 && b == 15))
            {
                Console.ForegroundColor = System.ConsoleColor.Red;
            }
            if ((a == 12 && b == 16) || (a == 12 && b == 15))
            {
                Console.ForegroundColor = System.ConsoleColor.DarkBlue;
            }

            Console.Write(tab[a, b]);

        }

    }






}



