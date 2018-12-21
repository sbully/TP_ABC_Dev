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
    public partial class CompoCouleur : Form
    {
        Color red = new Color();
        Color blue = new Color();
        Color green = new Color();
        Color final = new Color();
        public CompoCouleur()
        {
            InitializeComponent();
            labelRed.BackColor = Color.FromArgb(ScrollRed.Value, 0, 0);
            labelGreen.BackColor = Color.FromArgb(0, ScrollGreen.Value, 0);
            labelBlue.BackColor = Color.FromArgb(0, 0, ScrollBlue.Value);
            labelFinalColor.BackColor = Color.FromArgb(ScrollRed.Value, ScrollGreen.Value, ScrollBlue.Value);

        }

        private void ScrollRed_ValueChanged(object sender, EventArgs e)
        {
            numRed.Value = ScrollRed.Value;
            Red_Color();
        }

        private void ScrollGreen_ValueChanged(object sender, EventArgs e)
        {
            numGreen.Value = ScrollGreen.Value;
            Green_Color();
        }

        private void ScrollBlue_ValueChanged(object sender, EventArgs e)
        {
            numBlue.Value = ScrollBlue.Value;
            Blue_Color();
        }

        private void numRed_ValueChanged(object sender, EventArgs e)
        {
            ScrollRed.Value = (int)numRed.Value;
            Red_Color();

        }


        private void numGreen_ValueChanged(object sender, EventArgs e)
        {
            ScrollGreen.Value = (int)numGreen.Value;
            Green_Color();
        }

        private void numBlue_ValueChanged(object sender, EventArgs e)
        {
            ScrollBlue.Value = (int)numBlue.Value;
            Blue_Color();
        }


        private void Color_Final()
        {
            string codeColor;
            final = Color.FromArgb(ScrollRed.Value, ScrollGreen.Value, ScrollBlue.Value);
            labelFinalColor.BackColor = final;
            //codeColor = final.ToString();
            //labelFinalColor.Text = codeColor;
            codeColor = "RGB : "+final.R.ToString("X2") + final.G.ToString("X2") + final.B.ToString("X2");
            labelFinalColor.Text = codeColor;
        }

        private void Red_Color()
        {
            red = Color.FromArgb(ScrollRed.Value, 0, 0);
            labelRed.BackColor = red;
            Color_Final();
        }

        private void Blue_Color()
        {
            blue = Color.FromArgb(0, 0, ScrollBlue.Value);
            labelBlue.BackColor = blue;
            Color_Final();
        }

        private void Green_Color()
        {
            green = Color.FromArgb(0, ScrollGreen.Value, 0);
            labelGreen.BackColor = green;
            Color_Final();

        }


    }
}
