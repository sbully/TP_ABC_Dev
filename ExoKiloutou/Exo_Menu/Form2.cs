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
    public partial class Form2 : Form
    {
        MainForm mainform;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLoogin.Text == textBoxPasseword.Text && textBoxLoogin.TextLength > 0)
            {
                MainForm.nomLog = textBoxLoogin.Text;
                
                //mainform.toolStripID.Text = textBoxLoogin.Text;
                //mainform.toolStripConnect.Text = textBoxLoogin.Text;
                DialogResult dr = MessageBox.Show("Vous êtes connecté.\nBonjour "+ textBoxLoogin.Text, "connection", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                mainform.Log_Valide(textBoxLoogin.Text);
                this.Close();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Erreur d'identifiant", "connection", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }

        }

        public Form2(MainForm _main) : this()
        {
            mainform = _main;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
