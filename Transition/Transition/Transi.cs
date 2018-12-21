using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transition
{
    [ToolboxItem(true)]

    [DefaultBindingProperty("Value")]

    class Transition : Timer
    {
        UserControl openUserCtrl;
        UserControl newUserCtrl;

        private int speedAnim;

        bool hide = true;
        int width;


        [Category("AnimationSpeed")]
        public int SpeedAnim
        {
            get { return speedAnim; }
            set
            {
                if (value < 0)
                {
                    value = 1;
                }
                speedAnim = value;
            }
        }



        public Transition() : base()
        {
            
        }

        public void TransiShow(UserControl _userControl)
        {
            if (openUserCtrl != null && (openUserCtrl.Width != width || newUserCtrl.Width != width))
            {
                Close();
            }
            else if (openUserCtrl != _userControl)
            {
                newUserCtrl = _userControl;
                width = newUserCtrl.Width;
                newUserCtrl.Width = 0;
                this.Tick += Transition_Tick;
                this.Enabled = true;
                newUserCtrl.BringToFront();
            }
        }
        public void TransiShow()
        {

        }

        private void Close()
        {
            openUserCtrl.Width = width;
            newUserCtrl.Width = width;
            openUserCtrl.Visible = false;
            newUserCtrl.Visible = false;
            this.Tick -= Transition_Tick;
        }

        private void Transition_Tick(object sender, EventArgs e)
        {
            if (!hide)
            {
                HideUserCtrl();
            }
            else
            {
                ShowUserCtrl();
            }
        }

        private void HideUserCtrl()
        {
            openUserCtrl.Width -= 50;
            if (openUserCtrl.Width <= 0)
            {
                hide = true;
                openUserCtrl.Visible = false;
                openUserCtrl.Width = width;
            }
        }

        private void ShowUserCtrl()
        {
            newUserCtrl.Visible = true;
            newUserCtrl.Width += 50;
            if (newUserCtrl.Width >= width)
            {
                newUserCtrl.Width = width;
                openUserCtrl = newUserCtrl;
                this.Tick -= Transition_Tick;
                this.Enabled = false;
                hide = false;
            }

        }


    }
}
