using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestInterfaceFraiche
{
    public partial class Client : UserControl
    {
        
        Accueil pageaccueil;

        public Client()
        {
            InitializeComponent();
        }

        public Client(Accueil _pageaccueil) : this()
        {
            pageaccueil = _pageaccueil;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pageaccueil.Fenetre_Inscription();
        }

        private void buttConnect_Click(object sender, EventArgs e)
        {
            pageaccueil.Fenetre_Connection();
        }
    }
}
