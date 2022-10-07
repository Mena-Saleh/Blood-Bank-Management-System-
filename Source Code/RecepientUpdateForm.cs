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
    public partial class RecepientUpdateForm : Form
    {
        int ToUpdate = Data.LoggedInIndex == -1 ? Data.MarkedByAdminIndex : Data.LoggedInIndex;
        //Determines whethe a user is updating their own account or if an admin is updating it.
        public bool isValidEmail()
        {

            if (Data.validateEmail(txtbxMail.Text)) //If the mail is in correct email format (Ex: User@Domain.com
            {
                return true;
            }
            else
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Invalid Email Address.";
                Msg.Show();
                return false;
            }
        } //Returns true if mail is in correct format, otherwise false.
        public void fillGUIData()
        {
            txtbxName.Text = Data.Recepients[ToUpdate].Name;
            txtbxMail.Text = Data.Recepients[ToUpdate].Mail;
            txtbxPassword.Text = Data.Recepients[ToUpdate].Password;
            txtbxConfirmPassword.Text = Data.Recepients[ToUpdate].Password;
            txtbxAge.Text = Data.Recepients[ToUpdate].Age.ToString();
            cmbobxBloodType.SelectedItem = Data.Recepients[ToUpdate].BloodType;
            rdiobtnFemale.Checked = Data.Recepients[ToUpdate].Gender;
            rdiobtnMale.Checked = !Data.Recepients[ToUpdate].Gender;
            recepientControl1.txtbxDoctorOfTheCaseProperty.Text = Data.Recepients[ToUpdate].DoctorOfTheCase;
            recepientControl1.txtbxHospitalProperty.Text = Data.Recepients[ToUpdate].Hospital;

        } //Fills the GUI controls with the logged in user's data.
        public bool isFilled()
        {

            if (txtbxAge.Text != "" && txtbxMail.Text != "" && txtbxName.Text != "" && txtbxPassword.Text != "" && txtbxConfirmPassword.Text != "" && cmbobxBloodType.SelectedIndex != -1 && recepientControl1.txtbxHospitalProperty.Text != "" && recepientControl1.txtbxDoctorOfTheCaseProperty.Text != "")
            {
                return true;
            }
            else
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Please fill all necessary fields.";
                Msg.Show();
                return false;
            }


        } //Returns true if all fields are filled, otherwise returns false.
        public bool isMatchedPasswords() //Returns true if passwords match, otherwise false.
        {
            if (txtbxPassword.Text.Equals(txtbxConfirmPassword.Text))
            {
                return true;
            }
            else
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Passwords do not match.";
                Msg.Show();
                return false;
            }
        }
        public bool isUniqueMail() //Returns true if mail is unique, otherwise false.
        {
            for (int i = 0; i < Data.Recepients.Count(); i++)
            {//Makes sure the mail doesn't exist in the list, with the exception that it is the already existing mail before updating.
                if (Data.Recepients[i].Mail.ToLower() == txtbxMail.Text.ToLower() && txtbxMail.Text != Data.Recepients[ToUpdate].Mail) 
                {
                    CustomMessageBox Msg = new CustomMessageBox();
                    Msg.MessageLabel.Text = "Email is already registered.";
                    Msg.Show();
                    return false;
                }
            }
            return true;

        }
        public void updateUser() //Updates the logged in user's data based on GUI controls' values.
        {
            Data.Recepients[ToUpdate].Name = txtbxName.Text;
            Data.Recepients[ToUpdate].Mail = txtbxMail.Text;
            Data.Recepients[ToUpdate].Password = txtbxPassword.Text;
            Data.Recepients[ToUpdate].Password = txtbxConfirmPassword.Text;
            Data.Recepients[ToUpdate].Age = int.Parse(txtbxAge.Text);
            Data.Recepients[ToUpdate].BloodType = cmbobxBloodType.SelectedItem.ToString();
            Data.Recepients[ToUpdate].Gender = rdiobtnFemale.Checked;
            Data.Recepients[ToUpdate].Hospital = recepientControl1.txtbxHospitalProperty.Text;
            Data.Recepients[ToUpdate].DoctorOfTheCase = recepientControl1.txtbxDoctorOfTheCaseProperty.Text;

            CustomMessageBox Msg = new CustomMessageBox();
            Msg.MessageLabel.Text = "Updated Successfully.";
            Msg.Show();

        }
        public RecepientUpdateForm()
        {
            InitializeComponent();
            fillGUIData();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Data.LoggedInIndex == -1) //If the admin is logged in.
            {
                AdminManageUsersForm MyAdminManageUsersForm = new AdminManageUsersForm();
                MyAdminManageUsersForm.Show();
            }
            else
            {
                RecepientForm MyRecepientForm = new RecepientForm();
                MyRecepientForm.Show();
            }
        }

  
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (isFilled()) //All fields are filled.
            {
                if (isValidEmail()) //Email address is in a correct format.
                {
                    if (isUniqueMail()) //Email address is not used before for this type of user (Donor/Recepient).
                    {
                        if (isMatchedPasswords()) //Password and Confirm Password fields are matching.
                        {
                            updateUser(); //Register the new user into the system.
                        }
                    }

                }

            }
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
            Data.writeDataToFile();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }
    }
}
