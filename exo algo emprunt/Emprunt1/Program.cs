using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emprunt1
{
    class Program
    {
        static void Main(string[] args)
        {
            string boucle;
            do
            {


            double tauxannuel, capitalEmprunte, annuite, mensualite, interetMois, amortissementMois=0, capitalRestant;
            double tauxmensuel , mois, Q;
            double taux;
            double nrbAnneeRbmt;
            int n = 0;
            bool test = false;

            Console.Clear();
            Console.WriteLine("Jeu de l emprunt (si emprunté est un jeu??...");

            do
            {
            Console.Write("Quel montant souhaitez vous emprunter : ");
//            capitalEmprunte = double.Parse(Console.ReadLine());
            test = double.TryParse(Console.ReadLine(), out capitalEmprunte);
            } while (!test || capitalEmprunte<0);
            do
            {
            Console.Write("Quel est le taux annuel de l'emprunt en % : ");
//            tauxannuel = double.Parse(Console.ReadLine())/100;
            test = double.TryParse(Console.ReadLine(), out taux);
            tauxannuel = taux / 100;
            } while (!test || taux<0);

            do
            {
            Console.Write("sur combien d'année souhaitez vous emprunter :");
//            nrbAnneeRbmt = double.Parse(Console.ReadLine());
            test = double.TryParse(Console.ReadLine(), out nrbAnneeRbmt);
            } while (!test || nrbAnneeRbmt<1);


            mois = nrbAnneeRbmt * 12;
            tauxmensuel = tauxannuel / 12;
            Q= 1-Math.Pow(((1+tauxmensuel)),-mois);
            mensualite = capitalEmprunte * (tauxmensuel / Q );
            annuite = mensualite * 12;
            interetMois = capitalEmprunte * tauxmensuel;

//            Console.WriteLine(" affichage variable mois: "+mois);
//            Console.WriteLine(" affichage variable Q: " +Q);
//            Console.WriteLine(" affichage variable taux mensuel: "+ tauxmensuel);


            Console.WriteLine("\nl'annuité est de : {0:#,###.00} ", annuite);
            Console.WriteLine("la mensualité constante est de : {0:#,###.00} ", mensualite);

            Console.ReadKey();
            Console.WriteLine("\n \n mois \t| part interet \t\t| part capital \t\t| capital restant \t| mensualité");
            Console.WriteLine("..................................................................................................");
            capitalRestant = capitalEmprunte;
            do
            {
                if (n % 20 == 0 && n!=0)                    // attente validation tout les 20 mois affiché
                {

                    Console.WriteLine("..................................................................................................");
                    Console.ReadKey();
                }
                n++;

                interetMois = capitalRestant * tauxmensuel;
                amortissementMois = mensualite-interetMois;
                capitalRestant =capitalRestant-amortissementMois;
              
                
                Console.WriteLine("  " + n + "\t|\t{0:#,##0.0}\t\t|\t{1:#,##0.0}\t\t|\t{2:#,##0}\t\t|\t{3:#,###}", interetMois, amortissementMois, capitalRestant, mensualite);
            } while (n<mois);


            Console.ReadKey();

                Console.WriteLine("\n\nautre emprunt à rechercher? o/n");
                boucle = Console.ReadLine();
            } while (boucle == "o");
            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
        
        
        
        
        
        
        
        }
    }
}
