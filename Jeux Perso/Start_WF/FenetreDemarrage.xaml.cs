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

namespace Start_WF
{
    /// <summary>
    /// Logique d'interaction pour FenetreDemarrage.xaml
    /// </summary>
    public partial class FenetreDemarrage : Window
    {
        public FenetreDemarrage()
        {
            
            InitializeComponent();
        }

        private void Quitter_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void EasyButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Difficulty = 15;
            MainWindow.demarrage = this;
            MainWindow.valeurscore = 50;
            MainWindow.init_timer_tick = 50;
            MainWindow.name = NameBox.Text;
            var window = new MainWindow();
            window.Show();
            this.Hide();

        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Difficulty = 30;
            MainWindow.demarrage = this;
            MainWindow.valeurscore = 100;
            var window = new MainWindow();
            MainWindow.init_timer_tick = 40;
            MainWindow.name = NameBox.Text ;
            window.Show();
            this.Hide();
        }

        private void HardButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Difficulty = 40;
            MainWindow.demarrage = this;
            MainWindow.valeurscore = 150;
            MainWindow.init_timer_tick =30;
            MainWindow.name = NameBox.Text;
            var window = new MainWindow();
            window.Show();
            this.Hide();
        }
    }
}
