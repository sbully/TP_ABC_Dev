using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using Dll_Bully;

namespace TestInterfaceFraiche
{
    public partial class NewCompte : UserControl
    {
        List<Ville> listVilleFrançaise;
        bool nomvalider = false;
        bool prenomValider = false;
        bool rueValide = false;
        bool codePostalValide = false;
        bool dateValide = false;
        bool mailValide = false;
        bool villeValide = false;
        bool mDPValide = false;
        private string nom;
        private string prenom;
        private string motdepasse;
        private DateTime dateNaissance;
        private string dateNais;
        private string rue;
        private string ville;
        private int codepostal;
        private string mail;
        private string sexe;
        string numVoie;

        Accueil homeWindows;

        public NewCompte()
        {
            InitializeComponent();
            butInscription.Enabled = false;
        }

        public NewCompte(Accueil monAccueil) : this()
        {
            homeWindows = monAccueil;
            string path = "..\\Save\\lapostel_mod.csv";
            listVilleFrançaise = Sauvegarde.Read_CSV<Ville>(path);
        }

        public void VerifValide()
        {
            if (nomvalider && prenomValider && mailValide && mDPValide && rueValide && codePostalValide && dateValide && villeValide)
            {
                butInscription.Enabled = true;
            }
            else
            {
                butInscription.Enabled = false;
            }
        }

        public bool CtrCodePostal()
        {
            return int.TryParse(textBoxCodePostal.Text, out int _codepostal);
        }

        public bool CtrNom(object sender)
        {
            TextBox TextVerif = (TextBox)sender;
            char[] saisie = TextVerif.Text.ToCharArray();
            bool testint;
            bool testchar;
            bool _verif = true;
            if (TextVerif.Text.Length <= 1)
            {
                _verif = false;
            }
            else
            {
                foreach (char item in saisie)
                {
                    testint = char.IsDigit(item);
                    testchar = char.IsLetter(item);
                    if (testint || !testchar)
                    {
                        _verif = false;
                    }
                }
            }

            if (!_verif)
            {
                TextVerif.BackColor = Color.Red;
            }
            else
            {
                TextVerif.BackColor = Color.White;
            }
            return _verif;
        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            nomvalider = CtrNom(sender);
            nom = textBoxNom.Text;
            VerifValide();

        }

        private void textBoxPrenom_TextChanged(object sender, EventArgs e)
        {
            prenomValider = CtrNom(sender);
            prenom = textBoxPrenom.Text;
            VerifValide();

        }

        private void textMDP_TextChanged(object sender, EventArgs e)
        {
            if (textMDP.Text.Length < 8)
            {
                textMDP.BackColor = Color.Red;
            }
            else
            {
                textMDP.BackColor = Color.White;
                mDPValide = true;
            }
            motdepasse = textMDP.Text;
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            textBoxNom.Text = null;
            textBoxPrenom.Text = null;
            textBoxMail.Text = null;
            textMDP.Text = null;
            textBoxDateNaissance.Text = null;
            textBoxRue.Text = null;
            textBoxNumRue.Text = null;
            comboVille.Text = null;
            textBoxCodePostal.Text = null;
            homeWindows.butclient_Click(sender, e);


        }

        private void textBoxRue_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRue.Text.Length > 5)
            {
                rueValide = true;
            }
            else
            {
                rueValide = false;
            }
            rue = textBoxRue.Text;
            VerifValide();

        }

        private void textBoxCodePostal_TextChanged(object sender, EventArgs e)
        {

            if (textBoxCodePostal.Text.Length == 5 && int.TryParse(textBoxCodePostal.Text, out int codePostal))
            {
                codePostalValide = true;
            }
            else
            {
                codePostalValide = false;
            }
            if (codePostalValide)
            {
                listVilleFrançaise = listVilleFrançaise.FindAll(x => x.CodePostal == textBoxCodePostal.Text).ToList();
                comboVille.DataSource = listVilleFrançaise;
                comboVille.Text = null;
            }
            if (codePostalValide)
            {
                codepostal = int.Parse(textBoxCodePostal.Text);
                VerifValide();
            }

        }

        private void textBoxDateNaissance_TextChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(textBoxDateNaissance.Text, out dateNaissance) && textBoxDateNaissance.Text.Length == 10)
            {
                dateValide = true;
                textBoxDateNaissance.BackColor = Color.White;
            }
            else
            {
                dateValide = false;
                textBoxDateNaissance.BackColor = Color.Red;
            }
            dateNais = dateNaissance.ToString("d");
            VerifValide();
        }

        private void comboVille_SelectionChangeCommitted(object sender, EventArgs e)
        {
            villeValide = true;
            ville = comboVille.Text;
            VerifValide();
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            MailValide testmail = new MailValide();
            mailValide = testmail.IsValidEmail(textBoxMail.Text);
            if (mailValide)
            {
                textBoxMail.BackColor = Color.White;
                mail = textBoxMail.Text;
            }
            else
            {
                textBoxMail.BackColor = Color.Red;
            }
        }
        private void ChoixSexe()
        {
            if (radioButMale.Checked == true)
            {
                sexe = "Monsieur";
            }
            else
            {
                sexe = "Madame";
            }
        }

        private void butInscription_Click(object sender, EventArgs e)
        {
            string _path = "..\\Save\\Listclient.csv";
            ChoixSexe();
            numVoie = textBoxNumRue.Text;
            ClientMacDo newclient = new ClientMacDo(sexe, nom, prenom, numVoie, rue, codepostal, ville, mail, dateNais, motdepasse);
            Sauvegarde.Write_CSV<ClientMacDo>(_path,newclient);

        }
    }
}
