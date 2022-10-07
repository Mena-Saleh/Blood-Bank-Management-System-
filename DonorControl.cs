using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class DonorControl : UserControl
    {
        public DonorControl()
        {
            InitializeComponent();
        }

        //Properties
        public MonthCalendar calDateOfLastDonationProperty
        {
            get{ return calDateOfLastDonation; }
            set{ calDateOfLastDonation = value; }

        }
        public RichTextBox rchtxtbxOtherDiseaseProperty
        {
            get { return rchtxtbxOtherDisease; }
            set { rchtxtbxOtherDisease = value; }
        
        }
        public CheckBox chckbxBloodPressureDisordersProperty {

            set { chckbxBloodPressureDisorders = value; }
            get { return chckbxBloodPressureDisorders; }
        }
        public CheckBox chckbxThyroidDiseaseProperty
        {

            set { chckbxThyroidDisease = value; }
            get { return chckbxThyroidDisease; }
        }
        public CheckBox chckbxDiabetesProperty
        {

            set { chckbxDiabetes = value; }
            get { return chckbxDiabetes; }
        }
        public CheckBox chckbxCancerProperty
        {

            set { chckbxCancer = value; }
            get { return chckbxCancer; }
        }
        public CheckBox chckbxHeartDisordersProperty
        {

            set { chckbxHeartDisorders = value; }
            get { return chckbxHeartDisorders; }
        }
        public CheckBox chckbxHepatitisProperty
        {

            set { chckbxHepatitis = value; }
            get { return chckbxHepatitis; }
        }
        public CheckBox chckbxNewDonorProperty
        {

            set { chckbxNewDonor = value; }
            get { return chckbxNewDonor; }
        }

        private void chckbxNewDonor_CheckedChanged(object sender, EventArgs e)
        {
            if (chckbxNewDonor.Checked)
            {
                lblDateOfLastDonation.Text = "";
                calDateOfLastDonation.Visible = false;
                calDateOfLastDonation.IsAccessible = false;
            }
            else
            {
                lblDateOfLastDonation.Text = "Date Of Last Donation";
                calDateOfLastDonation.Visible = true;
                calDateOfLastDonation.IsAccessible = true;
            }
        }

 
    }
}
