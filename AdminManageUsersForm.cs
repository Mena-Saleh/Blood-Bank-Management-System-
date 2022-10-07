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
    public partial class AdminManageUsersForm : Form
    {
        bool IsDonor = true;
        public ListViewItem convertUserToListViewItem(Person ToConvert) //Maps a person's fields to list view columns by index.
        {
            ListViewItem Temp = new ListViewItem(ToConvert.ID.ToString()); //index 0
            Temp.SubItems.Add(ToConvert.Name); //index 1
            Temp.SubItems.Add(ToConvert.Mail); //index 2
            return Temp;

        
        }
        public void displayAll() //Displays all users in the arraylists in a list view after converting them to list view items.
        { 
            lstviewUsers.Items.Clear();

            if (IsDonor)
            {
                for (int i = 0; i < Data.Donors.Count; i++)
                {
                    lstviewUsers.Items.Add(convertUserToListViewItem(Data.Donors[i]));
                }
            }
            else
            {
                for (int i = 0; i < Data.Recepients.Count; i++)
                {
                    lstviewUsers.Items.Add(convertUserToListViewItem(Data.Recepients[i]));
                }
            }
        
        }
        public bool markUser() //Stores the index of the marked user in the public Data class to allow modifying it.
            //returns true if a user is marked, otherwise false.
        {

            if (lstviewUsers.SelectedItems.Count == 0) //No user is selected.
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Please select a user.";
                Msg.Show(); ;
                return false;
            }
            else
            {
                Data.MarkedByAdminIndex = int.Parse(lstviewUsers.SelectedItems[0].Index.ToString());
                //Takes the text in the ID coloumn of the selected item in the list and parses into int to store it in the Data class.
                return true;
            }
        }
        public void updateUser() 
        {
            if (markUser())
            {
                //Go to update form.
                if (IsDonor)
                {
                    
                    this.Hide();
                    DonorUpdateForm MyDonorUpdateForm = new DonorUpdateForm();
                    MyDonorUpdateForm.Show();
                }
                else
                {

                    this.Hide();
                    RecepientUpdateForm MyRecpeintUpdateForm = new RecepientUpdateForm();
                    MyRecpeintUpdateForm.Show();

                }
            }
           
           
        
        }

        public void deleteAssociatedRequestedSamples() //Delete all samples that are linked with that recepient before deleting their account. 
        {
            if (markUser())
            {
                for (int i = 0; i < Data.BloodBank.Count; i++)
                {
                    if (Data.BloodBank[i].RecepientIndex == Data.MarkedByAdminIndex)
                    {
                        //Remove the sample that belongs to that user.
                        Data.BloodBank.RemoveAt(i);
                    }
                }
            }
           

        }
      

        public void deleteUser() {

            if (markUser()) //If the admin marked a user to delete.
            {
                
               if (IsDonor) //Delete Donor
               {
                   Data.deleteDonorRequests(); //Remove all requests sent by this donor, or any requests accepted by the admin to this donor.
                   Data.Donors.RemoveAt(Data.MarkedByAdminIndex); //Remove the donor from the array list.
                   displayAll(); //Refresh to show changes
               }
               else //Delete Recepient
               {

                   Data.Recepients.RemoveAt(Data.MarkedByAdminIndex); //Remove the recepient from the array list.
                   displayAll(); //Refresh to show changes
               }
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Deleted Successfully.";
                Msg.Show();

            }
           

        }
        public AdminManageUsersForm()
        {
            InitializeComponent();
            btnDonors.BackColor = Color.FromArgb(242, 84, 91);
            displayAll();
        }

        private void btnDonors_Click(object sender, EventArgs e)
        {
            btnDonors.BackColor = Color.FromArgb(242, 84, 91);
            btnRecievers.BackColor = Color.FromArgb(42, 84, 101);
            IsDonor = true;
            displayAll();

        }

        private void btnRecepients_Click(object sender, EventArgs e)
        {
            btnDonors.BackColor = Color.FromArgb(42, 84, 101);
            btnRecievers.BackColor = Color.FromArgb(242, 84, 91);
            IsDonor = false;
            displayAll();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm MyAdminForm = new AdminForm();
            MyAdminForm.Show();
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            displayAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteAssociatedRequestedSamples(); //Delete associated samples first.
            deleteUser();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm MyRegisterForm = new RegisterForm();
            MyRegisterForm.Show();

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

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
