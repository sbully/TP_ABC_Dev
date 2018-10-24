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
    public class Canon
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
}
