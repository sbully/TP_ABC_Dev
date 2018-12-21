using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoitureTri;

namespace exo_Kilou
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Voiture> MyListVoiture = new List<Voiture>();
            List<Voiture> ListVoitureMaj = new List<Voiture>();

            bool finTri = false;
            
            // creation des voitures en donnant numerodeserie marque modele
            // version utilisateur qui rentre les caractéristiques de la voiture

            //MyListVoiture = Init_List_Manu();


            // creation des voitures en donnant numerodeserie marque modele 
            //version caractéristiques déjà rentrées

            MyListVoiture = Init_List();
            //MyListVoiture.Sort();
            //Affichage_List(MyListVoiture);
            //Console.ReadKey();
            // Affichage de la list MyListVoiture contenant des objets Voiture
            Affichage_List(MyListVoiture);
            Console.ReadKey();

            do
            {
                Tri_List(ref MyListVoiture); //tri de la liste
                Affichage_List(MyListVoiture); // affichage de la liste trié
                finTri = FinTri();
            } while (!finTri);
            Console.ReadKey();
            ListVoitureMaj = AjoutDate(MyListVoiture);
            New_Affichage_List(ListVoitureMaj);
            do
            {
                Console.Clear();
                Tri_New_List(ref ListVoitureMaj);
                New_Affichage_List(ListVoitureMaj);
                finTri = FinTri();
            } while (!finTri);

            Console.WriteLine("Bonne journée!");
            Console.ReadKey();
        }

        static bool FinTri()
        {
            bool finTri = false;
            Console.WriteLine("voulez vous trier autrement? [o/n]");
            //testFinTri = char.Parse(Console.ReadLine());
            if (char.Parse(Console.ReadLine()) == 'n')
            {
                finTri = true;
            }

            return finTri;
        }
        public static List<Voiture> AjoutDate(List<Voiture> _Mylist) //ajout de la date de mise en circulation
        {
            List<Voiture> ancienneList = _Mylist;
            List<Voiture> newList = new List<Voiture>();
            foreach (Voiture oldCar in ancienneList)
            {
                DateTime Circu = new DateTime();
                Console.WriteLine(oldCar.SerieVoiture + " " + oldCar.MarqueVoiture + " " + oldCar.ModeleVoiture + " Date de mise en circulation :");
                Circu = DateTime.Parse(Console.ReadLine());
                Voiture newvoiture = new Voiture(oldCar, Circu);
                newList.Add(newvoiture);
            }

            return newList;
        }
        static void Tri_List(ref List<Voiture> _listNonTrie)
        {
            int tri;
            Console.Write("trié les voitures par :\n[1] Numéro de Série  \n[2] Marque \n[3] Modèle \nChoix du tri :");
            tri = int.Parse(Console.ReadLine());

            switch (tri)
            {
                case 1:
                    _listNonTrie = _listNonTrie.OrderBy(x => x.SerieVoiture).ToList();
                    break;
                case 2:
                    _listNonTrie = _listNonTrie.OrderBy(x => x.MarqueVoiture).ToList();
                    break;
                case 3:
                    _listNonTrie = _listNonTrie.OrderBy(x => x.ModeleVoiture).ToList();
                    break;
                default:
                    Console.WriteLine("Erreur de saisie, paramètre de tri incorrect");
                    break;
            }

        } // Tri liste voiture
        static void Tri_New_List(ref List<Voiture> _newListVoiture)
        {
            int tri;
            Console.Write("trié les voitures par :\n[1] Numéro de Série  \n[2] Marque \n[3] Modèle \n[4] date de mise en circulation\nChoix du tri :");
            tri = int.Parse(Console.ReadLine());

            switch (tri)
            {
                case 1:
                    _newListVoiture = _newListVoiture.OrderBy(x => x.SerieVoiture).ToList();
                    break;
                case 2:
                    _newListVoiture = _newListVoiture.OrderBy(x => x.MarqueVoiture).ToList();
                    break;
                case 3:
                    _newListVoiture = _newListVoiture.OrderBy(x => x.ModeleVoiture).ToList();
                    break;
                case 4:
                    _newListVoiture = _newListVoiture.OrderBy(x => x.MiseEnCirculation).ToList();
                    break;
                default:
                    Console.WriteLine("Erreur de saisie, paramètre de tri incorrect");
                    break;
            }
        } //Tri Liste voiture avec DME ajouter 
        static void Affichage_List(List<Voiture> resultat)
        {
            //foreach (Voiture tabVoiture in resultat)
            //{
            //    Console.WriteLine(" numéro de série :" + tabVoiture.SerieVoiture + " marque " + tabVoiture.MarqueVoiture + " Modèle : " + tabVoiture.ModeleVoiture);
            //}
            Console.WriteLine("N°série\t  Marque \tModèle ");
            foreach (Voiture tabVoiture in resultat)
            {
                Console.WriteLine(tabVoiture.SerieVoiture + "\t " + tabVoiture.MarqueVoiture + "    \t" + tabVoiture.ModeleVoiture );
            }

        } // Affichage liste de voiture 
        static void New_Affichage_List(List<Voiture> list_affichage)
        {
            Console.WriteLine("N°série\t  Marque \t   Modèle \t Mise en circulation ");
            foreach (Voiture tabVoiture in list_affichage)
            {
                Console.WriteLine(tabVoiture.SerieVoiture + "\t " + tabVoiture.MarqueVoiture + "    \t" + tabVoiture.ModeleVoiture + "     \t" + tabVoiture.MiseEnCirculation.ToString("d-MMMM-yyyy"));
            }
        } // Affichage de la liste de voiture avec DME ajouter
        static List<Voiture> Init_List()
        {
            List<Voiture> tempo = new List<Voiture>();
            Voiture Car = new Voiture("2098", "Peugeot", "307");
            tempo.Add(Car);
            Car = new Voiture("1987", "Renault", "Espace");
            tempo.Add(Car);
            Car = new Voiture("1203", "Lancia", "Dedra");
            tempo.Add(Car);
            Car = new Voiture("3049", "BMW", "324d");
            tempo.Add(Car);
            Car = new Voiture("1500", "Peugeot", "406");
            tempo.Add(Car);
            Car = new Voiture("2500", "Ford", "Mondeo");
            tempo.Add(Car);
            return tempo;
        } // initialisation auto de la liste de voiture
        static List<Voiture> Init_List_Manu()
        {
            string numSerieVoit;
            string marqueVoit;
            string modeleVoit;
            bool Fini = false;
            List<Voiture> tempo = new List<Voiture>();
            do
            {

                
                Console.Write("entrer le numéro de serie : ");
                numSerieVoit = Console.ReadLine();
                Console.Write("entrer la marque : ");
                marqueVoit = Console.ReadLine();
                Console.Write("entrer le modèle : ");
                modeleVoit = Console.ReadLine();
                Voiture Car = new Voiture(numSerieVoit,marqueVoit,modeleVoit);
                tempo.Add(Car);
                Console.Write("Avez vous d'autres voitures à répertorier ? [o/n]");
                if (char.Parse(Console.ReadLine()) == 'n')
                {
                    Fini = true;
                }
            } while (!Fini);

            return tempo;
        } // création manuel de la liste de voiture
    }
}

