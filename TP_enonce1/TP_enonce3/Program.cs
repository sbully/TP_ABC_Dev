﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_enonce3
{
    class Program
    {
        static void Main(string[] args)
        {
            string livre;
            string litterature;
            string philo;
            string langue;
            string edition;
            string poche;
            string roman;
            string lu;
            string etat;
            string test = "o";

            while (test == "o")
            {
                
           
            Console.WriteLine("livre scolaire? o/n");
            livre = Console.ReadLine();
            if (livre == "o")
            {
                Console.WriteLine("livre litterature? o/n");
                litterature = Console.ReadLine();
                Console.WriteLine("livre de philosophie? o/n");
                philo = Console.ReadLine();
                Console.WriteLine("livre de langue étrangère? o/n");
                langue = Console.ReadLine();

                if (litterature == "o" || philo == "o" || langue == "o")
                {
                    Console.WriteLine("l'édition est elle posterieur à 1995? o/n");
                    edition = Console.ReadLine();
                    if (edition == "o")
                    {
                        Console.WriteLine("Mettre le livre scolaire dans la bibliothèque");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Mettre le livre scolaire dans la BOITESCOL");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Mettre le livre scolaire dans la BOITESCOL");
                    Console.ReadKey();

                }

            }
            else
            {
                Console.WriteLine("livre de poche? o/n");
                poche = Console.ReadLine();
                if (poche == "o")
                {
                    Console.WriteLine("ai je déjà lu le livre? o/n");
                    lu = Console.ReadLine();
                    if (lu == "o")
                    {
                        Console.WriteLine("est ce un roman? o/n");
                        roman = Console.ReadLine();
                        if (roman == "o")
                        {
                            Console.WriteLine("Mettre le livre de poche dans la BOITEROM");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Mettre le livre de poche dans la BOITEDIV");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Mettre le livre de poche dans la bibliothèque");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("est ce que l ouvrage est en bon état? o/n");
                    etat = Console.ReadLine();
                    if (etat == "o")
                    {
                        Console.WriteLine("Mettre l ouvrage en bon état dans la bibliothèque");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("est ce que l ouvrage en mauvais état est un roman? o/n");
                        roman = Console.ReadLine();
                        if (roman == "o")
                        {
                            Console.WriteLine("Mettre l ouvrage en mauvais état dans la BOITEROM");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Mettre l ouvrage en mauvais état dans la BOITERDIV");
                            Console.ReadKey();
                        }
                    }
                }
            }
            Console.WriteLine("d'autre livres a ranger? o/n");
            test = Console.ReadLine();

            }
          }
    }
}
