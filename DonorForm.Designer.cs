
namespace Blood_Bank_Management_System
{
    partial class DonorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorForm));
            this.btnDonate = new System.Windows.Forms.Button();
            this.cmbobxBloodAmount = new System.Windows.Forms.ComboBox();
            this.lblmg = new System.Windows.Forms.Label();
            this.lblBloodAmount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAcceptedRequests = new System.Windows.Forms.Label();
            this.pnlAcceptedRequests = new System.Windows.Forms.Panel();
            this.lblRemainingRequests = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDonateNow = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExitTop = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnlAcceptedRequests.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDonate
            // 
            this.btnDonate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.btnDonate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnDonate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonate.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDonate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnDonate.Location = new System.Drawing.Point(168, 98);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(223, 57);
            this.btnDonate.TabIndex = 5;
            this.btnDonate.Text = "Make a Donation Request";
            this.btnDonate.UseVisualStyleBackColor = false;
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // cmbobxBloodAmount
            // 
            this.cmbobxBloodAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbobxBloodAmount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbobxBloodAmount.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbobxBloodAmount.FormattingEnabled = true;
            this.cmbobxBloodAmount.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200",
            "250",
            "300",
            "350",
            "400",
            "450",
            "500"});
            this.cmbobxBloodAmount.Location = new System.Drawing.Point(168, 46);
            this.cmbobxBloodAmount.Name = "cmbobxBloodAmount";
            this.cmbobxBloodAmount.Size = new System.Drawing.Size(151, 23);
            this.cmbobxBloodAmount.TabIndex = 12;
            // 
            // lblmg
            // 
            this.lblmg.AutoSize = true;
            this.lblmg.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmg.Location = new System.Drawing.Point(346, 54);
            this.lblmg.Name = "lblmg";
            this.lblmg.Size = new System.Drawing.Size(25, 15);
            this.lblmg.TabIndex = 11;
            this.lblmg.Text = "mg";
            // 
            // lblBloodAmount
            // 
            this.lblBloodAmount.AutoSize = true;
            this.lblBloodAmount.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBloodAmount.Location = new System.Drawing.Point(19, 49);
            this.lblBloodAmount.Name = "lblBloodAmount";
            this.lblBloodAmount.Size = new System.Drawing.Size(133, 15);
            this.lblBloodAmount.TabIndex = 10;
            this.lblBloodAmount.Text = "Blood Quantity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbobxBloodAmount);
            this.panel2.Controls.Add(this.btnDonate);
            this.panel2.Controls.Add(this.lblBloodAmount);
            this.panel2.Controls.Add(this.lblmg);
            this.panel2.Location = new System.Drawing.Point(386, 331);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 177);
            this.panel2.TabIndex = 13;
            // 
            // lblAcceptedRequests
            // 
            this.lblAcceptedRequests.AutoSize = true;
            this.lblAcceptedRequests.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAcceptedRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblAcceptedRequests.Location = new System.Drawing.Point(5, 27);
            this.lblAcceptedRequests.Name = "lblAcceptedRequests";
            this.lblAcceptedRequests.Size = new System.Drawing.Size(249, 20);
            this.lblAcceptedRequests.TabIndex = 14;
            this.lblAcceptedRequests.Text = "My Accepted Requests";
            // 
            // pnlAcceptedRequests
            // 
            this.pnlAcceptedRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(94)))), ((int)(((byte)(88)))));
            this.pnlAcceptedRequests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAcceptedRequests.Controls.Add(this.lblRemainingRequests);
            this.pnlAcceptedRequests.Controls.Add(this.btnCancel);
            this.pnlAcceptedRequests.Controls.Add(this.btnDonateNow);
            this.pnlAcceptedRequests.Controls.Add(this.lblQuantity);
            this.pnlAcceptedRequests.Controls.Add(this.lblDate);
            this.pnlAcceptedRequests.Controls.Add(this.lblAcceptedRequests);
            this.pnlAcceptedRequests.Location = new System.Drawing.Point(972, 25);
            this.pnlAcceptedRequests.Name = "pnlAcceptedRequests";
            this.pnlAcceptedRequests.Size = new System.Drawing.Size(381, 1033);
            this.pnlAcceptedRequests.TabIndex = 15;
            // 
            // lblRemainingRequests
            // 
            this.lblRemainingRequests.AutoSize = true;
            this.lblRemainingRequests.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemainingRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblRemainingRequests.Location = new System.Drawing.Point(152, 763);
            this.lblRemainingRequests.Name = "lblRemainingRequests";
            this.lblRemainingRequests.Size = new System.Drawing.Size(178, 15);
            this.lblRemainingRequests.TabIndex = 19;
            this.lblRemainingRequests.Text = "Remaining Requests:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnCancel.Location = new System.Drawing.Point(196, 261);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 57);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDonateNow
            // 
            this.btnDonateNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.btnDonateNow.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnDonateNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonateNow.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDonateNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnDonateNow.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDonateNow.Location = new System.Drawing.Point(26, 261);
            this.btnDonateNow.Name = "btnDonateNow";
            this.btnDonateNow.Size = new System.Drawing.Size(150, 57);
            this.btnDonateNow.TabIndex = 17;
            this.btnDonateNow.Text = "Donate Now";
            this.btnDonateNow.UseVisualStyleBackColor = false;
            this.btnDonateNow.Click += new System.EventHandler(this.btnDonateNow_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblQuantity.Location = new System.Drawing.Point(5, 161);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 13);
            this.lblQuantity.TabIndex = 16;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblDate.Location = new System.Drawing.Point(5, 105);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 13);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Sent on";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.pnlMenu.Controls.Add(this.btnSignOut);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Controls.Add(this.btnUpdateAccount);
            this.pnlMenu.Controls.Add(this.btnDeleteAccount);
            this.pnlMenu.Location = new System.Drawing.Point(-1, 23);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(182, 791);
            this.pnlMenu.TabIndex = 26;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnSignOut.Image = global::Blood_Bank_Management_System.Properties.Resources.sign_out;
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(1, 676);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(181, 57);
            this.btnSignOut.TabIndex = 2;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click_1);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.Logo;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(14, 21);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(141, 120);
            this.pnlLogo.TabIndex = 7;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.btnUpdateAccount.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccount.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnUpdateAccount.Image = global::Blood_Bank_Management_System.Properties.Resources.refresh;
            this.btnUpdateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAccount.Location = new System.Drawing.Point(1, 200);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(181, 57);
            this.btnUpdateAccount.TabIndex = 3;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click_1);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnDeleteAccount.Image = global::Blood_Bank_Management_System.Properties.Resources.trash;
            this.btnDeleteAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAccount.Location = new System.Drawing.Point(1, 264);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(181, 57);
            this.btnDeleteAccount.TabIndex = 4;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click_1);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.pnlTitleBar.Controls.Add(this.lblFormName);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnExitTop);
            this.pnlTitleBar.Location = new System.Drawing.Point(-3, -15);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1397, 41);
            this.pnlTitleBar.TabIndex = 27;
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblFormName.Location = new System.Drawing.Point(16, 19);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(58, 17);
            this.lblFormName.TabIndex = 8;
            this.lblFormName.Text = "Donor";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(226)))), ((int)(((byte)(202)))));
            this.btnMinimize.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.Minimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(1296, 18);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(19, 18);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExitTop
            // 
            this.btnExitTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.btnExitTop.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.cross;
            this.btnExitTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitTop.FlatAppearance.BorderSize = 0;
            this.btnExitTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitTop.ForeColor = System.Drawing.Color.Black;
            this.btnExitTop.Location = new System.Drawing.Point(1326, 18);
            this.btnExitTop.Name = "btnExitTop";
            this.btnExitTop.Size = new System.Drawing.Size(19, 18);
            this.btnExitTop.TabIndex = 8;
            this.btnExitTop.UseVisualStyleBackColor = false;
            this.btnExitTop.Click += new System.EventHandler(this.btnExitTop_Click);
            // 
            // DonorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.blur_back1;
            this.ClientSize = new System.Drawing.Size(1350, 813);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlAcceptedRequests);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DonorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonorForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAcceptedRequests.ResumeLayout(false);
            this.pnlAcceptedRequests.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.ComboBox cmbobxBloodAmount;
        private System.Windows.Forms.Label lblmg;
        private System.Windows.Forms.Label lblBloodAmount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAcceptedRequests;
        private System.Windows.Forms.Panel pnlAcceptedRequests;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDonateNow;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExitTop;
        private System.Windows.Forms.Label lblRemainingRequests;
    }
}