using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horloge
{
    public partial class Minuteur : UserControl
    {
        Horloge fenetrePrincipal;
        DateTime minuteur;
        bool up = false;
        int push = 0;
        double ajoutMinute;


        public Minuteur()
        {
            InitializeComponent();
        }
        public Minuteur(Horloge _fenetrePrincipal) : this()
        {
            fenetrePrincipal = _fenetrePrincipal;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxMinute.Text = (int.Parse(textBoxMinute.Text) + 1).ToString();
            up = true;
            timer1.Enabled = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            push = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            push++;
            if (push > 5 && up)
            {
                textBoxMinute.Text = (int.Parse(textBoxMinute.Text) + 1).ToString();
            }
            if (push > 5 && !up && int.Parse(textBoxMinute.Text) > 1)
            {
                textBoxMinute.Text = (int.Parse(textBoxMinute.Text) - 1).ToString();
            }
        }

        private void checkBoxPerso_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPerso.Checked)
            {
                checkBoxPreProg.Checked = false;
                groupBoxPerso.Enabled = true;
            }
            else
            {
                groupBoxPerso.Enabled = false;
            }
        }

        private void checkBoxPreProg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPreProg.Checked)
            {
                checkBoxPerso.Checked = false;
                groupBoxPerso.Enabled = false;

                groupBoxPreProg.Enabled = true;
            }
            else
            {
                groupBoxPreProg.Enabled = false;
            }
        }


        private void butValid_Click(object sender, EventArgs e)
        {
            butCancel.Enabled = true;
            butCancel.Visible = true;
            butValid.Enabled = false;
            butValid.Visible = false;
            if (checkBoxPerso.Checked)
            {
                minuteur = DateTime.Now.AddMinutes(double.Parse(textBoxMinute.Text));
            }
            else
            {
                minuteur = DateTime.Now.AddMinutes(ajoutMinute);
            }

            fenetrePrincipal.Set_Minuteur(minuteur);
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            butCancel.Enabled = false;
            butCancel.Visible = false;
            butValid.Enabled = true;
            butValid.Visible = true;
            fenetrePrincipal.Reset_Minuteur();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (int.Parse(textBoxMinute.Text) > 1)
            {
                textBoxMinute.Text = (int.Parse(textBoxMinute.Text) - 1).ToString();
                up = false;
                timer1.Enabled = true;
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            push = 0;
        }
        private void Recup_Minute(object sender)
        {
            RadioButton radioMinute = (RadioButton)sender;
            ajoutMinute = double.Parse(radioMinute.Text.Substring(0, 2));
        }

        private void radioBut5min_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBut5min.Checked == true)
            {
                Recup_Minute(sender);
            }
        }
        


    }


}
