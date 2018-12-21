using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo_Menu
{
    public partial class MainForm : Form
    {
        DateTime dateActu = DateTime.Now;
        Additionneur Addition;
        ChexboxForm checkBoxForm;
        CtrlSaisie controlesaisi;
        ListcomboForm listcombo;
        EmpruntForm emprunt;
        CompoCouleur colorcompo;
        static public bool identifie;
        static public string nomLog;

        public MainForm()
        {
            InitializeComponent();
            toolStripDate.Text = dateActu.ToString("d");
            toolStripID.Text = toolStripConnect.Text;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Fin de l’application ?", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Identification();
        }

        private void additionneurToolStripMenuItem_Click(object sender, EventArgs e) // affichage fenetre additionnneur
        {

            Addition = new Additionneur();
            Addition.MdiParent = this;
            Addition.Show();
        }

        private void contrôlesDeSaisieToolStripMenuItem_Click(object sender, EventArgs e) // affichage fenetre exo controle de saisie
        {
            controlesaisi = new CtrlSaisie();
            controlesaisi.MdiParent = this;
            controlesaisi.Show();
        }

        private void toolStripConnect_Click(object sender, EventArgs e)
        {
            //Identification();
            Log_Valide("User");
        }
        private void Identification()                       // affichage de la fenetre de loggin
        {
            Form2 log = new Form2(this);
            log.MdiParent = this;
            log.Show();
        }
        public void Log_Valide(string _nom)             // si loggin reussi activation des boutons de la mainform
        {
            toolStripID.Text = _nom;
            toolStripConnect.Text = _nom;
            Toolphase1.Enabled = true;
            Toolphase2.Enabled = true;
            Toolphase3.Enabled = true;
            Toolfenêtres.Enabled = true;
            toolStriphase3.Enabled = true;
        }

        private void casesToolStripMenuItem_Click(object sender, EventArgs e) // affichage fenetre exo checkbox
        {
            checkBoxForm = new ChexboxForm();
            checkBoxForm.MdiParent = this;
            checkBoxForm.Show();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e) // affichage fenetre exo combobox
        {
            listcombo = new ListcomboForm();
            listcombo.MdiParent = this;
            listcombo.Show();
        }

        private void synthèseToolStripMenuItem_Click(object sender, EventArgs e) // afficahge fenetre exo emprunt
        {
            emprunt = new EmpruntForm();
            emprunt.MdiParent = this;
            emprunt.Show();
        }

        private void défilementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorcompo = new CompoCouleur();
            colorcompo.MdiParent = this;
            colorcompo.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

       
    }
}
