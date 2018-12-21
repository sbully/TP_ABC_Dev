using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercice2_tableau_login
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] tabLogins = new string[3, 2];
            
            string login;
            string motdepasse;
            int i;
            bool motDePasseEstValide=false;

            //définir les logins dans le tableau
            tabLogins[0,0] = "user";
            tabLogins[0,1] = "";
            tabLogins[1,0] = "adelon";
            tabLogins[1,1] = "leclandessiciliens";
            tabLogins[2,0] = "jbelmondo";  // nom
            tabLogins[2,1] = "leprofessionnel";  // mot de passe

            Console.WriteLine("Entrez votre login svp :");
            login = Console.ReadLine();
            Console.WriteLine("entrez votre mot de passe svp :");
            motdepasse = Console.ReadLine();
            for ( i = 0; i < tabLogins.GetLength(0) && !motDePasseEstValide; i++)
            {
                if (tabLogins[i, 0] == login && tabLogins[i, 1] == motdepasse)
                {
                    motDePasseEstValide = true;
                }
                
            }

            if (motDePasseEstValide)
            {
                Console.WriteLine("la connexion est réussie"); 
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas autorisé à vous connecter");
                Console.WriteLine("Contactez votre administrateur système");
            }


            Console.ReadKey();


        }
    }
}
