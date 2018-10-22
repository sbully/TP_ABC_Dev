using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvadersWF1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            { Point test = this.Tank.Location;
                test.X += 10;


                this.Tank.Location = test;
                Invalidate(true);
                    //deplacement à gauche de tankbox
            }
            if (e.KeyCode == Keys.Right)
            {
                //deplacement à droite de tankbox
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //mouvement des Invaders
        }
    }
}
