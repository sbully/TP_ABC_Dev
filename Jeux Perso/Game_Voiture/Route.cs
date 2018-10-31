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
    class Route
    {
        static BitmapImage bitmapImage;
        public Image road = new Image();

        public static BitmapImage Init_affichage()
        {
            byte[] imageTmp = File.ReadAllBytes("..\\Game_image\\route.png");

            using (MemoryStream imgstream = new MemoryStream(imageTmp))
            {
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = imgstream;
                bitmapImage.EndInit();
            }
            //this.road.Source = bitmapImage;
            //road.Margin = new Thickness(0, 0, 0, 0);
            //road.Name = "Route";
            return bitmapImage;
        }

        public Image Init_Route(int _distance = 0)
        {

            int distance = _distance;
            byte[] imageTmp = File.ReadAllBytes("..\\Game_image\\route.png");

            using (MemoryStream imgstream = new MemoryStream(imageTmp))
            {
                bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = imgstream;
                bitmapImage.EndInit();
            }
            this.road.Source = bitmapImage;
            road.Margin = new Thickness(10, -738, 0, 750);
            road.Height = 750;
            road.Width = 572;
            road.Name = "Route";
            road.Stretch = Stretch.Fill;
            return road;
        }
    }
}
