using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exo_2_CtrlSaisie
{
    public partial class CtrlSaisie : Form
    {

        static bool datevalider = false;
        static bool codePostalvalider = false;
        static bool nomValider = false;
        static bool montantValider = false;

        public CtrlSaisie()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonValider.Enabled = false;
        }



        private void ButtonValider_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Nom : " + textBoxNom.Text + "\nDate : " + textBoxDate.Text + "\nMontant : " + textBoxMontant.Text + "\nCode : " + textBoxPostal.Text + "                    ", "Validation effectuée");
            DialogResult dr = MessageBox.Show("Fin de l’application ?", "FIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Effacer();
            }
        }

        private void buttonEffacer_Click(object sender, EventArgs e)
        {
            Effacer();

        }

        private void textBoxPostal_Validating(object sender, CancelEventArgs e)
        {
            bool testcode;
            int postal;
            testcode = int.TryParse(textBoxPostal.Text, out postal);
            if (!testcode)
            {
                textBoxPostal.BackColor = Color.Red;
            }
            else
            {
                textBoxPostal.BackColor = Color.White;
                codePostalvalider = true;
            }
            VerifValidite();
        }

        //private void textBoxMontant_Validating(object sender, CancelEventArgs e)
        //{
        //    bool testmontant;
        //    double montant;
        //    testmontant = double.TryParse(textBoxMontant.Text, out montant);
        //    if (!testmontant)
        //    {
        //        textBoxMontant.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //        textBoxMontant.BackColor = Color.White;
        //        montantValider = true;
        //    }
        //    VerifValidite();
        //}

        //private void textBoxDate_Validating(object sender, CancelEventArgs e)
        //{
        //    bool dateValide;

        //    DateTime Date = new DateTime();
        //    dateValide = DateTime.TryParse(textBoxDate.Text, out Date);
        //    if (!dateValide)
        //    {
        //        textBoxDate.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //        textBoxDate.BackColor = Color.White;
        //        datevalider = true;
        //    }
        //    VerifValidite();
        //}

 

        public void VerifValidite()
        {
            if (datevalider && codePostalvalider && nomValider && montantValider)
            {
                ButtonValider.Enabled = true;

            }
        }

        public void Effacer()
        {
            textBoxNom.Clear();
            textBoxDate.Clear();
            textBoxMontant.Clear();
            textBoxPostal.Clear();
            datevalider = false;
            codePostalvalider = false;
            nomValider = false;
            montantValider = false;
            ButtonValider.Enabled = false;
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            char[] saisie = textBoxNom.Text.ToCharArray();
            bool testint;
            bool testchar;
            nomValider = true;
            if (textBoxNom.Text.Length == 0)
            {
                nomValider = false;
            }
            else
            {
                foreach (char item in saisie)
                {
                    testint = char.IsDigit(item);
                    testchar = char.IsLetter(item);
                    if (testint || !testchar)
                    {
                        nomValider = false;
                    }
                }
            }

            if (!nomValider)
            {
                textBoxNom.BackColor = Color.Red;
            }
            else
            {
                textBoxNom.BackColor = Color.White;
            }
            VerifValidite();

        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            bool dateValide;

            DateTime Date = new DateTime();
            dateValide = DateTime.TryParse(textBoxDate.Text, out Date);
            if (!dateValide)
            {
                textBoxDate.BackColor = Color.Red;
            }
            else
            {
                textBoxDate.BackColor = Color.White;
                datevalider = true;
            }
            VerifValidite();

        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            bool testmontant;
            double montant;
            testmontant = double.TryParse(textBoxMontant.Text, out montant);
            if (!testmontant)
            {
                textBoxMontant.BackColor = Color.Red;
            }
            else
            {
                textBoxMontant.BackColor = Color.White;
                montantValider = true;
            }
            VerifValidite();

        }

        private void textBoxPostal_TextChanged(object sender, EventArgs e)
        {
            bool testcode;
            int postal;
            testcode = int.TryParse(textBoxPostal.Text, out postal);
            if (!testcode || textBoxPostal.Text.Length<5)
            {
                textBoxPostal.BackColor = Color.Red;
            }
            else
            {
                textBoxPostal.BackColor = Color.White;
                codePostalvalider = true;
            }
            VerifValidite();
        }
    }

}
