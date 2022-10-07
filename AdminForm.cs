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
    public partial class AdminForm : Form
    {
        bool EditAdmin;
        public void displayDonationRequest(DonationRequest Temp) 
        {
            txtbxQuantity.Text = Temp.BloodQuantity.ToString();
            txtbxAge.Text = Data.Donors[Temp.DonorIndex].Age.ToString();
            if (Data.Donors[Temp.DonorIndex].DateOfLastDonation == DateTime.MinValue) //If it is a new donor then display nothing
            {
                txtbxLastDonationDate.Text = "None";
                lblDaysFromLastDonation.Text = "";
            }
            else //If there is a previous donation, print the date and calculate day difference.
            {
                txtbxLastDonationDate.Text = Data.Donors[Temp.DonorIndex].DateOfLastDonation.ToString();
                lblDaysFromLastDonation.Text = (DateTime.Now.Date - Data.Donors[Temp.DonorIndex].DateOfLastDonation.Date).Days.ToString() + " Days Ago"; //Calculate how many days ago this donation was made.
            }
            rchtxtbxOtherDisease.Text = Data.Donors[Temp.DonorIndex].OtherDisease;
            chckbxBloodPressureDisorders.Checked= Data.Donors[Temp.DonorIndex].BloodPressureDisorders;
            chckbxCancer.Checked = Data.Donors[Temp.DonorIndex].Cancer;
            chckbxDiabetes.Checked = Data.Donors[Temp.DonorIndex].Diabetes;
            chckbxHeartDisorders.Checked = Data.Donors[Temp.DonorIndex].HeartDisorders;
            chckbxHepatitis.Checked = Data.Donors[Temp.DonorIndex].Hepatitis;
            chckbxThyroidDisease.Checked = Data.Donors[Temp.DonorIndex].ThyroidDisease;





        }
        public void clearGUI() {
            txtbxQuantity.Text = "";
            txtbxAge.Text = "";
            txtbxLastDonationDate.Text = "";
            lblDaysFromLastDonation.Text = "";
            chckbxBloodPressureDisorders.Checked = false;
            chckbxCancer.Checked = false;   
            chckbxDiabetes.Checked = false;
            chckbxHeartDisorders.Checked = false;
            chckbxHepatitis.Checked = false;
            chckbxThyroidDisease.Checked = false;   

        }
        public void nextRequest()
        {

            if (Data.DonationRequests.Count != 0) //If there is any donation requests, show them on the GUI.
            {
                lblRequests.Text = "Queued Requests:";
                displayDonationRequest(Data.DonationRequests.Peek());
                lblRequestsCount.Text = "Remaining Requests " + Data.DonationRequests.Count;
                btnAcceptRequest.Enabled = true;
                btnRefuseRequest.Enabled = true;
            }
            else //Notify the admin that there are no requests.
            { 
                lblRequests.Text = "No Requests Queued";
                lblRequestsCount.Text = "Remaining Requests 0";
                btnAcceptRequest.Enabled = false;
                btnRefuseRequest.Enabled = false;
                clearGUI();

            }
        }
        public AdminForm()
        {
            InitializeComponent();
            adminCredentialsControl1.Hide();
            EditAdmin = false;
            nextRequest();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Data.LoggedInIndex = 0; //Because the admin is no longer logged in.
            this.Hide();
            Home MyHome = new Home();
            MyHome.Show();
        }

        private void btnAcceptRequest_Click(object sender, EventArgs e)
        {
            //Create a blood object that has the donor's data through the donor index in the donation request queue front.
            CustomMessageBox Msg = new CustomMessageBox();
            Msg.MessageLabel.Text = "Donation Request Approved.";
            Msg.Show();
            AcceptedDonorRequests Temp = new AcceptedDonorRequests(DateTime.Now, Data.DonationRequests.Peek().BloodQuantity, Data.DonationRequests.Peek().DonorIndex);
            Data.AcceptedDonationRequests.Add(Temp);
            Data.DonationRequests.Dequeue();
            nextRequest();
            
        }

        private void btnRefuseRequest_Click(object sender, EventArgs e)
        {
            CustomMessageBox Msg = new CustomMessageBox();
            Msg.MessageLabel.Text = "Donation Request Declined";
            Msg.Show(); 
            Data.DonationRequests.Dequeue();
            nextRequest();
        }

       

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (EditAdmin == false)
            {
                EditAdmin = true;
                adminCredentialsControl1.Show();
                pnlRequestApproval.Hide();
                btnUpdateAdmin.BackColor = Color.FromArgb(242, 84, 91);
                adminCredentialsControl1.txtbxMailProperty.Text = Data.AdminMail;
                adminCredentialsControl1.txtbxPasswordProperty.Text = Data.AdminPassword;
                adminCredentialsControl1.txtbxConfirmPasswordProperty.Text = Data.AdminPassword;
            }
            else {
                EditAdmin = false;
                pnlRequestApproval.Show();
                adminCredentialsControl1.Hide();
                btnUpdateAdmin.BackColor = Color.FromArgb(42, 84, 101);

            }

        }

        private void btnManageBloodBank_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageBloodBankForm MyAdminManageBloodBankForm = new AdminManageBloodBankForm();
            MyAdminManageBloodBankForm.Show();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageUsersForm MyAdminManageUsersForm = new AdminManageUsersForm();
            MyAdminManageUsersForm.Show();
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
