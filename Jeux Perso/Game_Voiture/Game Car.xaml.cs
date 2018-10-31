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
        static List<Voiture> ListVoiture = new List<Voiture>();
        static List<Route> MyRoute = new List<Route>();

        public MainWindow demarrage = new MainWindow();

        DispatcherTimer TimeRoute = new DispatcherTimer();
        DispatcherTimer PopVoiture = new DispatcherTimer();
        DispatcherTimer CarSpeed = new DispatcherTimer();
        //Image img_CarDown;
        bool creation = false;
        bool depart = true;
        int parcours = 0;
        string carColor;

        public Game_Car()
        {
            InitializeComponent();
            Route RoadStart = new Route();
            Image img_roadstart = RoadStart.Init_Route();
            RoadStart.road.Margin = new Thickness(10, -8, 0, 0);
            Grille.Children.Add(img_roadstart);
            MyRoute.Add(RoadStart);
            //RouteImage.Source = Route.Init_affichage();
            //RouteImage.Stretch = Stretch.Fill;

            //TimeRoute = new DispatcherTimer();
            TimeRoute.Interval = TimeSpan.FromMilliseconds(50);
            TimeRoute.Tick += TimeRoute_Tick;

            PopVoiture.Interval = TimeSpan.FromMilliseconds(1000);
            PopVoiture.Tick += PopVoiture_Tick;

            CarSpeed.Interval = TimeSpan.FromMilliseconds(10);
            CarSpeed.Tick += CarSpeed_Tick;

            TimeRoute.Start();
            CarSpeed.Start();
            PopVoiture.Start();
        }

        private void CarSpeed_Tick(object sender, EventArgs e) // défilement des voitures
        {
            foreach (Voiture carPosition in ListVoiture)
            {
                carPosition.Car.Margin = new Thickness(carPosition.Car.Margin.Left, carPosition.Car.Margin.Top + 10, carPosition.Car.Margin.Right, carPosition.Car.Margin.Bottom - 10);

            }
            foreach (Voiture Carpos in ListVoiture) //destruction des voitures hors champ
            {
                if (Carpos.Car.Margin.Top > 800)
                {
                    //ListVoiture.Remove(Carpos);
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
                myroute.road.Margin = new Thickness(10, myroute.road.Margin.Top + 10, 0, myroute.road.Margin.Bottom-10);

                if (myroute.road.Margin.Bottom == 0)
                {
                    creation = true;
                }
            }
            if (creation||depart) // création nouvel objet route au dessus
            {
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
                if (maroute.road.Margin.Bottom<-910)
                {
                    maroute.road.Visibility = Visibility.Hidden;
                    MyRoute.Remove(maroute);
                    break;
                }
            }


        }

        private void Game_Car1_Closed(object sender, EventArgs e) // fermeture de la fenetre, arret des timers, afficher page de démarrage
        {
            TimeRoute.Stop();
            CarSpeed.Stop();
            PopVoiture.Stop();
            demarrage.Show();
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
                    VoitureGame.Margin = new Thickness(VoitureGame.Margin.Left - 10, VoitureGame.Margin.Top, VoitureGame.Margin.Right, VoitureGame.Margin.Bottom);
                }

            }

            if (e.Key == Key.Right)     // mouvement droite voiture
            {
                if (VoitureGame.Margin.Left < 420) // verif borne droite
                {
                    VoitureGame.Margin = new Thickness(VoitureGame.Margin.Left + 10, VoitureGame.Margin.Top, VoitureGame.Margin.Right, VoitureGame.Margin.Bottom);
                }

            }
            if (e.Key == Key.Up)        // accélération défilement route
            {
                TimeSpan fast = TimeSpan.FromMilliseconds(1);
                TimeRoute.Interval = TimeRoute.Interval.Add(-fast);

            }

            if (e.Key == Key.Down)      // ralentissement défilement route
            {
                TimeSpan fast = TimeSpan.FromMilliseconds(1);
                TimeRoute.Interval = TimeRoute.Interval.Add(fast);
            }
        }
    }
}
