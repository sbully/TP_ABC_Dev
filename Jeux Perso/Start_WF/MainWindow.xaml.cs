using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Start_WF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //initialisation des variables
        List<Canon> bouletvisuel = new List<Canon>();
        List<Invader> listinvaders = new List<Invader>();

        System.Media.SoundPlayer applaudissement = new System.Media.SoundPlayer();
        System.Media.SoundPlayer explosion = new System.Media.SoundPlayer();
        System.Media.SoundPlayer tir = new System.Media.SoundPlayer();
        System.Media.SoundPlayer perdu = new System.Media.SoundPlayer();

        DispatcherTimer timer;
        DispatcherTimer timerboulet;

        Image img;
        Image inva;

        int parcours = 0;
        int lvldifficulte;
        int nbrInvader = 0;
        int scorefinal = 0;
        int i = 0;
        int j = 0;

        bool tireEnable = true;
        bool retourdestruction = false;
        bool partiestart = false;
        bool difficulte = true;
        bool fail = false;

        public static int Difficulty { get; set; } = 15;
        public static int Valeurscore { get; set; } = 10;
        public static int Init_timer_tick { get; set; } = 50;
        public static string Playername { get; set; } = "";
        public static FenetreDemarrage Demarrage { get; set; }




        public MainWindow()
        {
            InitializeComponent();
            string path = Directory.GetCurrentDirectory();
            explosion.SoundLocation = path + "\\explosion.wav";
            tir.SoundLocation = path + "\\tir.wav";
            applaudissement.SoundLocation = path +"\\applaudissement.wav";
            perdu.SoundLocation = path + "\\Clairon.wav";

            obus.Visibility = Visibility.Hidden;
            invader.Visibility = Visibility.Hidden;

            timer = new DispatcherTimer();                              // initialisation timer invaders
            timer.Interval = TimeSpan.FromMilliseconds(Init_timer_tick);
            timer.Tick += timer_Tick;

            timerboulet = new DispatcherTimer();                        // initialisation timer boulet
            timerboulet.Interval = TimeSpan.FromMilliseconds(10);
            timerboulet.Tick += timerboulet_Tick;

            timer.Start();
            timerboulet.Start();
        }


        private void timer_Tick(object sender, EventArgs e) // timer mouvement invaders
        {
            if (nbrInvader == lvldifficulte)
            {
                difficulte = false;
                partiestart = true;
            }


            foreach (Invader img_inva in listinvaders)
            {
                img_inva.invader.Margin = new Thickness(img_inva.invader.Margin.Left + 10, img_inva.invader.Margin.Top, img_inva.invader.Margin.Right - 10, img_inva.invader.Margin.Bottom);
                if (img_inva.invader.Margin.Right < 0)
                {
                    img_inva.invader.Margin = new Thickness(0, img_inva.invader.Margin.Top + 50, 630, img_inva.invader.Margin.Bottom - 50);
                }
            }


            if (i == 5 && difficulte == true)
            {
                nbrInvader++;
                i = 0;
                Invader New_invader = new Invader();
                inva = New_invader.Pop_Invader();
                grille.Children.Add(inva);
                listinvaders.Add(New_invader);
            }
            else
            {
                i++;
            }
        }

        private void timerboulet_Tick(object sender, EventArgs e) // timer boulet de canon 
        {
            foreach (Canon monboulet in bouletvisuel)
            {
                monboulet.boulet.Margin = new Thickness(monboulet.boulet.Margin.Left, monboulet.boulet.Margin.Top - 5, monboulet.boulet.Margin.Right, monboulet.boulet.Margin.Bottom + 5);
            }

            //apres 20 tick je reactive la touche de tire
            if (j == 20)
            {
                tireEnable = true;
            }
            j++;

            foreach (Canon Myboulet in bouletvisuel)
            {

                do
                {
                    parcours++;
                    retourdestruction = VerifCoordonne(Myboulet);

                } while (!retourdestruction && parcours < bouletvisuel.Count);
                if (retourdestruction)
                {
                    explosion.Play();
                    scorefinal = scorefinal + Valeurscore;
                    break;
                }
            }
            fail = Verif_Defaite();
            if (fail)
            {
                perdu.Play();
                timerboulet.Stop();
                timer.Stop();
                MessageBox.Show("Perdu " + Playername + " L'invasion a commencé!");
            }


            if (listinvaders.Count == 0 && partiestart)
            {
                applaudissement.Play();
                timerboulet.Stop();
                timer.Stop();
                MessageBox.Show("Bien joué " + Playername + " Vous avez gagné!!!!!!\nvotre score est de : "+scorefinal);

            }
        }


        private void Map_Loaded(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.KeyDown += tank_KeyDown;
            lvldifficulte = Difficulty;
        }

        private void tank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Right)
            {
                if (tank.Margin.Right > 10)
                {
                    tank.Margin = new Thickness(tank.Margin.Left + 10, 405, tank.Margin.Right - 10, 0);
                }


            }
            if (e.Key == Key.Left)
            {
                if (tank.Margin.Left > 0)
                {
                    tank.Margin = new Thickness(tank.Margin.Left - 10, 405, tank.Margin.Right + 10, 0);
                }

            }
            if (e.Key == Key.Space)
            {                               //desactiver la touche apres chaque tire, reactive la touche dans le timerboulet apres 20 ticks
                if (tireEnable == true)
                {
                    tir.Play();
                    Canon canon = new Canon();
                    canon.InitBoulet((tank.Margin.Left + 22.5), (tank.Margin.Right + 22.5));
                    img = canon.TireCanon();
                    grille.Children.Add(img);
                    bouletvisuel.Add(canon);
                    tireEnable = false;
                    j = 0;
                }
            }
        }

        public bool VerifCoordonne(Canon Myboulet)
        {
            bool destruction = false;

            foreach (Invader envahisseur in listinvaders)
            {
                if (Myboulet.boulet.Margin.Bottom == envahisseur.invader.Margin.Bottom)
                {
                    if (Myboulet.boulet.Margin.Left > envahisseur.invader.Margin.Left && Myboulet.boulet.Margin.Right > envahisseur.invader.Margin.Right)
                    {
                        Myboulet.boulet.Visibility = Visibility.Hidden;
                        envahisseur.invader.Visibility = Visibility.Hidden;
                        listinvaders.Remove(envahisseur);
                        bouletvisuel.Remove(Myboulet);
                        destruction = true;
                        break;
                    }
                }
            }


            return destruction;
        }

        public bool Verif_Defaite()
        {
            bool defaite = false;

            foreach (Invader envahisseur in listinvaders)
            {
                if (envahisseur.invader.Margin.Bottom < tank.Margin.Bottom + 40)
                {
                    defaite = true;
                    break;

                }

            }
            return defaite;
        }




        public class Canon //classe Canon
        {
            double _leftPlace;
            double _rightPlace;
            public Image boulet = new Image();




            public void InitBoulet(double _left, double _right) //récuperation des coordonné du boulet a afficher
            {
                _leftPlace = _left;
                _rightPlace = _right;

            }


            public Image TireCanon()
            {
                byte[] imageInfo = File.ReadAllBytes("bullet.PNG");
                BitmapImage image_boulet;
                using (MemoryStream imageStream = new MemoryStream(imageInfo))
                {

                    image_boulet = new BitmapImage();
                    image_boulet.BeginInit();
                    image_boulet.CacheOption = BitmapCacheOption.OnLoad;
                    image_boulet.StreamSource = imageStream;
                    image_boulet.EndInit();
                }

                this.boulet.Source = image_boulet;
                boulet.Margin = new Thickness(_leftPlace, 385, _rightPlace, 50);
                boulet.Name = "boulet";
                boulet.Width = 5;
                boulet.Height = 20;
                boulet.Visibility = Visibility.Visible;
                boulet.Stretch = Stretch.Fill;
                boulet.IsEnabled = true;
                return boulet;

            }


        }


        public class Invader        // classe Invader
        {

            public Image invader = new Image();

            //Margin="0,0,630,405" Source="inavders.png" Stretch="Fill" Width="50" Height="50"


            public Image Pop_Invader()
            {
                byte[] imageInfo = File.ReadAllBytes("inavders.PNG");
                BitmapImage image_invaders;
                using (MemoryStream imageStream = new MemoryStream(imageInfo))
                {
                    image_invaders = new BitmapImage();
                    image_invaders.BeginInit();
                    image_invaders.CacheOption = BitmapCacheOption.OnLoad;
                    image_invaders.StreamSource = imageStream;
                    image_invaders.EndInit();
                }

                this.invader.Source = image_invaders;
                invader.Margin = new Thickness(0, 0, 630, 405);
                invader.Name = "Invader";
                invader.Width = 50;
                invader.Height = 50;
                invader.Visibility = Visibility.Visible;
                invader.Stretch = Stretch.Fill;
                invader.IsEnabled = true;
                return invader;

            }


        }

        private void Map_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            applaudissement.Stop();
            perdu.Stop();
            Demarrage.Show();
        }
    }
}
