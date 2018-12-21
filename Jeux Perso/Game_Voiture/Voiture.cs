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
    public class Voiture
    {
        public Image Car = new Image();
        static BitmapImage bitmapImage;        

        public static BitmapImage Init_couleur(string _couleur , Rotation _rotation = Rotation.Rotate0)
        {
            string couleur = _couleur;

            byte[] imageTmp = File.ReadAllBytes("..\\Game_image\\voiture_Joueur_" + couleur + ".png");

            using (MemoryStream imgstream = new MemoryStream(imageTmp))
            {
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = imgstream;
                bitmapImage.Rotation = _rotation;
                bitmapImage.EndInit();
            }

            return bitmapImage;
        }

        public Image Init_Voiture(string _color)
        {
            Random position = new Random();
            int left;
            string colori = _color;
            byte[] imageTmp = File.ReadAllBytes("..\\Game_image\\voiture_" + colori + ".png");

            using (MemoryStream imgstream = new MemoryStream(imageTmp))
            {
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = imgstream;
                bitmapImage.EndInit();
            }
            this.Car.Source = bitmapImage;
            left = position.Next(40,400);
            Car.Margin = new Thickness(left, -189, (590 - left - 82), 761);
            Car.Height = 189;
            Car.Width = 82;
            Car.Stretch = Stretch.Fill;
            
            Car.Name = "Car_down";

            return Car;
        }
    }
}
