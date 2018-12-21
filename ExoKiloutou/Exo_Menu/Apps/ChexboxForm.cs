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
    public partial class ChexboxForm : Form
    {
        public ChexboxForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labeltxtmodif.Text = null;
        }

        private void ChekBackColor_CheckedChanged(object sender, EventArgs e)
        {
            if (ChekBackColor.Checked == true)
            {
                groupFond.Enabled = true;
            }
            else
            {
                groupFond.Enabled = false;

            }
        }

        private void textSaisi_TextChanged(object sender, EventArgs e)
        {
            if (textSaisi.Text.Length>0)
            {
                groupChoix.Enabled = true;
                labeltxtmodif.Text = textSaisi.Text;
               
            }
            else
            {
                labeltxtmodif.Text = null;
                groupChoix.Enabled = false;
            }

        }

        private void checkFontColor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFontColor.Checked == true)
            {
                groupCaract.Enabled = true;
            }
            else
            {
                groupCaract.Enabled = false;
            }



        }

        private void checkCasse_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCasse.Checked == true)
            {
                groupCasse.Enabled = true;
            }
            else
            {
                groupCasse.Enabled = false;
            }
        }

        private void BackRed_CheckedChanged(object sender, EventArgs e)
        {
            labeltxtmodif.BackColor = Change_Color(sender);
        }

        public Color Change_Color(object _check)
        {
            RadioButton choixRadio = (RadioButton)_check;
            Color couleur = new Color();
            string color = (string)choixRadio.Tag;
            couleur = Color.FromName(color);
            return couleur;
        }

        private void BackGreen_CheckedChanged(object sender, EventArgs e)
        {
            labeltxtmodif.BackColor = Change_Color(sender);
        }

        private void BackBlue_CheckedChanged(object sender, EventArgs e)
        {
            labeltxtmodif.BackColor = Change_Color(sender);
        }

        private void FrontRed_CheckedChanged(object sender, EventArgs e)
        {
            labeltxtmodif.ForeColor = Change_Color(sender);
        }

        private void FrontWhite_CheckedChanged(object sender, EventArgs e)
        {
            labeltxtmodif.ForeColor = Change_Color(sender);
        }

        private void FrondBlack_CheckedChanged(object sender, EventArgs e)
        {
            labeltxtmodif.ForeColor = Change_Color(sender);
        }

        private void CasseMinu_CheckedChanged(object sender, EventArgs e)
        {
            labeltxtmodif.Text = labeltxtmodif.Text.ToLower();
        }

        private void Majuscules_CheckedChanged(object sender, EventArgs e)
        {
            labeltxtmodif.Text = labeltxtmodif.Text.ToUpper();
        }
    }
}
