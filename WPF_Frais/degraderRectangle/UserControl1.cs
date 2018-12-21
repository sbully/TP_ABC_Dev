using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace degraderRectangle
{

    public partial class UserControl1 : UserControl
    {

        
        public UserControl1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //LinearGradientBrush lineargrad = new LinearGradientBrush(new Point(20, 20), new Point(20, 70), Color.Red, Color.Blue);
            //Graphics g = panel1.CreateGraphics();
            ////g.FillRectangle(lineargrad, 20, 20, 50, 50);
            //g.FillEllipse(lineargrad, 20, 20, 100, 100);
            GraphicsPath gp = new GraphicsPath();
            Graphics graph = panel1.CreateGraphics();
            gp.AddEllipse(panel1.ClientRectangle);
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterPoint = new PointF(panel1.ClientRectangle.Width/2,panel1.ClientRectangle.Height/2);
            pgb.CenterColor = Color.White;
            pgb.SurroundColors = new Color[] { Color.Red };
            pgb.SetBlendTriangularShape(.5f,1.0f);
            pgb.FocusScales = new PointF(0f, 0f);
            graph.FillPath(pgb,gp);
            pgb.Dispose();
            gp.Dispose();


        }

    }
}