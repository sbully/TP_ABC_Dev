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

namespace Minuteur
{
    public partial class Form1 : Form
    {

        DateTime calendar;
        DateTime datalarm;
        Timer timerminuteur = new Timer();
        bool alarmActiv = false;
        bool minActiv = false;
        string textAlarm;
        int minuteur;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calendar = dateTimeCalendar.Value;
            HeureUpDown.Value = calendar.Hour;
            MinuteUpDown.Value = calendar.Minute;
            timerRefresh.Interval = 10;
            timerRefresh.Enabled = true;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (AlarmeCheck.Checked == true)
            {
                Validation_Alarme();
            }
            if (MinuteurCheck.Checked == true)
            {
                Validation_Minuteur();
            }
        }

        private void HeureUpDown_ValueChanged(object sender, EventArgs e)
        {
            DateTime datetemp = dateTimeCalendar.Value;
            DateTime newdate = new DateTime(datetemp.Year, datetemp.Month, datetemp.Day, (int)HeureUpDown.Value, (int)MinuteUpDown.Value, 0);
            if (HeureUpDown.Value == 24)
            {
                HeureUpDown.Value = 0;
                dateTimeCalendar.Value = dateTimeCalendar.Value.AddDays(1);
            }
            if (HeureUpDown.Value == -1)
            {
                HeureUpDown.Value = 23;
                dateTimeCalendar.Value = dateTimeCalendar.Value.AddDays(-1);
            }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Voulez vous vraiment quitter l'application?", "FIN", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                if (dr == DialogResult.No)
                {
                    //this.WindowState = FormWindowState.Minimized;
                    this.Visible = !this.Visible;
                }

            }

        }

        private void MinuteUpDown_ValueChanged(object sender, EventArgs e)
        {
            DateTime datetemp = dateTimeCalendar.Value;


            if (MinuteUpDown.Value == 60)
            {
                MinuteUpDown.Value = 0;
                HeureUpDown.Value += 1;
            }
            if (MinuteUpDown.Value == -1)
            {
                MinuteUpDown.Value = 59;
                HeureUpDown.Value -= 1;
            }
        }

        private void AlarmeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AlarmeCheck.Checked == true)
            {
                LabelAlarmText.Visible = true;
                groupAlarme.Enabled = true;
            }
            else
            {
                groupAlarme.Enabled = false;
            }
        }

        private void MinuteurCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (MinuteurCheck.Checked == true)
            {
                radio1fois.Checked = true;
                LabelAlarmText.Visible = true;
                labelAlarmDate.Visible = false;
                labelAlarmHeure.Visible = false;
                groupMinuteur.Enabled = true;
                radio1fois.Checked = true;
                groupTypeMin.Enabled = true;
                radioheure.Checked = true;
            }
            else
            {
                groupMinuteur.Enabled = false;
                groupTypeMin.Enabled = false;
            }
        }

        private void radioTextAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTextAlarm.Checked == true)
            {
                labelEntrerText.Enabled = true;
                textAlarme.Enabled = true;
            }
            else
            {
                labelEntrerText.Enabled = false;
                textAlarme.Enabled = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Reset_Form();
            timerminuteur.Enabled = false;
            timerminuteur.Tick -= new EventHandler(timerminuteur_Tick);
            alarmActiv = false;
            minActiv = false;

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Seb");
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            DateTime datetemp = dateTimeCalendar.Value;
            DateTime dateactu = new DateTime(datetemp.Year, datetemp.Month, datetemp.Day, (int)HeureUpDown.Value, (int)MinuteUpDown.Value, 0);

            if (dateactu < DateTime.Now)
            {
                HeureUpDown.Value = DateTime.Now.Hour;
                MinuteUpDown.Value = DateTime.Now.Minute + 1;
            }
            if (AlarmeCheck.Checked == true)
            {
                if (alarmActiv)
                {
                    LabelAlarmText.ForeColor = Color.Red;
                    LabelAlarmText.Text = "Alarme Active";
                    if (datalarm.Minute == DateTime.Now.Minute && datalarm.Second == DateTime.Now.Second)
                    {
                        if (radioShutdown.Checked)
                        {
                            Process.Start("shutdown", "/s /t 0");
                        }
                        else
                        {
                            alarmActiv = false;
                            MessageBox.Show(textAlarm);
                        }
                    }
                }
                else
                {
                    LabelAlarmText.ForeColor = Color.YellowGreen;
                    LabelAlarmText.Text = "Alarme Désactivée";
                }
            }
            if (MinuteurCheck.Checked == true)
            {
                if (minActiv)
                {
                    LabelAlarmText.Text = "Minuteur activé";
                }
                else
                {
                    LabelAlarmText.Text = "Minuteur désactivé";
                }

            }
        }

        private void dateTimeCalendar_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeCalendar.Value < calendar)
            {
                dateTimeCalendar.Value = DateTime.Now;
                MessageBox.Show("Impossible de programmer une alarme dans le passé", "Erreur de date", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void Validation_Alarme()
        {
            alarmActiv = true;
            datalarm = new DateTime(calendar.Year, calendar.Month, calendar.Day, (int)HeureUpDown.Value, (int)MinuteUpDown.Value, 0);
            if (textAlarme.Text.Length == 0)
            {
                textAlarm = "ALARME";
            }
            else
            {
                textAlarm = textAlarme.Text;
            }

            LabelAlarmText.Visible = true;
            labelAlarmDate.Visible = true;
            labelAlarmHeure.Visible = true;
            labelAlarmHeure.Text = datalarm.ToString("t");
            labelAlarmDate.Text = datalarm.ToString("d");
        }

        private void Reset_Form()
        {
            alarmActiv = false;
            groupAlarme.Enabled = false;
            groupMinuteur.Enabled = false;
            groupTypeMin.Enabled = false;
            dateTimeCalendar.Value = DateTime.Now;
            AlarmeCheck.Checked = false;
            MinuteurCheck.Checked = false;
        }

        private void Validation_Minuteur()
        {
            minActiv = true;
            //timerminuteur.Interval = (minuteur * 60000);
            timerminuteur.Interval = (minuteur * 100);
            timerminuteur.Tick += new EventHandler(timerminuteur_Tick);
            timerminuteur.Enabled = true;
            LabelAlarmText.ForeColor = Color.Red;

        }

        private void timerminuteur_Tick(object sender, EventArgs e)
        {
            if (radio1fois.Checked)
            {
                timerminuteur.Enabled = false;
                minActiv = false;
                LabelAlarmText.ForeColor = Color.YellowGreen;
                string message = string.Format("Minuteur de {0} minutes FINI !!!", minuteur.ToString());
                MessageBox.Show(message, "Minuteur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                timerminuteur.Tick -= new EventHandler(timerminuteur_Tick);

            }
            else
            {
                string message = string.Format("Minuteur de {0} minutes !!!", minuteur.ToString());
                MessageBox.Show(message, "Minuteur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void Recup_minuteur(object sender)
        {
            RadioButton radiominute = (RadioButton)sender;
            minuteur = Convert.ToInt32(radiominute.Tag.ToString());
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {

            this.ShowInTaskbar = Visible;
        }

        private void radiodemiheure_CheckedChanged(object sender, EventArgs e)
        {
            if (radiodemiheure.Checked == true)
            {
                Recup_minuteur(sender);
            }
        }

        private void radioheure_CheckedChanged(object sender, EventArgs e)
        {
            if (radioheure.Checked == true)
            {
                Recup_minuteur(sender);
            }
        }

        private void radio2heure_CheckedChanged(object sender, EventArgs e)
        {
            if (radio2heure.Checked == true)
            {
                Recup_minuteur(sender);
            }
        }

        private void radio4heure_CheckedChanged(object sender, EventArgs e)
        {
            if (radio4heure.Checked == true)
            {
                Recup_minuteur(sender);
            }
        }

        private void radio6heure_CheckedChanged(object sender, EventArgs e)
        {
            if (radio6heure.Checked == true)
            {
                Recup_minuteur(sender);
            }
        }

        private void radio12heure_CheckedChanged(object sender, EventArgs e)
        {
            if (radio12heure.Checked == true)
            {
                Recup_minuteur(sender);
            }
        }
    }
}
