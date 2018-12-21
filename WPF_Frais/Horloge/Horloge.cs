using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Horloge
{
    public partial class Horloge : Form
    {
        int mov;
        int movX;
        int movY;

        public bool progMinuteur = false;
        public bool progShutdown = false;
        public bool progWakeUp = false;
        DateTime dateWakeUp;
        DateTime dateshutdown;
        DateTime dateminuteur;
        DateTime datenow;


        bool accreMinute = false;
        Point ancre = new Point(160, 30);
        Transition transi;
        Minuteur userMinuteur;
        ArretPC userArretPC;
        Reveil userReveil;



        public Horloge()
        {
            InitializeComponent();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timerHorloge_Tick(object sender, EventArgs e)
        {
            datenow = DateTime.Now;
            circularHorloge.Text = datenow.Hour.ToString("D2") + ":" + datenow.Minute.ToString("D2");
            circularHorloge.SubscriptText = datenow.Second.ToString("D2");
            Affichage(datenow.Second);
            Reveil_Verif();
            PcShut_Verif();
            Minueur_Verif();
        }

        private void Affichage(int _seconde)
        {
            if (!accreMinute)
            {
                if (_seconde == 0)
                {
                    circularHorloge.Value = 60;
                    accreMinute = true;
                }
                else
                {
                    circularHorloge.ProgressColor = Color.Blue;
                    circularHorloge.Value = _seconde;
                }
            }
            else
            {
                circularHorloge.ProgressColor = Color.Black;
                circularHorloge.Value = 0;
                accreMinute = false;
            }
        }

        private void butMinuteur_Click(object sender, EventArgs e)
        {
            transi.TransiShow(userMinuteur);
        }

        private void Horloge_Load(object sender, EventArgs e)
        {
            transi = new Transition();
            userMinuteur = new Minuteur(this);
            userReveil = new Reveil();
            userArretPC = new ArretPC();

            Controls.Add(userMinuteur);
            Controls.Add(userReveil);
            Controls.Add(userArretPC);
            userMinuteur.Location = ancre;
            userReveil.Location = ancre;
            userArretPC.Location = ancre;
            userMinuteur.Visible = false;
            userReveil.Visible = false;
            userArretPC.Visible = false;
            timerHorloge.Enabled = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void butReveil_Click(object sender, EventArgs e)
        {

            transi.TransiShow(userReveil);
        }

        private void butHorloge_Click(object sender, EventArgs e)
        {
            userMinuteur.Visible = false;
            userReveil.Visible = false;
            userArretPC.Visible = false;
        }

        private void butArretPc_Click(object sender, EventArgs e)
        {
            transi.TransiShow(userArretPC);
        }

        private void Reveil_Verif()
        {
            if (progWakeUp)
            {
                if (DateTime.Now.Day == dateWakeUp.Day && DateTime.Now.Hour == dateWakeUp.Hour && DateTime.Now.Minute == dateWakeUp.Minute)
                {
                    progWakeUp = false;
                    pictReveil.Visible = false;
                    MessageBox.Show("Wake UP!!!!!!!!!");
                }
            }
        }
        private void PcShut_Verif()
        {
            if (progShutdown)
            {
                if (DateTime.Now.Day == dateWakeUp.Day && DateTime.Now.Hour == dateWakeUp.Hour && DateTime.Now.Minute == dateWakeUp.Minute)
                {
                    Process.Start("Shutdown", "/s /t 0");
                }
            }
        }
        private void Minueur_Verif()
        {
            if (progMinuteur)
            {
                if (DateTime.Now.Hour == dateminuteur.Hour && DateTime.Now.Minute == dateminuteur.Minute)
                {
                    progMinuteur = false;
                    pictMinuteur.Visible = false;
                    MessageBox.Show("FIN DU MINUTEUR");
                }
            }
        }

        public void Set_Reveil(DateTime _wakeup)
        {
            dateWakeUp = _wakeup;
            progWakeUp = true;
            pictReveil.Visible = true;
        }
        public void Set_PcShut(DateTime _dateshutdown)
        {
            dateshutdown = _dateshutdown;
            progShutdown = true;
            picShutPC.Visible = true;
        }
        public void Set_Minuteur(DateTime _dateminuteur)
        {
            dateminuteur = _dateminuteur;
            pictMinuteur.Visible = true;
            progMinuteur = true;
        }
        public void Reset_Reveil()
        {
            progWakeUp = false;
            dateWakeUp = new DateTime();
        }
        public void Reset_PcShut()
        {
            progShutdown = false;
            dateshutdown = new DateTime();
        }
        public void Reset_Minuteur()
        {
            progMinuteur = false;
            dateminuteur = new DateTime();
        }



    }
}
