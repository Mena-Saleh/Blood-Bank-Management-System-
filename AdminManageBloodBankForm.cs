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

    public partial class AdminManageBloodBankForm : Form
    {
        public bool isFilled() //Checks if all required fields are filled correctly
        {

            if (cmbobxBloodAmount.SelectedIndex != -1 && cmbobxBloodType.SelectedIndex != -1 && mnthcalExpireyDate.SelectionStart != DateTime.MinValue && mnthcalRecievedDate.SelectionStart != DateTime.MinValue)
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
        }
        public bool isSelected() //Checks if there are any selected samples.
        {
            return lstviewBloodSamples.SelectedItems.Count != 0;
        }
        public void deleteSample() {

            if (isSelected())
            {
                Data.BloodBank.RemoveAt(getBloodSampleIndexByIDLinear(int.Parse(lstviewBloodSamples.SelectedItems[0].SubItems[0].Text)));
                /*Data.BloodBank.RemoveAt(lstviewBloodSamples.SelectedItems[0].Index); */// remove the selected item from Data BloodBank by index.
                lstviewBloodSamples.SelectedItems[0].Remove();
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Deleted Successfully.";
                Msg.Show();
            }
            else
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Please a sample(s).";
                Msg.Show(); ;
            }
        
        }
        public void fillGUIWithUpdateData() //Load the attributes of the selected item into the GUI after showing the panel.
        {
            if (isSelected())
            {
                pnlUpdateOrInsert.Show();
                pnlBloodBank.Hide();
                btnUpdateOrInsert.Text = "Update";
                cmbobxBloodType.SelectedItem = lstviewBloodSamples.SelectedItems[0].SubItems[1].Text;
                cmbobxBloodAmount.SelectedItem = lstviewBloodSamples.SelectedItems[0].SubItems[2].Text;
                mnthcalRecievedDate.SelectionStart = DateTime.Parse(lstviewBloodSamples.SelectedItems[0].SubItems[3].Text);
                mnthcalExpireyDate.SelectionStart = DateTime.Parse(lstviewBloodSamples.SelectedItems[0].SubItems[4].Text);


            }
            else
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Please select a sample(s).";
                Msg.Show();
            }
         
        } 
        public void fillGUIWithInsertDate() //Shows insert panel and makes all controls inside it empty.
        {
            pnlUpdateOrInsert.Show();
            pnlBloodBank.Hide();
            btnUpdateOrInsert.Text = "Insert";
            cmbobxBloodType.SelectedIndex = -1;
            cmbobxBloodAmount.SelectedIndex = -1;
            mnthcalRecievedDate.SelectionStart = DateTime.Now;
            mnthcalExpireyDate.SelectionStart = DateTime.Now;

        }
        public Blood createBloodSampleFromGUIControls() //Takes data (text and dates) from GUI and maps them to a blood object.
        {

            Blood Temp = new Blood(Blood.IDCounter,
                    cmbobxBloodType.SelectedItem.ToString(),
                    DateTime.Parse(mnthcalRecievedDate.SelectionStart.ToString()),
                    DateTime.Parse(mnthcalExpireyDate.SelectionStart.ToString()),
                    float.Parse(cmbobxBloodAmount.SelectedItem.ToString())
                    );
            Blood.IDCounter++;

            return Temp;
        }
        public void updateSample() //Remove the sample at the current index and create the updated one and put it in its place.
        {
            int Temp = getBloodSampleIndexByIDLinear(int.Parse(lstviewBloodSamples.SelectedItems[0].SubItems[0].Text));
            Data.BloodBank.RemoveAt(Temp); //Remove old sample.
            Data.BloodBank.Insert(Temp, createBloodSampleFromGUIControls()); // Add new sample.
            CustomMessageBox Msg = new CustomMessageBox();
            Msg.MessageLabel.Text = "Updated Successfully.";
            Msg.Show();
            pnlUpdateOrInsert.Hide();
            pnlBloodBank.Show();
            displayAllSamples();
            Msg.TopMost = true;
        }
        public void InsertSample() //Creates a sample from controls' input values and adds it to the blood bank array list in Data, then refreshes to display changes.
        {
            Data.BloodBank.Add(createBloodSampleFromGUIControls());
            CustomMessageBox Msg = new CustomMessageBox();
            Msg.MessageLabel.Text = "Inserted Successfully";
            Msg.Show();
            pnlUpdateOrInsert.Hide();
            pnlBloodBank.Show();
            displayAllSamples();
            Msg.TopMost = true;
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


        public ListViewItem convertBloodToListViewItem(Blood ToConvert) //Takes a blood object and maps its fields to list view columns to make a list view item.
        {

            ListViewItem Temp = new ListViewItem(ToConvert.ID.ToString()); //index 0
            Temp.SubItems.Add(ToConvert.BloodType.ToString()); //index 1
            Temp.SubItems.Add(ToConvert.BloodQuantity.ToString()); //index 2
            Temp.SubItems.Add(ToConvert.RecievedDate.ToString());// index 3
            Temp.SubItems.Add(ToConvert.ExpireyDate.ToString()); //index 4
            return Temp;
        }
        public void displayAllSamples() //Converts all items in Blood array list to list view items to display them.
        {
            lstviewBloodSamples.Items.Clear();
            for (int i = 0; i < Data.BloodBank.Count; i++)
            {
                if (Data.BloodBank[i].RecepientIndex == -1) //Display only unassigned.
                {
                    lstviewBloodSamples.Items.Add(convertBloodToListViewItem(Data.BloodBank[i]));
                }
                
            }
        }

        public AdminManageBloodBankForm()
        {
            InitializeComponent();
            pnlUpdateOrInsert.Hide();
            displayAllSamples();
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            displayAllSamples();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            fillGUIWithUpdateData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteSample();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            fillGUIWithInsertDate();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm MyAdminForm = new AdminForm();
            MyAdminForm.Show();
        }

      
       

        private void btnUpdateOrInsert_Click(object sender, EventArgs e)
        {
            if (isFilled()) 
            {
                // update the sample if the button is in update state, otherwise insert.
                if (btnUpdateOrInsert.Text == "Update")
                {
                    updateSample();

                }
                else
                {
                    InsertSample();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateOrInsert.Hide();
            pnlBloodBank.Show();
        }
    }
}
