using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableau_2dim
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabF;

            // initialisation tableau et rentré des noms de formations et nombre de stagiaires
            tabF = Init_Tableau();
            //tri du tableau
            tabF = Trier_Tableau(tabF);
            //affichage tableau
            affichage_tableau(tabF);
            Console.ReadKey();


        }


        static string[,] Init_Tableau()
        {
            int taille;
            int j = 0;
            Console.WriteLine("Bonjour, combien de formations sont dispensée? : ");
            taille = int.Parse(Console.ReadLine());
            string[,] tableau = new string[taille, 2];
            for (int i = 0; i < taille; i++)
            {
                j = 0;
                Console.Write("entrer le nom de la formation :");
                tableau[i, j] = Console.ReadLine();
                j++;
                Console.Write("entrer le nombre de stagiaires :");
                tableau[i, j] = Console.ReadLine();


            }
            return tableau;
        }
        
        static void affichage_tableau(string[,] tab)
        {
            int n = tab.GetLength(0);
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                j = 0;
                Console.Write("nom de la formation : " + tab[i, j] + " nombre de stagiaire :" + tab[i, ++j] + "\n");

            }

        }

        static string[,] Trier_Tableau(string[,] tab)
        {
            
            int nbpetit;
            int tempo;
            string tmpstring;
            string string_echange;
            int longeur = tab.GetLength(0);

            for (int curseur = 0; curseur < longeur-1; curseur++)
            {
                
                nbpetit = int.Parse(tab[curseur, 1]);
                tmpstring = tab[curseur, 0];
                for (int parcour = curseur+1; parcour < longeur; parcour++)
                {
                    if (nbpetit > int.Parse(tab[parcour, 1]))
                    {
                        tempo = int.Parse(tab[parcour, 1]);
                        tab[parcour, 1] = Convert.ToString(nbpetit);
                        nbpetit = tempo;
                        string_echange = tab[parcour, 0];
                        tab[parcour, 0] = tmpstring;
                        tmpstring = string_echange;
                    }
                }
                tab[curseur, 1] = Convert.ToString(nbpetit);
                tab[curseur, 0] = tmpstring;
            }
            return tab;
        }
    }
}
