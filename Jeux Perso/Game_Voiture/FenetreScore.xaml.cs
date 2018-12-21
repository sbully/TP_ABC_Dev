using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Game_Voiture
{
    /// <summary>
    /// Logique d'interaction pour FenetreScore.xaml
    /// </summary>
    public partial class FenetreScore : Window
    {

        public Game_Car Game;
        //public MainWindow demarrage = new MainWindow();
        public MainWindow demarrage;
        static public int voitureEvite;
        static public int parcours;

        public FenetreScore()
        {
            InitializeComponent();
        }

        public FenetreScore(Game_Car _Game, MainWindow _demarrage) : this()
        {
            Game = _Game;
            demarrage = _demarrage;
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FenetreScore1_Loaded(object sender, RoutedEventArgs e)
        {
            ScoreJoueur joueur = new ScoreJoueur(demarrage.Nom_joueur.Text, Game_Car.voitureEvite, Game_Car.parcours - 100);
            MainWindow.ListScore.Add(joueur);
            LabelVoitEvit.Content = demarrage.Nom_joueur.Text + " Voiture évitées : " + Game_Car.voitureEvite;
            LabelDist.Content = "distance parcourue : " + (Game_Car.parcours - 100) + " mètres";
        }

        private void FenetreScore1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Game.Close();
            demarrage.Show();
        }
    }
}
