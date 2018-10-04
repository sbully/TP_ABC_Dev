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

            //char[,] dessintab = new char[19, 21];

            //for (int i = 0; i < 21; i++)
            //{
            //    dessintab[0, i] = ' ';
            //}
            //for (int i = 0; i < 21; i++)
            //{
            //    if (i > 1 && i < 16)
            //    {
            //        dessintab[1, i] = (char)219;
            //    }
            //    else
            //    {
            //        dessintab[1, i] = ' ';
            //    }

            //}
            //int j = 2;
            //do
            //{
            //    for (int i = 0; i < 21; i++)
            //    {
            //        if (i == 2)
            //        {
            //            dessintab[j, i] = (char)219;
            //        }
            //        else
            //        {
            //            dessintab[j, i] = ' ';
            //        }
            //    }
            //    j++;
            //} while (j < 15);

            //for (int i = 0; i < 21; i++)
            //{
            //    if (i != 0 && i < 18)
            //    {
            //        dessintab[15, i] = (char)219;
            //    }
            //    else
            //    {
            //        dessintab[15, i] = ' ';
            //    }
            //}
            //j = 16;
            //do
            //{
            //    for (int i = 0; i < 21; i++)
            //    {
            //        if (i == 2 || i == 9 || i == 16)
            //        {
            //            dessintab[j, i] = (char)219;
            //        }
            //        else
            //        {
            //            dessintab[j, i] = ' ';
            //        }
            //    }
            //    j++;
            //} while (j < 19);
            //j = 0;
            //do
            //{
            //    for (int i = 0; i < 21; i++)
            //    {
            //        Console.Write(dessintab[j, i]);
            //    }
            //    Console.Write("\n");
            //    j++;

            //} while (j < 19);







            //verification SI un mot de 5 caractère mini a bien été rentré

            do
            {
                compteur = 0;
                Console.WriteLine("entrer un mot " + (char)133 + " faire deviner (5 caractères mini):");
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
            Console.WriteLine(".........TOUR DE L ADVERSAIRE...............\n\n");
            do
            {
                //affichage 1ere et derniere lettre du mot :
                //Console.Clear();
                for (int i = 0; i < motsecret.Length; i++)
                {
                    Console.Write(" " + motsecret[i]);
                }
                Console.WriteLine("\n\n");


                //demande d'une lettre, et verification 
                do
                {

                    Console.WriteLine("Proposez une lettre (il vous reste {0}) erreur(s):", coup);
                    string stringtest = Console.ReadLine();
                    testchar = char.TryParse(stringtest, out test);
                    testcharint = int.TryParse(stringtest,out nbr);
                } while (!testchar||testcharint);

                Console.Clear();
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
                        tete();
                        break;
                    case 4:
                        tete();
                        corp();
                        break;
                    case 3:
                        tete();
                        corpbrasdroit();
                        break;
                    case 2:
                        tete();
                        corpsetbras();
                        break;
                    case 1:
                        tete();
                        corpsetbras();
                        jambedroite();

                        break;
                    case 0:
                        tete();
                        corpsetbras();
                        deuxjambes();
                        break;
                    default:
                        break;
                }

            } while (coup > 0 && !comp);


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
        static void tete()
        {
            Console.WriteLine("\t\t\t" + (char)219 + (char)219 + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t" + (char)219 + (char)219 + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t" + (char)219 + (char)219 + (char)219 + (char)219 + (char)219);
        }
        static void corp()
        {
            Console.WriteLine("\t\t\t  " + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
        }
        static void corpbrasdroit()
        {
            Console.WriteLine("\t\t\t  " + (char)219);
            Console.WriteLine("\t\t      " + (char)219 + (char)219 + (char)219 + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t      " + (char)219 + "  " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
        }
        static void corpsetbras()
        {
            Console.WriteLine("\t\t\t  " + (char)219);
            Console.WriteLine("\t\t      " + (char)219 + (char)219 + (char)219 + (char)219 + (char)219 + (char)219 + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t      " + (char)219 + "  " + (char)219 + (char)219 + (char)219 + "  " + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
            Console.WriteLine("\t\t\t " + (char)219 + (char)219 + (char)219);
        }
        static void jambedroite()
        {
            Console.WriteLine("\t\t\t " + (char)176);
            Console.WriteLine("\t\t\t " + (char)176);
            Console.WriteLine("\t\t\t " + (char)176);
            Console.WriteLine("\t\t\t" + (char)219 + (char)219);
        }
        static void deuxjambes()
        {
            Console.WriteLine("\t\t\t " + (char)176 + " " + (char)176);
            Console.WriteLine("\t\t\t " + (char)176 + " " + (char)176);
            Console.WriteLine("\t\t\t " + (char)176 + " " + (char)176);
            Console.WriteLine("\t\t\t" + (char)219 + (char)219 + " " + (char)219 + (char)219);
        }

    }
}
