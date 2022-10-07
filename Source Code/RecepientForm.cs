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

    public partial class RecepientForm : Form
    {
        public void deleteAccount() 
        {
           
                //Delete account:
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Deleted Successfully.";
                Msg.Show();
                Data.Recepients.RemoveAt(Data.LoggedInIndex);
                this.Hide();
                Home myHomeForm = new Home();
                myHomeForm.Show();
                Msg.TopMost = true;
            
        }
        public void deleteAssociatedRequestedSamples() //Delete samples that belong to the user.
        {

            for (int i = 0; i < Data.BloodBank.Count; i++)
            {
                if (Data.BloodBank[i].RecepientIndex == Data.LoggedInIndex)
                {
                    //Remove the sample that belongs to that user.
                    Data.BloodBank.RemoveAt(i);
                }
            }
        
        
        }
        public void displayRequestsHistory()  //Fills the list view with the requests that are requested by the logged in user
        {
            lstviewRequestedSamples.Items.Clear();

            for (int i = 0; i < Data.BloodBank.Count; i++)
            {
                if (Data.BloodBank[i].RecepientIndex == Data.LoggedInIndex) //If the blood sample is requested by the logged in user, display it on the list view.
                {
                    lstviewRequestedSamples.Items.Add(convertBloodToRequestedSamplesListViewItem(Data.BloodBank[i]));
                }
            }
        
        }
        public int getBloodSampleIndexByID(int ID) //(BUG) using binary search because blood samples have sorted IDs.
        {
            int Start = 0, End = Data.BloodBank.Count(), Mid;
            while (Start <= End)
            {
                Mid = (Start + End) / 2;
                if (ID > Data.BloodBank[Mid].ID ) // need to throw away left half
                {
                    Start = Mid + 1;
                }
                else if (ID < Data.BloodBank[Mid].ID) // throw away right half
                {
                    End = Mid - 1;
                }
                else //Found the index of blood sample in the list which matches with the ID in the parameter.
                {
                   return Mid;
                    
                }
            }
            return -1; //failed to find the item.
            
        
        }
        public int getBloodSampleIndexByIDLinear(int ID) //Using linear search.
        {
            for (int i = 0; i < Data.BloodBank.Count; i++)
            {
                if (Data.BloodBank[i].ID == ID)
                {
                    return i;
                }
            }
            return -1; //error


        }

        public void deleteBloodSampleFromHistory() //Removes all selected samples by getting their index in the array list through their ID (Binary search) to delete them by index and finally delete them from the list view.
        {
            if (lstviewRequestedSamples.SelectedItems.Count != 0)
            {
                int IndexToRemove;
                foreach (ListViewItem item in lstviewRequestedSamples.SelectedItems)
                {
                    IndexToRemove = getBloodSampleIndexByID(int.Parse(item.SubItems[0].Text));
                    Data.BloodBank.RemoveAt(IndexToRemove);
                    lstviewRequestedSamples.Items.Remove(item);
                    
                }
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Deleted Successfully.";
                Msg.Show();

            }
            else
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Please select a sample(s) to delete.";
                Msg.Show();
            }
        }
        public ListViewItem convertBloodToSamplesListViewItem(Blood ToConvert) //Takes fields in a blood object and maps them to list view columns
        {

            //The ith index maps to the ith column in the GUI.
            ListViewItem Temp = new ListViewItem(ToConvert.ID.ToString()); //index 0
            Temp.SubItems.Add(ToConvert.BloodType.ToString()); //index 1
            Temp.SubItems.Add(ToConvert.BloodQuantity.ToString()); //index 2
            Temp.SubItems.Add(ToConvert.RecievedDate.ToString());// index 3
            Temp.SubItems.Add(ToConvert.ExpireyDate.ToString()); //index 4
            return Temp;
        }
        public ListViewItem convertBloodToRequestedSamplesListViewItem(Blood ToConvert) //Same as the other one, except hospital is displayed because these requests are requested.
        {
            //The ith index maps to the ith column in the GUI.
            ListViewItem Temp = new ListViewItem(ToConvert.ID.ToString()); //index 0
            Temp.SubItems.Add(ToConvert.BloodType.ToString()); //index 1
            Temp.SubItems.Add(ToConvert.BloodQuantity.ToString()); //index 2
            Temp.SubItems.Add(ToConvert.RecievedDate.ToString());// index 3
            Temp.SubItems.Add(ToConvert.ExpireyDate.ToString()); //index 4
            Temp.SubItems.Add(ToConvert.RecepientHospital); // index 5
            return Temp;
        }
        public ListViewItem convertFromAvailableToAcceptedListViewItem(ListViewItem ToConvert) 
        {
            //converts an item from all samples listviewitem to a request sample listviewitem.
            ListViewItem Temp = new ListViewItem(ToConvert.SubItems[0].Text);
            Temp.SubItems.Add(ToConvert.SubItems[1].Text);
            Temp.SubItems.Add(ToConvert.SubItems[2].Text);
            Temp.SubItems.Add(ToConvert.SubItems[3].Text);
            Temp.SubItems.Add(ToConvert.SubItems[4].Text);
            Temp.SubItems.Add(Data.Recepients[Data.LoggedInIndex].Hospital);
            return Temp;
        }
        public void displayAllSamples() {
            lstviewBloodSamples.Items.Clear();
            for (int i = 0; i < Data.BloodBank.Count; i++)
            {
                if (Data.BloodBank[i].RecepientIndex == -1) //If the blood sample is not requested by anyone (avialable).
                {
                    lstviewBloodSamples.Items.Add(convertBloodToSamplesListViewItem(Data.BloodBank[i]));
                }
               
            }
        }
 
        public void searchBloodType(string Type) //Search by type.
        {
            lstviewBloodSamples.Items.Clear();
            for (int i = 0; i < Data.BloodBank.Count; i++)
            {
                if (Data.BloodBank[i].BloodType.Equals(Type) && Data.BloodBank[i].RecepientIndex == -1) //Filter by type and make sure the sample is available.
                {
                    lstviewBloodSamples.Items.Add(convertBloodToSamplesListViewItem(Data.BloodBank[i]));
                }

            }
        }

        public void makeRequest() //Send a request to the admin.
        {
            if (lstviewBloodSamples.SelectedItems.Count != 0)
            {
                if (chckbxConfirmHospital.Checked)
                {
                     
                    foreach (ListViewItem item in lstviewBloodSamples.SelectedItems)
                    {
                       
                        lstviewRequestedSamples.Items.Add(convertFromAvailableToAcceptedListViewItem(item));
                        Data.BloodBank[getBloodSampleIndexByIDLinear(int.Parse(item.SubItems[0].Text))].RecepientIndex = Data.LoggedInIndex;
                        Data.BloodBank[getBloodSampleIndexByIDLinear(int.Parse(item.SubItems[0].Text))].RecepientHospital = Data.Recepients[Data.LoggedInIndex].Hospital;
                        lstviewBloodSamples.Items.Remove(item);
                        


                    }
                    CustomMessageBox Msg = new CustomMessageBox();
                    Msg.MessageLabel.Text = "Requested Successfully";
                    Msg.Show();
                }
                else
                {
                    CustomMessageBox Msg = new CustomMessageBox();
                    Msg.MessageLabel.Text = "Please confirm your hospital.";
                    Msg.Show();
                }
            }
            else
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Please choose a blood sample(s).";
                Msg.Show();
            }

        }
        public RecepientForm()
        {
            InitializeComponent();
            pnlBloodBank.Hide();
            pnlMySamples.Hide();
            chckbxConfirmHospital.Text = "Confirm Hospital: " + Data.Recepients[Data.LoggedInIndex].Hospital.ToString();
        }

        private void RecepientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home myHomeForm = new Home();
            myHomeForm.Show();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecepientUpdateForm MyRecepientUpdateForm = new RecepientUpdateForm();
            MyRecepientUpdateForm.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            deleteAssociatedRequestedSamples(); //Delete samples first, then delete account.
            deleteAccount();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            searchBloodType("A");
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            searchBloodType("B");
        }

        private void btnAB_Click(object sender, EventArgs e)
        {
            searchBloodType("AB");
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            searchBloodType("O");
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            displayAllSamples();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            makeRequest();
        }

        private void btnDeleteFromHistory_Click(object sender, EventArgs e)
        {
            deleteBloodSampleFromHistory();
        }

        private void btnSwitchSamplesView_Click(object sender, EventArgs e)
        {
            if (btnSwitchSamplesView.Text == "Blood Bank")
            {
                
                pnlBloodBank.Show();
                pnlMySamples.Hide();
                displayAllSamples();
                btnSwitchSamplesView.Text = "My Samples";
            }
            else
            {
                pnlMySamples.Show();
                pnlBloodBank.Hide();
                displayRequestsHistory();
                btnSwitchSamplesView.Text = "Blood Bank";
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
