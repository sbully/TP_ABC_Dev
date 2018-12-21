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
    public partial class Connection : UserControl
    {
        Accueil mainPage;

        public Connection()
        {
            InitializeComponent();
        }
        public Connection(Accueil _mainPage) : this()
        {
            mainPage = _mainPage;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (VerifClient(out ClientMacDo client))
            {
                MessageBox.Show("Connection établie");
                mainPage.logginValide(true,client);
                mainPage.butHome_Click(sender,e);
            }
            else
            {
                MessageBox.Show("Connection impossible");
            }
        }

        private bool VerifClient(out ClientMacDo client)
        {
            foreach (ClientMacDo monclient in ClientMacDo.listClient)
            {
                if (monclient.Mail == textBoxMail.Text && monclient.Motdepasse == textBoxMDP.Text)
                {
                    client = monclient;
                    return true;
                }
            }
            client = null;
            return false;
        }
    }
}
