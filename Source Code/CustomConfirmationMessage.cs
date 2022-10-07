using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class CustomConfirmationMessage : Form
    {

        private bool _Yes = false;
        public CustomConfirmationMessage()
        {
            InitializeComponent();
        }
        
        public bool Yes
        {
            get { return _Yes; }
            set { /*_Yes = value;*/
                //Check if the bloolen variable changes from false to true
                if (_Yes == false && value == true)
                {
                    // Do something
                    
                }
                //Update the boolean variable
                _Yes = value;

            }

        }
        public Label MessageLabel
        {
            get { return lblMessage; }
            set { lblMessage = value; }

        }
        public void btnYes_Click(object sender, EventArgs e)
        {
            Yes = true;
            this.Hide();
            
        }

        public void btnNo_Click(object sender, EventArgs e)
        {
            Yes = false;
            this.Hide();
        }








        // Custom Title Bar code.

        //For moving the form from the panel on top
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void btnExitTop_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

    }
}
