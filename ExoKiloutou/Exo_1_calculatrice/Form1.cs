using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Exo_1_calculatrice
{
    public partial class Additionneur : Form
    {

        int total = 0;
        public Additionneur()
        {
            InitializeComponent();
        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            TextCalcul.Clear();
            total = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            calcule(sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcule(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcule(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcule(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calcule(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            calcule(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calcule(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calcule(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calcule(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calcule(sender);
        }

        private void buttonCalculer_Click(object sender, EventArgs e)
        {
            TextCalcul.Clear();
            TextCalcul.Text = total.ToString() + "+";
        }
        public void calcule(object _tag)
        {
            Button Tag = (Button)_tag;
            TextCalcul.Text += Tag.Text + "+";
            int num = int.Parse(Tag.Text);
            total += num;
        }
    }
}
