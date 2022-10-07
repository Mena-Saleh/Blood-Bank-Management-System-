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
    
    //Naming conventions: Pascal Case for fields and classes and CamelCase for methods.
    public partial class Home : Form
    {
        


        public Home()
        {
         
            InitializeComponent();
            //Only read from file if the Data class is empty, otherwise it shouldn't read from file in case we navigate back and forth to the home form.
            if (Data.Donors.Count==0&& Data.Recepients.Count==0&&Data.DonationRequests.Count==0&&Data.BloodBank.Count==0)
                Data.readDataFromFile();


        }



        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm MyLoginForm = new LoginForm();
            MyLoginForm.Show();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            this.Hide(); //hide this form
            RegisterForm myRegisterForm = new RegisterForm();
            myRegisterForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Data.writeDataToFile();
            this.Close();
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
       

        private void pnlTitleBar_MouseMove_1(object sender, MouseEventArgs e) //Allow moving the application from the title bar.
        {
            Move_Form(Handle, e);
        }

        private void btnExitTop_Click_1(object sender, EventArgs e) //To exit from the exit button
        {
            Data.writeDataToFile();
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e) //To minimize from the minimize button.
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
