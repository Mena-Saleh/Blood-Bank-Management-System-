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
    public partial class AdminCredentialsControl : UserControl
    {
        public bool isFilled() {
            if (txtbxMail.Text != "" && txtbxPassword.Text != "" && txtbxConfirmPassword.Text != "") //nothing is empty (everything filled)
            {
                return true;
            }
            else
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Please fill all necessary fields.";
                Msg.Show(); ;
                return false;
            }
        }
        public bool isMatchedPasswords() {

            if (txtbxConfirmPassword.Text.Equals(txtbxPassword.Text))
            {
                return true;
            }
            else
            {
                CustomMessageBox Msg = new CustomMessageBox();
                Msg.MessageLabel.Text = "Passwords do not match.";
                Msg.Show(); ;
                return false;
            }
        }
        public AdminCredentialsControl()
        {
            InitializeComponent();
        }

        public TextBox txtbxMailProperty {
            get { return this.txtbxMail; }
            set { this.txtbxMail = value; }
        }

        public TextBox txtbxPasswordProperty
        {
            get { return this.txtbxPassword; }
            set { this.txtbxPassword = value; }
        }
        public TextBox txtbxConfirmPasswordProperty
        {
            get { return this.txtbxConfirmPassword; }
            set { this.txtbxConfirmPassword = value; }
        }

        public Button btnUpdateProperty
        {
            get { return this.btnUpdate; }
            set { this.btnUpdate = value; }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                if (isMatchedPasswords())
                {
                    Data.AdminMail = txtbxMail.Text;
                    Data.AdminPassword = txtbxPassword.Text;
                    CustomMessageBox Msg = new CustomMessageBox();
                    Msg.MessageLabel.Text = "Updated Successfully.";
                    Msg.Show();
                }
            }
        }
    }
}
