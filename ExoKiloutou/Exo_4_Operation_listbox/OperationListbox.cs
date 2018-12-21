using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo_4_Operation_listbox
{
    public partial class OperationListbox : Form
    {
        public OperationListbox()
        {
            InitializeComponent();
        }

        private void buttonAddList_Click(object sender, EventArgs e)
        {
            AjoutListe();
        }

        private void listboxElem_MouseClick(object sender, MouseEventArgs e)
        {
            affichage();
        }

        private void buttonViderList_Click(object sender, EventArgs e)
        {
            listboxElem.Items.Clear();
            affichage_Nul();
        }

        private void buttonSelectList_Click(object sender, EventArgs e)
        {
            int index;
            if (textBoxIndex.Text != null)
            {
                try
                {
                    index = int.Parse(textBoxIndex.Text);
                    listboxElem.SelectedIndex = index;
                    textBoxIndex.Text = null;
                    affichage();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur de Saisie dans Index Elément\n" + e.ToString());
                    textBoxIndex.Text = null;
                }
            }

        }
        private void affichage()
        {
            textBoxIndexRO.Text = listboxElem.SelectedIndex.ToString();
            textBoxItemCountRO.Text = listboxElem.Items.Count.ToString();
            textBoxNomRO.Text = listboxElem.Text;
        }
        private void affichage_Nul()
        {
            textBoxIndexRO.Text = null;
            textBoxItemCountRO.Text = null;
            textBoxNomRO.Text = null;
        }
        private void AjoutListe()
        {
            int valAjout;
            valAjout = listboxElem.FindStringExact(NomTextBox.Text);
            if (valAjout == -1)
            {
                listboxElem.Items.Add(NomTextBox.Text);
                NomTextBox.Clear();
                NomTextBox.Focus();
            }
            else
            {
                NomTextBox.Text = null;
                MessageBox.Show("Elément déjà présent dans la liste");
            }
        }
    }
}
