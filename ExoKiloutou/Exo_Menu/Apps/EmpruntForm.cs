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
    public partial class EmpruntForm : Form
    {
        double tauxAnnu = 0.08;
        int nbrRemboursement;

        public EmpruntForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxPeriod.Items.Add("Mensuelle");
            listBoxPeriod.Items.Add("Bimestrielle");
            listBoxPeriod.Items.Add("Trimestrielle");
            listBoxPeriod.Items.Add("Semestrielle");
            listBoxPeriod.Items.Add("Annuelle");
            Reset_Form();
        }

        private void ScrollMois_ValueChanged(object sender, EventArgs e)
        {
            Reset_Change();
            Update_Affichage();
            labelRembours.Text = "1 €";
        }

        private string Remboursement_total(string _montant, double _taux, string _nbrRemb)
        {
            double sommeTotalDue;
            string somme;
            int montantEmprunt = int.Parse(_montant);
            int nbrRemb = int.Parse(_nbrRemb);
            double taux = _taux / nbrRemboursement;
            double Q = 1 - (Math.Pow(1 + taux, -nbrRemb));
            sommeTotalDue = montantEmprunt * taux / Q;
            somme = sommeTotalDue.ToString("#.00") + " €";
            return somme;
        }

        private int Periodicite()
        {
            int periode = 0;
            switch (listBoxPeriod.SelectedIndex)
            {
                case 0:
                    ScrollMois.SmallChange = 1;
                    ScrollMois.Minimum = 1;
                    nbrRemboursement = 12;
                    ScrollMois.Value = ScrollMois.SmallChange;
                    labelNbrRembours.Text = (ScrollMois.Value / ScrollMois.SmallChange).ToString();
                    labelNbrMois.Text = ScrollMois.SmallChange.ToString();
                    break;
                case 1:
                    ScrollMois.SmallChange = 2;
                    ScrollMois.LargeChange = ScrollMois.SmallChange * 2;
                    ScrollMois.Minimum = 2;
                    ScrollMois.Maximum = 240 + ScrollMois.LargeChange - 1;
                    ScrollMois.Value = ScrollMois.SmallChange;
                    labelNbrRembours.Text = (ScrollMois.Value / ScrollMois.SmallChange).ToString();
                    labelNbrMois.Text = ScrollMois.SmallChange.ToString();
                    nbrRemboursement = 6;
                    break;
                case 2:
                    ScrollMois.SmallChange = 3;
                    ScrollMois.LargeChange = ScrollMois.SmallChange * 2;
                    ScrollMois.Minimum = 3;
                    ScrollMois.Maximum = 240 + ScrollMois.LargeChange - 1;
                    ScrollMois.Value = ScrollMois.SmallChange;
                    labelNbrRembours.Text = (ScrollMois.Value / ScrollMois.SmallChange).ToString();
                    labelNbrMois.Text = ScrollMois.SmallChange.ToString();
                    nbrRemboursement = 4;
                    break;
                case 3:
                    ScrollMois.SmallChange = 6;
                    ScrollMois.LargeChange = ScrollMois.SmallChange * 2;
                    ScrollMois.Minimum = 6;
                    ScrollMois.Maximum = 240 + ScrollMois.LargeChange - 1;
                    ScrollMois.Value = ScrollMois.SmallChange;
                    labelNbrRembours.Text = (ScrollMois.Value / ScrollMois.SmallChange).ToString();
                    labelNbrMois.Text = ScrollMois.SmallChange.ToString();
                    nbrRemboursement = 2;
                    break;
                case 4:
                    ScrollMois.SmallChange = 12;
                    ScrollMois.LargeChange = ScrollMois.SmallChange * 2;
                    ScrollMois.Maximum = 240 + ScrollMois.LargeChange - 1;
                    ScrollMois.Minimum = 12;
                    ScrollMois.Value = ScrollMois.SmallChange;
                    labelNbrRembours.Text = (ScrollMois.Value / ScrollMois.SmallChange).ToString();
                    labelNbrMois.Text = ScrollMois.SmallChange.ToString();
                    nbrRemboursement = 1;
                    break;
                default:
                    break;
            }

            return periode;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            
            if (textBoxMontant.Text.Length > 1)
            {
                textBoxMontant.BackColor = Color.White;
                labelRembours.Text = Remboursement_total(textBoxMontant.Text, tauxAnnu, labelNbrRembours.Text);
            }
            else
            {
                MessageBox.Show("MONTANT NON SAISI", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                textBoxMontant.BackColor = Color.Red;
            }

        }

        private void Reset_Form()
        {
            labelNbrRembours.Text = "1";
            listBoxPeriod.SetSelected(0, true);
            Periodicite();
            labelNbrRembours.Text = "1";
            ScrollMois.Value = 1;
            labelNbrMois.Text = ScrollMois.Value.ToString();
            radioButTI7.Select();
            textBoxMontant.Text = null;
            labelRembours.Text = "1 €";
            textBoxMontant.BackColor = Color.White;
        }

        private double Change_Taux(object send)
        {
            RadioButton recupRadio = (RadioButton)send;
            double tauxSelect = double.Parse(recupRadio.Text.Substring(0, 1)) / 100;

            return tauxSelect;
        }

        private void radioButTI7_CheckedChanged(object sender, EventArgs e)
        {
            Reset_Change();
            tauxAnnu = Change_Taux(sender);
        }

        private void radioButTI8_CheckedChanged(object sender, EventArgs e)
        {
            Reset_Change();
            tauxAnnu = Change_Taux(sender);
        }

        private void radioButTI9_CheckedChanged(object sender, EventArgs e)
        {
            Reset_Change();
            tauxAnnu = Change_Taux(sender);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Reset_Form();

        }

        private void listBoxPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset_Change();
            Periodicite();
        }

        private void Update_Affichage()
        {
            labelNbrMois.Text = ScrollMois.Value.ToString();
            labelNbrRembours.Text = (ScrollMois.Value / ScrollMois.SmallChange).ToString();
        }

        private void Reset_Change()
        {
            labelRembours.Text = "1 €";
        }

        private void Test_Saisi()
        {
            char[] saisie = textBoxMontant.Text.ToCharArray();
            bool testchar;
            bool nomValider = true;
            if (textBoxMontant.Text.Length == 0)
            {
                nomValider = false;
            }
            else
            {
                foreach (char item in saisie)
                {
                    //testint = char.IsDigit(item);
                    testchar = char.IsLetter(item);
                    if (testchar)
                    {
                        nomValider = false;
                    }
                }
            }

            if (!nomValider)
            {
                textBoxMontant.BackColor = Color.Red;
            }
            else
            {
                textBoxMontant.BackColor = Color.White;
            }
            
        }

        private void textBoxMontant_TextChanged(object sender, EventArgs e)
        {
            Reset_Change();
            Test_Saisi();
        }
    }


}
