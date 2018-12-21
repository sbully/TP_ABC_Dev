using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MasterMind
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FenetreDemarrage_Loaded(object sender, RoutedEventArgs e)
        {
            ImageFond.Source = Init_Background();
            ImageFond.Stretch = Stretch.Fill;
            LabelName.Foreground = Brushes.PaleVioletRed;
            LabelName.HorizontalContentAlignment = HorizontalAlignment.Center;
            TextBox_Name.Foreground = Brushes.PaleVioletRed ;
        }

        static BitmapImage Init_Background()
        {
            BitmapImage Background_Bitmap;
            byte[] imgtmp = File.ReadAllBytes("..\\..\\Images\\MastermindOpening.png");
            using (MemoryStream imgstream = new MemoryStream(imgtmp))
            {
                Background_Bitmap = new BitmapImage();
                Background_Bitmap.BeginInit();
                Background_Bitmap.CacheOption = BitmapCacheOption.OnLoad;
                Background_Bitmap.StreamSource = imgstream;
                Background_Bitmap.EndInit();
            }
                return Background_Bitmap;
        }

        private void Button_MasterMind_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
