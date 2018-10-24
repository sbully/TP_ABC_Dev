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
    public class Invader        // classe Invader
    {

        public Image invader = new Image();

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
}
