using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horloge
{

    class Transition
    {
        Timer timerTransi = new Timer();
        UserControl openUserCtrl;
        UserControl newUserCtrl;



        bool hide = true;
        int width;

        public Transition()
        {

            timerTransi.Interval = 1;


        }

        public void TransiShow(UserControl _userControl)
        {
            if (openUserCtrl!=null && (openUserCtrl.Width != width || newUserCtrl.Width!=width))
            {
                Close();
            }
            else if (openUserCtrl != _userControl)
            {
                newUserCtrl = _userControl;
                width = newUserCtrl.Width;
                newUserCtrl.Width = 0;
                timerTransi.Enabled = true;
                newUserCtrl.BringToFront();
                timerTransi.Tick += timerTransi_Tick;
            }
        }

        private void timerTransi_Tick(object sender, EventArgs e)
        {
            if (!hide)
            {
                openUserCtrl.Width -= 50;
                if (openUserCtrl.Width <= 0)
                {
                    hide = true;
                    openUserCtrl.Visible = false;
                    openUserCtrl.Width = width;
                }
            }
            else
            {
                newUserCtrl.Visible = true;
                newUserCtrl.Width += 50;
                if (newUserCtrl.Width >= width)
                {
                    newUserCtrl.Width = width;
                    openUserCtrl = newUserCtrl;
                    timerTransi.Tick -= timerTransi_Tick;
                    timerTransi.Enabled = false;
                    hide = false;
                }
            }
        }
        private void Close()
        {
            openUserCtrl.Width = width;
            newUserCtrl.Width = width;
            openUserCtrl.Visible = false;
            newUserCtrl.Visible = false;
            timerTransi.Tick -= timerTransi_Tick;
        }


    }
}
