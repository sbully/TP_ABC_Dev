using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Dll_Bully;

namespace TestInterfaceFraiche
{
    public partial class Accueil : Form
    {
        Home homeFenetre = new Home();
        Menu menufenetre = new Menu();
        Livraison livraisonFenetre = new Livraison();
        AEmporter emporterFenetre = new AEmporter();
        Client clientFenetre;
        Connection connect;
        Paiement paieFenetre = new Paiement();
        NewCompte newUser = new NewCompte();
        Point ancre = new Point(183, 172);
        Process openURL = new Process();
        string _path = "..\\Save\\Listclient.csv";
        private bool loggin = false;
        private ClientMacDo monclient;

        public bool Loggin
        {
            get
            {
                return loggin;
            }

            set
            {
                loggin = value;
            }
        }

        public ClientMacDo Monclient
        {
            get
            {
                return monclient;
            }

            set
            {
                monclient = value;
            }
        }

        public Accueil()
        {
            InitializeComponent();
            clientFenetre = new Client(this);

        }
        /// <summary>
        /// Fermeture de la fenetre
        /// </summary>
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Affichage du controle utilisateur "Menu"
        /// </summary>
        private void butMenu_Click(object sender, EventArgs e)
        {
            newUser.Visible = false;
            menufenetre.Visible = true;
            homeFenetre.Visible = false;
            livraisonFenetre.Visible = false;
            emporterFenetre.Visible = false;
            paieFenetre.Visible = false;
            clientFenetre.Visible = false;
            menufenetre.Location = ancre;
            pictLeftRed.Location = new Point(0, 142);
           

        }
        /// <summary>
        /// Affichage du controle utilisateur "Home"
        /// </summary>
        public void butHome_Click(object sender, EventArgs e)
        {
            newUser.Visible = false;
            homeFenetre.Visible = true;
            menufenetre.Visible = false;
            livraisonFenetre.Visible = false;
            emporterFenetre.Visible = false;
            paieFenetre.Visible = false;
            clientFenetre.Visible = false;
            pictLeftRed.Location = new Point(0, 70);
        }
        /// <summary>
        /// chargement de l'application initialisation de la fenetre et affichage controle utilisateur "Home"
        /// </summary>
        private void Accueil_Load(object sender, EventArgs e)
        {
            this.Controls.Add(homeFenetre);
            this.Controls.Add(menufenetre);
            this.Controls.Add(livraisonFenetre);
            this.Controls.Add(emporterFenetre);
            this.Controls.Add(paieFenetre);
            this.Controls.Add(clientFenetre);
            newUser.Visible = false;
            homeFenetre.Visible = true;
            menufenetre.Visible = false;
            livraisonFenetre.Visible = false;
            emporterFenetre.Visible = false;
            paieFenetre.Visible = false;
            clientFenetre.Visible = false;
            homeFenetre.Location = ancre;


        }
        /// <summary>
        /// Affichage du controle utilisateur "Livraison"
        /// </summary>
        private void butLivraison_Click(object sender, EventArgs e)
        {
            newUser.Visible = false;
            pictLeftRed.Location = new Point(0, 214);
            livraisonFenetre.Visible = true;
            homeFenetre.Visible = false;
            menufenetre.Visible = false;
            emporterFenetre.Visible = false;
            paieFenetre.Visible = false;
            clientFenetre.Visible = false;
            livraisonFenetre.Location = ancre;
        }
        /// <summary>
        /// Affichage du controle utilisateur "AEmporter"
        /// </summary>
        private void butAEmporter_Click(object sender, EventArgs e)
        {
            pictLeftRed.Location = new Point(0, 286);
            newUser.Visible = false;
            emporterFenetre.Visible = true;
            homeFenetre.Visible = false;
            menufenetre.Visible = false;
            livraisonFenetre.Visible = false;
            paieFenetre.Visible = false;
            clientFenetre.Visible = false;
            emporterFenetre.Location = ancre;
        }
        /// <summary>
        /// Affichage du controle utilisateur "Paiement"
        /// </summary>
        private void butPaiement_Click(object sender, EventArgs e)
        {
            pictLeftRed.Location = new Point(0, 358);
            newUser.Visible = false;
            paieFenetre.Visible = true;
            homeFenetre.Visible = false;
            menufenetre.Visible = false;
            livraisonFenetre.Visible = false;
            emporterFenetre.Visible = false;
            clientFenetre.Visible = false;
            paieFenetre.Location = ancre;
        }
        /// <summary>
        /// Affichage du controle utilisateur "Client"
        /// </summary>
        public void butclient_Click(object sender, EventArgs e)
        {
            pictLeftRed.Location = new Point(0, 430);
            newUser.Visible = false;
            clientFenetre.Visible = true;
            homeFenetre.Visible = false;
            menufenetre.Visible = false;
            livraisonFenetre.Visible = false;
            emporterFenetre.Visible = false;
            paieFenetre.Visible = false;
            clientFenetre.Location = ancre;
        }
        /// <summary>
        /// Ouverture de la page facebook Mac Donalds France
        /// </summary>
        private void picfacebook_Click(object sender, EventArgs e)
        {
            openURL.StartInfo.FileName = "https://fr-fr.facebook.com/mcdonaldsfrance";
            openURL.Start();
        }
        /// <summary>
        /// ouverture de la page Twitter de Mac Donalds France
        /// </summary>
        private void pictTwitter_Click(object sender, EventArgs e)
        {
            openURL.StartInfo.FileName = "https://twitter.com/mcdonaidsfr";
            openURL.Start();
        }
        /// <summary>
        /// ouverture de la page Instagram de Mac Donalds France
        /// </summary>
        private void pictInstagram_Click(object sender, EventArgs e)
        {
            openURL.StartInfo.FileName = "https://www.instagram.com/mcdonalds_fr/?hl=fr";
            openURL.Start();
        }
        /// <summary>
        /// ouverture de la page officiel de Mac Donalds France
        /// </summary>
        private void pictMcDo_Click(object sender, EventArgs e)
        {
            openURL.StartInfo.FileName = "https://www.mcdonalds.fr/";
            openURL.Start();
        }
        /// <summary>
        /// Affichage fenetre d inscription
        /// </summary>
        public void Fenetre_Inscription()
        {
            newUser = new NewCompte(this);
            this.Controls.Add(newUser);
            clientFenetre.Visible = false;
            homeFenetre.Visible = false;
            menufenetre.Visible = false;
            livraisonFenetre.Visible = false;
            emporterFenetre.Visible = false;
            paieFenetre.Visible = false;
            newUser.Visible = true;
            if (connect != null)
            {
                connect.Visible = false;
            }

            newUser.Location = ancre;

        }
        /// <summary>
        /// Affichage fenetre connection
        /// </summary>
        public void Fenetre_Connection()
        {
            connect = new Connection(this);
            this.Controls.Add(connect);
            clientFenetre.Visible = false;
            homeFenetre.Visible = false;
            menufenetre.Visible = false;
            livraisonFenetre.Visible = false;
            emporterFenetre.Visible = false;
            paieFenetre.Visible = false;
            newUser.Visible = false;
            connect.Visible = true;
            connect.Location = ancre;
            ClientMacDo.listClient = Sauvegarde.Read_CSV<ClientMacDo>(_path);

        }
        /// <summary>
        /// clic sur la croix pour fermer l'application
        /// </summary>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// click sur l'image pour minimize la fenetre
        /// </summary>
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            Fenetre_Connection();
        }
        public void logginValide(bool _log, ClientMacDo _clientMDO)
        {
            loggin = _log;
            monclient = _clientMDO;
            buttonConnection.Visible = false;
            labelClient.Text = monclient.Nom;
            labelClient.Visible = true;
            labelClient.Enabled = true;
        }
    }
}
