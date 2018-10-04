using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enonce7
{
    class Program
    {
        
        


        static void Main(string[] args)
        {


            string test;
            
            do
            {

            int valeurmois =0;
            int reste7;
            int resultat4;
            Console.Clear();
            Console.WriteLine("déterminé le jour de la semaine pour une date (type : jj/mm/aa ) comprise entre 1900 et 2000 (non inclu)");
            Console.WriteLine("Entrer le jour");
            int jour = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer le mois (ex : 1 pour janvier etc...)");
            int mois = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer les 2 derniers chiffre de l année (compris entre 1900 et 2000 non inclu)");
            int annee = int.Parse(Console.ReadLine());
            int bi = annee % 4;
            resultat4 = annee / 4;


            switch (mois)
            {
                case 1 :                                    // janvier
                    if (bi == 0)
                    {
                    valeurmois = 0;                         // année bisextile         
                    }
                    else
                	{
                    valeurmois = 1;                         // année non bisextile
                	}
                    break;

                case 2:                                     // février
                     if (bi == 0)
                    {
                    valeurmois = 3;                         // année bisextile         
                    }
                    else
                	{
                    valeurmois = 4;                         // année non bisextile
                	}
                    break;
                case 3:                                     //mars
                    valeurmois = 4;
                    break;
                case 4:                                     //avril
                    valeurmois = 0;
                    break;
                case 5:                                     //mai
                    valeurmois = 2;
                    break;
                case 6:                                     //juin
                    valeurmois = 5;
                    break;
                case 7:                                     //juillet
                    valeurmois = 0;
                    break;
                case 8:                                     //aout
                    valeurmois = 3;
                    break;
                case 9:                                     //septembre
                    valeurmois = 6;
                    break;
                case 10:                                    //octobre
                    valeurmois = 1;
                    break;
                case 11:                                    //novembre
                    valeurmois = 4;
                    break;
                case 12:                                    //decembre
                    valeurmois = 6;
                    break;

                default:
                    break;
            }

            reste7 = (annee + resultat4 + valeurmois + jour ) %7 ;
//            Console.WriteLine("resultat4 =" + resultat4);                       //test des variables
//            Console.WriteLine("valeurmois = " +valeurmois);
//            Console.WriteLine("reste7 ="+ reste7);


            switch (reste7)
            {
                case 0:                                                             // samedi
                    Console.WriteLine("c'était un samedi");
                    break;
                case 1:                                                             // dimanche
                    Console.WriteLine("c'était un dimanche");
                    break;
                case 2:                                                             // lundi
                    Console.WriteLine("c'était un lundi");
                    break;
                case 3:                                                             // mardi
                    Console.WriteLine("c'était un mardi");
                    break;
                case 4:                                                             // mercredi
                    Console.WriteLine("c'était un mercredi");
                    break;
                case 5:                                                             // jeudi
                    Console.WriteLine("c'était un jeudi");
                    break;
                case 6:                                                             // vendredi
                    Console.WriteLine("c'était un vendredi");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Autre jours à déterminer?");
            test = Console.ReadLine();

            } while (test == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();

        }
    }
}
