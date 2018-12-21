using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game_Voiture
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


       public static List<ScoreJoueur> ListScore = new List<ScoreJoueur>();

        public MainWindow()
        {

            InitializeComponent();

            VoitureRouge.Source = Voiture.Init_couleur("Rouge");

            VoitureBleu.Source = Voiture.Init_couleur("Bleu");

            VoitureJaune.Source = Voiture.Init_couleur("Jaune");


        }

        private void Voiture_MouseLeftButton(object sender, MouseButtonEventArgs e)
        {
            Image myImage = sender as Image;

            if (myImage != null)
            {
                MessageBox.Show(myImage.Name + " selectionnée");
                var gamestart = new Game_Car(this);
                gamestart.VoitureGame.Source = myImage.Source;
                Panel.SetZIndex(gamestart.VoitureGame, 100);
                gamestart.Show();
                this.Hide();
            }


        }
        /*
        private void VoitureRouge_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Voiture rouge selectionnée");
            var gamestart = new Game_Car(this);
            gamestart.VoitureGame.Source = VoitureRouge.Source;
            Panel.SetZIndex(gamestart.VoitureGame, 100);
            gamestart.Show();
            this.Hide();
        }

        private void VoitureBleu_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Voiture bleu selectionnée");
            var gamestart = new Game_Car(this);
            gamestart.VoitureGame.Source = VoitureBleu.Source;
            Panel.SetZIndex(gamestart.VoitureGame, 100);
            gamestart.Show();
            this.Hide();
        }

        private void VoitureJaune_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Voiture jaune selectionnée");
            var gamestart = new Game_Car(this);
            gamestart.VoitureGame.Source = VoitureJaune.Source;
            Panel.SetZIndex(gamestart.VoitureGame, 100);
            gamestart.Show();
            this.Hide();
        }
        */
        private void Demarrage_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }


}
