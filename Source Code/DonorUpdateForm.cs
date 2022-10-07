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
    public partial class DonorUpdateForm : Form
    {
        int ToUpdateIndex = Data.LoggedInIndex == -1 ? Data.MarkedByAdminIndex : Data.LoggedInIndex;
        public bool isValidEmail()
        {

            if (Data.validateEmail(txtbxMail.Text)) //If the mail is in correct email format (Ex: User@Domain.com
            {
                return true;
            }
            else
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Invalid Email Address";
                Msg.Show();
                return false;
            }
        } //Returns true if mail is in correct format, otherwise false.
        public bool isFutureDate()
        {

            if (donorControl1.calDateOfLastDonationProperty.SelectionStart.Date > DateTime.Now.Date) //Check if the date is in the future.
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Future Date not allowed.";
                Msg.Show();
                return true;
            }
            else
            {
               
                return false; //Not a future date, meaning it is a correct date.
            }
        } //Returns true if the date is in the future, otherwise false.
        public void fillGUIData() {
            txtbxName.Text = Data.Donors[ToUpdateIndex].Name;
            txtbxMail.Text = Data.Donors[ToUpdateIndex].Mail;
            txtbxPassword.Text = Data.Donors[ToUpdateIndex].Password;
            txtbxConfirmPassword.Text = Data.Donors[ToUpdateIndex].Password;
            txtbxAge.Text = Data.Donors[ToUpdateIndex].Age.ToString();
            cmbobxBloodType.SelectedItem = Data.Donors[ToUpdateIndex].BloodType;
            rdiobtnFemale.Checked = Data.Donors[ToUpdateIndex].Gender;
            rdiobtnMale.Checked = !Data.Donors[ToUpdateIndex].Gender;
            donorControl1.chckbxBloodPressureDisordersProperty.Checked = Data.Donors[ToUpdateIndex].BloodPressureDisorders;
            donorControl1.chckbxCancerProperty.Checked = Data.Donors[ToUpdateIndex].Cancer;
            donorControl1.chckbxDiabetesProperty.Checked = Data.Donors[ToUpdateIndex].Diabetes;
            donorControl1.chckbxHeartDisordersProperty.Checked = Data.Donors[ToUpdateIndex].HeartDisorders;
            donorControl1.chckbxHepatitisProperty.Checked = Data.Donors[ToUpdateIndex].Hepatitis;
            donorControl1.chckbxThyroidDiseaseProperty.Checked = Data.Donors[ToUpdateIndex].ThyroidDisease;
            donorControl1.rchtxtbxOtherDiseaseProperty.Text = Data.Donors[ToUpdateIndex].OtherDisease;
            donorControl1.calDateOfLastDonationProperty.SetDate(Data.Donors[ToUpdateIndex].DateOfLastDonation.Equals(DateTime.MinValue) ? DateTime.Now : Data.Donors[ToUpdateIndex].DateOfLastDonation);
            donorControl1.chckbxNewDonorProperty.Checked = Data.Donors[ToUpdateIndex].DateOfLastDonation.Equals(DateTime.MinValue) ? true : false;

        } //Fills the GUI controls with the logged in user's data.
        public bool isFilled()
        {
            
                if (txtbxAge.Text != "" && txtbxMail.Text != "" && txtbxName.Text != "" && txtbxPassword.Text != "" && txtbxConfirmPassword.Text != "" && cmbobxBloodType.SelectedIndex != -1 /*&& donorControl1.txtbxDateOfLastDonationProperty.Text != ""*/)
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
                for (int i = 0; i < Data.Donors.Count(); i++)
                {
                // Check uniqueness of Email against the Donors list, with the exception of the existing mail prior to the update.
                    if (Data.Donors[i].Mail.ToLower() == txtbxMail.Text.ToLower() && txtbxMail.Text != Data.Donors[ToUpdateIndex].Mail)
                    {
                    CustomMessageBox Msg = new CustomMessageBox();
                    Msg.MessageLabel.Text = "Email is already registered.";
                    Msg.Show();
                    return false;
                    }
                }
                return true;
           
        }
        public void updateUser() //Updates the user's data based on GUI controls' values.
        {
            Data.Donors[ToUpdateIndex].Name = txtbxName.Text;
            Data.Donors[ToUpdateIndex].Mail = txtbxMail.Text;
            Data.Donors[ToUpdateIndex].Password = txtbxPassword.Text;
            Data.Donors[ToUpdateIndex].Password = txtbxConfirmPassword.Text;
            Data.Donors[ToUpdateIndex].Age = int.Parse(txtbxAge.Text);
            Data.Donors[ToUpdateIndex].BloodType = cmbobxBloodType.SelectedItem.ToString();
            Data.Donors[ToUpdateIndex].BloodPressureDisorders = donorControl1.chckbxBloodPressureDisordersProperty.Checked;
            Data.Donors[ToUpdateIndex].Cancer = donorControl1.chckbxCancerProperty.Checked;
            Data.Donors[ToUpdateIndex].Diabetes = donorControl1.chckbxDiabetesProperty.Checked;
            Data.Donors[ToUpdateIndex].HeartDisorders = donorControl1.chckbxHeartDisordersProperty.Checked;
            Data.Donors[ToUpdateIndex].Hepatitis = donorControl1.chckbxHepatitisProperty.Checked;
            Data.Donors[ToUpdateIndex].ThyroidDisease = donorControl1.chckbxThyroidDiseaseProperty.Checked;
            Data.Donors[ToUpdateIndex].OtherDisease = donorControl1.rchtxtbxOtherDiseaseProperty.Text;
            Data.Donors[ToUpdateIndex].DateOfLastDonation = donorControl1.chckbxNewDonorProperty.Checked ? DateTime.MinValue : donorControl1.calDateOfLastDonationProperty.SelectionStart;
            Data.Donors[ToUpdateIndex].Gender = rdiobtnFemale.Checked;
            CustomMessageBox Msg = new CustomMessageBox();
            Msg.MessageLabel.Text = "Updated Successfully.";
            Msg.Show();

        }
        public void lockDateUpdateIfUser() //To prevent the user from changing their last donation date manually, only the admin can. to achieve business logic.
                                           //(meanining the user has to wait 90 days between every donation and they can't bypass that by updating last donation date.)
        {
            if (Data.LoggedInIndex != -1) //If it is not the admin.
            {
                donorControl1.calDateOfLastDonationProperty.Enabled = false;
                donorControl1.chckbxNewDonorProperty.Enabled = false;
            }

        }

      
        public DonorUpdateForm()
        {
            InitializeComponent();
            fillGUIData();
            lockDateUpdateIfUser();

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
                DonorForm MyDonorForm = new DonorForm();
                MyDonorForm.Show();
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (isFilled()) //All fields are filled.
            {
                if (isValidEmail()) //Email address is in a correct format.
                {
                    if (!isFutureDate()) //Last donation date is in the present or the past not the future (correct logically).
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
