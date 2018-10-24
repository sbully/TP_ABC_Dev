using System;
using System.Collections.Generic;
using System.Collections;
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
    /// Logique d'interaction pour TableauScore.xaml
    /// </summary>
    public partial class TableauScore : Window
    {
        public TableauScore()
        {
            
            InitializeComponent();
            TableauScore1.FontSize = 16;
            List<JoueurScore> resultat = MainWindow.ListScore.OrderBy(x=>x.Score).Reverse().ToList();
            TableauScore1.ItemsSource = resultat;



        }

        private void BoutonExitScore_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RAZ_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.ListScore = new List<JoueurScore>();
            TableauScore1.ItemsSource = null;
            TableauScore1.ItemsSource = MainWindow.ListScore;

            

        }
    }
}
