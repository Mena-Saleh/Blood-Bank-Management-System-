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
    public partial class RegisterForm : Form
    {
        public bool isDonor() //Returns true if it is a donor, else returns false.
        {
            return (donorControl1.IsAccessible && !recepientControl1.IsAccessible);
        }
        public bool isValidEmail() {

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
        public bool isFutureDate() {

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
        public bool isFilled() //Check if all fields are filled corretly
        {
            if (isDonor()) //donor
            {
                if (txtbxAge.Text != "" && txtbxMail.Text != "" && txtbxName.Text != "" && txtbxPassword.Text != "" && txtbxConfirmPassword.Text != "" && cmbobxBloodType.SelectedIndex != -1) //Check if all necessary donor fields are filled.
                {

                    return true;
                    
                }
                else
                {
                    CustomMessageBox Msg = new CustomMessageBox();
                    Msg.MessageLabel.Text = "Please fill all the necessary fields.";
                    Msg.Show();
                    return false;
                }
            }
            else //reciever
            {
                if (txtbxAge.Text != "" && txtbxMail.Text != "" && txtbxName.Text != "" && txtbxPassword.Text != "" && txtbxConfirmPassword.Text != "" && cmbobxBloodType.SelectedIndex != -1 && recepientControl1.txtbxHospitalProperty.Text != "" && recepientControl1.txtbxDoctorOfTheCaseProperty.Text != "")
                {
                    return true;
                }
                else
                {
                    CustomMessageBox Msg = new CustomMessageBox();
                    Msg.MessageLabel.Text = "Please fill all the necessary fields.";
                    Msg.Show();
                    return false;
                }

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

            if (isDonor())
            {
                for (int i = 0; i < Data.Donors.Count(); i++)
                {
                    if (Data.Donors[i].Mail.ToLower() == txtbxMail.Text.ToLower())
                    {
                        CustomMessageBox Msg = new CustomMessageBox();
                        Msg.MessageLabel.Text = "Email already registered.";
                        Msg.Show();
                        return false;
                    }
                }
                return true;
            }
            else
            {
                for (int i = 0; i < Data.Recepients.Count(); i++)
                {
                    if (Data.Recepients[i].Mail.ToLower() == txtbxMail.Text.ToLower())
                    {
                        CustomMessageBox Msg = new CustomMessageBox();
                        Msg.MessageLabel.Text = "Email already registered.";
                        Msg.Show();
                        return false;
                    }
                }
                return true;
            }
        }
        public void registerUser() //Registers the new user into the Data.
        {

            if (isDonor())
            {
                Donor temp = new Donor(Person.IDCounter, int.Parse(txtbxAge.Text), txtbxName.Text, txtbxMail.Text, txtbxPassword.Text, cmbobxBloodType.SelectedItem.ToString(), rdiobtnFemale.Checked, donorControl1.chckbxBloodPressureDisordersProperty.Checked, donorControl1.chckbxThyroidDiseaseProperty.Checked, donorControl1.chckbxDiabetesProperty.Checked, donorControl1.chckbxCancerProperty.Checked, donorControl1.chckbxHeartDisordersProperty.Checked, donorControl1.chckbxHepatitisProperty.Checked, donorControl1.rchtxtbxOtherDiseaseProperty.Text, donorControl1.chckbxNewDonorProperty.Checked ? DateTime.MinValue : donorControl1.calDateOfLastDonationProperty.SelectionStart);
                Data.Donors.Add(temp);
            }
            else
            {
                Recepient temp = new Recepient(Person.IDCounter, int.Parse(txtbxAge.Text), txtbxName.Text, txtbxMail.Text, txtbxPassword.Text, cmbobxBloodType.SelectedItem.ToString(), rdiobtnFemale.Checked, recepientControl1.txtbxHospitalProperty.Text, recepientControl1.txtbxDoctorOfTheCaseProperty.Text);
                Data.Recepients.Add(temp);
            }
            CustomMessageBox Msg = new CustomMessageBox();
            Msg.MessageLabel.Text = "Registered Successfully.";
            Msg.Show();
            Person.IDCounter++;
        }
       
        public RegisterForm()
        {
          
            InitializeComponent();
            btnGoHome.Text = Data.LoggedInIndex == -1 ? "Back" : "Home"; //If admin it i'll say back instead of home.
            donorControl1.IsAccessible = true;
            recepientControl1.Hide();
            recepientControl1.IsAccessible = false;
            btnRegDonor.BackColor = Color.FromArgb(242, 84, 91);


        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Data.LoggedInIndex == -1) //If the admin is logged in.
            {
                AdminManageUsersForm MyAdminManageUsersForm = new AdminManageUsersForm();
                MyAdminManageUsersForm.Show();
            }
            else
            {
                Home myHomeForm = new Home();
                myHomeForm.Show();
            }
        }

        private void btnRegDonor_Click(object sender, EventArgs e)
        {
            btnRegDonor.BackColor = Color.FromArgb(242, 84, 91);
            btnRegReciever.BackColor = Color.FromArgb(42, 84, 101);
            recepientControl1.IsAccessible = false;
            recepientControl1.Hide();
            donorControl1.Show();
            donorControl1.IsAccessible = true;
            donorControl1.BringToFront();
        }

        private void btnRegReciever_Click(object sender, EventArgs e)
        {
            btnRegDonor.BackColor = Color.FromArgb(42, 84, 101);
            btnRegReciever.BackColor = Color.FromArgb(242, 84, 91);
            donorControl1.IsAccessible = false;
            donorControl1.Hide();
            recepientControl1.Show();
            recepientControl1.IsAccessible = true;
            recepientControl1.BringToFront();
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
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
                                registerUser(); //Register the new user into the system.
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

