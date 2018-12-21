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

namespace Game_Voiture
{
    /// <summary>
    /// Logique d'interaction pour Game_Car.xaml
    /// </summary>
    public partial class Game_Car : Window
    {
        List<Voiture> ListVoiture = new List<Voiture>();
        List<Route> MyRoute = new List<Route>();

        public MainWindow demarrage;

        DispatcherTimer TimeRoute = new DispatcherTimer();
        DispatcherTimer PopVoiture = new DispatcherTimer();
        DispatcherTimer CarSpeed = new DispatcherTimer();

        bool creation = false;
        bool depart = true;
        bool accident;
        static public int parcours;
        static public int voitureEvite;
        string carColor;

        public Game_Car()
        {
            InitializeComponent();
            parcours = 0;
            voitureEvite = 0;
            Route RoadStart = new Route();
            Image img_roadstart = RoadStart.Init_Route();
            RoadStart.road.Margin = new Thickness(10, -8, 0, 0);
            Grille.Children.Add(img_roadstart);
            MyRoute.Add(RoadStart);

            TimeRoute.Interval = TimeSpan.FromMilliseconds(50);
            TimeRoute.Tick += TimeRoute_Tick;

            PopVoiture.Interval = TimeSpan.FromMilliseconds(5000);
            PopVoiture.Tick += PopVoiture_Tick;

            CarSpeed.Interval = TimeSpan.FromMilliseconds(10);
            CarSpeed.Tick += CarSpeed_Tick;

            TimeRoute.Start();
            CarSpeed.Start();
            PopVoiture.Start();
        }

        public Game_Car(MainWindow _mainW) : this()
        {
            demarrage = _mainW;
        }

        private void CarSpeed_Tick(object sender, EventArgs e) // défilement des voitures
        {
            foreach (Voiture carPosition in ListVoiture)
            {
                carPosition.Car.Margin = new Thickness(carPosition.Car.Margin.Left, carPosition.Car.Margin.Top + 10, carPosition.Car.Margin.Right, carPosition.Car.Margin.Bottom - 10);

            }

            accident = VerifCoordonne(ListVoiture);
            if (accident)
            {
                End_Game();
            }
            foreach (Voiture voit in ListVoiture)
            {
                if (voit.Car.Margin.Bottom < -189)
                {
                    voit.Car.Visibility = Visibility.Hidden;
                    ListVoiture.Remove(voit);
                    voitureEvite++;
                    break;
                }
            }
        }

        private void PopVoiture_Tick(object sender, EventArgs e) //création des voitures descendante
        {
            Random randcolor = new Random();
            int color = randcolor.Next(4);
            switch (color)
            {
                case 0:
                    carColor = "bleu";
                    break;
                case 1:
                    carColor = "jaune";
                    break;
                case 2:
                    carColor = "noir";
                    break;
                default:
                    carColor = "verte";
                    break;
            }
            Voiture cardown = new Voiture();
            Image img_CarDown;
            img_CarDown = cardown.Init_Voiture(carColor);
            Grille.Children.Add(img_CarDown);
            ListVoiture.Add(cardown);

        }

        private void TimeRoute_Tick(object sender, EventArgs e)
        {

            foreach (Route myroute in MyRoute) // déplacement de la route 
            {
                myroute.road.Margin = new Thickness(10, myroute.road.Margin.Top + 10, 0, myroute.road.Margin.Bottom - 10);

                if (myroute.road.Margin.Bottom == 0)
                {
                    creation = true;
                }
            }
            if (creation || depart) // création nouvel objet route au dessus
            {
                parcours = parcours + 100;
                Route Road = new Route();
                Image img_Road;
                img_Road = Road.Init_Route(parcours);
                Grille.Children.Add(img_Road);
                MyRoute.Add(Road);
                creation = false;
                depart = false;
            }
            foreach (Route maroute in MyRoute) //destruction des objets route dans la liste MyRoute quand ils sortent du champ
            {
                if (maroute.road.Margin.Bottom < -910)
                {
                    maroute.road.Visibility = Visibility.Hidden;
                    MyRoute.Remove(maroute);
                    break;
                }
            }
        }

        private void VoitureGame_Loaded(object sender, RoutedEventArgs e)
        {
            var windows = Window.GetWindow(this);
            windows.KeyDown += VoitureGame_KeyDown;
        }

        private void VoitureGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Left)      // mouvement à gauche de la voiture
            {
                if (VoitureGame.Margin.Left > 90) // verif borne gauche
                {
                    VoitureGame.Margin = new Thickness(VoitureGame.Margin.Left - 10, VoitureGame.Margin.Top, VoitureGame.Margin.Right + 10, VoitureGame.Margin.Bottom);
                }

            }

            if (e.Key == Key.Right)     // mouvement droite voiture
            {
                //if (VoitureGame.Margin.Left < 420) // verif borne droite
                //{
                //    VoitureGame.Margin = new Thickness(VoitureGame.Margin.Left + 10, VoitureGame.Margin.Top, VoitureGame.Margin.Right-10, VoitureGame.Margin.Bottom);
                //}
                if (VoitureGame.Margin.Right > 80) // verif borne droite
                {
                    VoitureGame.Margin = new Thickness(VoitureGame.Margin.Left + 10, VoitureGame.Margin.Top, VoitureGame.Margin.Right - 10, VoitureGame.Margin.Bottom);
                }

            }
            if (e.Key == Key.Up)        // accélération défilement route
            {
                if (PopVoiture.Interval > TimeSpan.FromMilliseconds(1000))
                {
                    TimeSpan fast = TimeSpan.FromMilliseconds(500);
                    PopVoiture.Interval = PopVoiture.Interval.Add(-fast);
                }


            }

            if (e.Key == Key.Down)      // ralentissement défilement route
            {
                if (PopVoiture.Interval < TimeSpan.FromMilliseconds(6000))
                {
                    TimeSpan fast = TimeSpan.FromMilliseconds(500);
                    PopVoiture.Interval = PopVoiture.Interval.Add(fast);
                }

            }
        }

        public bool VerifCoordonne(List<Voiture> listMyCar) // gestion colision 
        {
            bool accident = false;
            foreach (Voiture CarDown in ListVoiture)
            {
                if (CarDown.Car.Margin.Bottom <= VoitureGame.Margin.Bottom + 189 && CarDown.Car.Margin.Bottom > 0)
                {
                    if (CarDown.Car.Margin.Left <= VoitureGame.Margin.Left + 82 && CarDown.Car.Margin.Left >= VoitureGame.Margin.Left || CarDown.Car.Margin.Right <= VoitureGame.Margin.Right + 82 && CarDown.Car.Margin.Right >= VoitureGame.Margin.Right)
                    {
                        accident = true;
                        break;
                    }
                }
            }
            return accident;

        }

        private void Game_Car1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!accident)
            {
                CarSpeed.Stop();
                TimeRoute.Stop();
                PopVoiture.Stop();
                demarrage.Show();
            }


        }

        private void End_Game()
        {
            CarSpeed.Stop();
            TimeRoute.Stop();
            PopVoiture.Stop();
            Grille.IsEnabled = false;
            FenetreScore fin = new FenetreScore(this,demarrage);
            fin.Show();
            
        }

    }
}
