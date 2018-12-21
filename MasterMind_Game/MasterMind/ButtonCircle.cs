using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Controls;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Media;

namespace MasterMind
{
    class ButtonCircle : Button
    {
        protected override void OnRender(DrawingContext dc)
        {
            SolidColorBrush solidColorBrush = new SolidColorBrush();
            solidColorBrush.Color = Colors.Green;
            Pen mypen = new Pen(Brushes.Blue, 10);
            Point centre = new Point(100,100);
            EllipseGeometry ellipse = new EllipseGeometry();
            dc.DrawEllipse(solidColorBrush,mypen,centre,100,100);


        }

    }
}
