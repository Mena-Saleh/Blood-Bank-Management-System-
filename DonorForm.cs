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
using System.Threading;

namespace Blood_Bank_Management_System
{

    public partial class DonorForm : Form
    {
        private Queue<AcceptedDonorRequests> AcceptedByLoggedInDonor = new Queue<AcceptedDonorRequests>();
        public void removeRequestFromList() //Remove the first element in the blood bank list that matchest the logged in donor index in case the donor donates now or cancels the donation. 
        {
            for (int i = 0; i < Data.AcceptedDonationRequests.Count; i++)
            {
                if (Data.AcceptedDonationRequests[i].DonorIndex == Data.LoggedInIndex)
                {
                    Data.AcceptedDonationRequests.RemoveAt(i);
                    break; 
                }

            }
        
        }
        public void buildQueueOfAcceptedRequest () //Takes only the accepted requests by the logged in user from the list. and puts them in a queue
        {

            for (int i = 0; i < Data.AcceptedDonationRequests.Count; i++)
            {
                
                if (Data.AcceptedDonationRequests[i].DonorIndex == Data.LoggedInIndex)
                { 
                    AcceptedByLoggedInDonor.Enqueue(Data.AcceptedDonationRequests[i]);
                }

            }
        
        }
        public void nextRequest() //Displays the next request in queue in the windows form, or displays none if the queue is empty.
        {
            if (AcceptedByLoggedInDonor.Count != 0)
            {
                
                displayAcceptedDonationRequest(AcceptedByLoggedInDonor.Peek());

            }
            else 
            {
                clearGUIData();
            }

        }

        public void displayAcceptedDonationRequest(AcceptedDonorRequests Temp) //Takes an accepted donation request and displays it on the windows form.
        {
            lblAcceptedRequests.Text = "Accepted Requests:";
            lblDate.Text = "Accepted on: " + Temp.DateOfAcceptance.ToString() + " " + (DateTime.Now.Date - Temp.DateOfAcceptance.Date).Days.ToString() + " Days Ago";
            lblQuantity.Text = "Blood Quantity: " + Temp.BloodQuantity.ToString() + " ml";
            lblRemainingRequests.Text = "Remaining Requests: " + AcceptedByLoggedInDonor.Count;
            btnDonateNow.Show();
            btnCancel.Show();
            
        }
        public void clearGUIData() //Clears display data when queue is empty.
        {
            lblAcceptedRequests.Text = "No Accepted Requests Queued";
            lblDate.Text = "";
            lblQuantity.Text = "";
            lblRemainingRequests.Text = "Remaining Requests: " + AcceptedByLoggedInDonor.Count;
            btnDonateNow.Hide();
            btnCancel.Hide();
        }
       
        public DonorForm()
        {
            InitializeComponent();
            buildQueueOfAcceptedRequest();
            nextRequest();

        }


        private void btnDonate_Click(object sender, EventArgs e) //Makes a donation request to the admin.
        {
            if (cmbobxBloodAmount.Text == "")
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Please choose a quantity.";
                Msg.Show();
            }
            else
            {
                DonationRequest MyRequest = new DonationRequest(float.Parse(cmbobxBloodAmount.SelectedItem.ToString()), Data.LoggedInIndex);
                Data.DonationRequests.Enqueue(MyRequest);
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Requested Successfully";
                Msg.Show();
                cmbobxBloodAmount.SelectedItem = null;
            }
        }

        private void btnDonateNow_Click(object sender, EventArgs e) //donates to the bank after admin approves the request.
        {
            int DaysFromLastDonation = int.Parse((DateTime.Now.Date - Data.Donors[Data.LoggedInIndex].DateOfLastDonation.Date).TotalDays.ToString());
            if ( DaysFromLastDonation > 90) //if last donation is more than 90 days ago, then allow the user to donate.
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Donated Successfully";
                Msg.Show();
                Blood Temp = new Blood(Blood.IDCounter, Data.Donors[Data.LoggedInIndex].BloodType, DateTime.Now, DateTime.Now.AddDays(21), AcceptedByLoggedInDonor.Peek().BloodQuantity);
                Data.Donors[Data.LoggedInIndex].DateOfLastDonation = DateTime.Now; //Update date of last donation.
                Data.BloodBank.Add(Temp);
                Blood.IDCounter++;
                removeRequestFromList(); //removes the donation request from the accepted requests list.
                AcceptedByLoggedInDonor.Dequeue();
                nextRequest();
            }
            else
            {
                MessageBox.Show("You have to wait " + (90-DaysFromLastDonation) + " days before you can donate again.");

            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CustomMessageBox Msg = new CustomMessageBox();
            Msg.MessageLabel.Text = "Donation Cancelled";
            Msg.Show();
            removeRequestFromList(); //removes the donation request from the accepted requests list.
            AcceptedByLoggedInDonor.Dequeue();
            nextRequest();
        } //cancels an accepted donation request.

        private void btnUpdateAccount_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DonorUpdateForm MyDonorUpdateForm = new DonorUpdateForm();
            MyDonorUpdateForm.Show();
        }

        private void btnDeleteAccount_Click_1(object sender, EventArgs e)
        {
            //Delete account:
            Data.deleteDonorRequests();
            Data.Donors.RemoveAt(Data.LoggedInIndex);
            this.Hide();
            Home myHomeForm = new Home();
            myHomeForm.Show();
            CustomMessageBox Msg = new CustomMessageBox();
            Msg.MessageLabel.Text = "Deleted Successfully";
            Msg.Show();
            Msg.TopMost = true;

        }

        private void btnSignOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home myHomeForm = new Home();
            myHomeForm.Show();
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
