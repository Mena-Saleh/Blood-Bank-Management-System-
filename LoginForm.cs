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
    public partial class LoginForm : Form
    {
        bool IsDonor = true;
        public void login() {
            bool UserExists = false;
            if (txtbxEmail.Text.ToUpper().Equals(Data.AdminMail.ToUpper()) && txtbxPassword.Text.Equals(Data.AdminPassword)) //Check admin login first.
            {
                //Redirect to admin form
                UserExists = true;
                Data.LoggedInIndex = -1;
                AdminForm MyAdminForm = new AdminForm();
                this.Hide();
                MyAdminForm.Show();
            }
            else
            {
                if (IsDonor)
                {
                    for (int i = 0; i < Data.Donors.Count; i++)
                    {
                        if (Data.Donors[i].Mail.ToLower().Equals(txtbxEmail.Text.ToLower()))
                        {
                            if (Data.Donors[i].Password.Equals(txtbxPassword.Text))
                            {
                                //Redirect to donor form
                                Data.LoggedInIndex = i;
                                UserExists = true;
                                this.Hide();
                                DonorForm MyDonorForm = new DonorForm();
                                MyDonorForm.Show();
                                break;
                            }

                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Data.Recepients.Count; i++)
                    {
                        if (Data.Recepients[i].Mail.ToLower().Equals(txtbxEmail.Text.ToLower()))
                        {
                            if (Data.Recepients[i].Password.Equals(txtbxPassword.Text))
                            {
                                //Redirect to recepient form
                                Data.LoggedInIndex = i;
                                UserExists = true;
                                this.Hide();
                                RecepientForm MyRecepientForm = new RecepientForm();
                                MyRecepientForm.Show();
                                break;
                            }

                        }
                    }
                }
            }
            

            if (!UserExists)
            {
                //MessageBox.Show("Incorrect Email or Password, please try again.");
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Incorrect Email or Password, please try again";
                Msg.Show();
            }


        }

        public LoginForm()
        {
            InitializeComponent();
            btnLoginDonor.BackColor = Color.FromArgb(242, 84, 91);
            
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home myHomeForm = new Home();
            myHomeForm.Show();
        }

        private void btnLoginDonor_Click(object sender, EventArgs e)
        {
            btnLoginDonor.BackColor = Color.FromArgb(242, 84, 91);
            btnLoginReciever.BackColor = Color.FromArgb(42, 84, 101);
            IsDonor = true;
        }

        private void btnLoginReciever_Click(object sender, EventArgs e)
        {
            btnLoginDonor.BackColor = Color.FromArgb(42, 84, 101);
            btnLoginReciever.BackColor = Color.FromArgb(242, 84, 91);
            IsDonor = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
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

        private void btnMinimize_Click(object sender, EventArgs e) //To minimize
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnExitTop_Click(object sender, EventArgs e) //To exit
        {
            Data.writeDataToFile();
            Application.Exit();
        }
        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)//To Move
        {
            Move_Form(Handle, e);
        }
    }
}
