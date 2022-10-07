
namespace Blood_Bank_Management_System
{
    partial class RecepientUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepientUpdateForm));
            this.btnGoBack = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.cmbobxBloodType = new System.Windows.Forms.ComboBox();
            this.rdiobtnFemale = new System.Windows.Forms.RadioButton();
            this.rdiobtnMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.txtbxMail = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.recepientControl1 = new Blood_Bank_Management_System.RecepientControl();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExitTop = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.btnGoBack.FlatAppearance.BorderSize = 0;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnGoBack.Image = global::Blood_Bank_Management_System.Properties.Resources.angle_small_left;
            this.btnGoBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoBack.Location = new System.Drawing.Point(1, 676);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(181, 57);
            this.btnGoBack.TabIndex = 2;
            this.btnGoBack.Text = "Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.btnUpdateAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnUpdateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccount.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnUpdateAccount.Location = new System.Drawing.Point(1131, 699);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(181, 57);
            this.btnUpdateAccount.TabIndex = 55;
            this.btnUpdateAccount.Text = "Update Account";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.BackColor = System.Drawing.Color.Transparent;
            this.lblBloodType.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBloodType.Location = new System.Drawing.Point(310, 251);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(97, 15);
            this.lblBloodType.TabIndex = 70;
            this.lblBloodType.Text = "Blood Type";
            // 
            // cmbobxBloodType
            // 
            this.cmbobxBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbobxBloodType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbobxBloodType.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbobxBloodType.FormattingEnabled = true;
            this.cmbobxBloodType.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "O"});
            this.cmbobxBloodType.Location = new System.Drawing.Point(481, 249);
            this.cmbobxBloodType.Name = "cmbobxBloodType";
            this.cmbobxBloodType.Size = new System.Drawing.Size(175, 23);
            this.cmbobxBloodType.TabIndex = 69;
            // 
            // rdiobtnFemale
            // 
            this.rdiobtnFemale.AutoSize = true;
            this.rdiobtnFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdiobtnFemale.Checked = true;
            this.rdiobtnFemale.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdiobtnFemale.Location = new System.Drawing.Point(1002, 198);
            this.rdiobtnFemale.Name = "rdiobtnFemale";
            this.rdiobtnFemale.Size = new System.Drawing.Size(82, 19);
            this.rdiobtnFemale.TabIndex = 68;
            this.rdiobtnFemale.TabStop = true;
            this.rdiobtnFemale.Text = "Female";
            this.rdiobtnFemale.UseVisualStyleBackColor = false;
            // 
            // rdiobtnMale
            // 
            this.rdiobtnMale.AutoSize = true;
            this.rdiobtnMale.BackColor = System.Drawing.Color.Transparent;
            this.rdiobtnMale.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdiobtnMale.Location = new System.Drawing.Point(916, 198);
            this.rdiobtnMale.Name = "rdiobtnMale";
            this.rdiobtnMale.Size = new System.Drawing.Size(64, 19);
            this.rdiobtnMale.TabIndex = 67;
            this.rdiobtnMale.TabStop = true;
            this.rdiobtnMale.Text = "Male";
            this.rdiobtnMale.UseVisualStyleBackColor = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(830, 200);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 15);
            this.lblGender.TabIndex = 66;
            this.lblGender.Text = "Gender";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmPassword.Location = new System.Drawing.Point(310, 198);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(151, 15);
            this.lblConfirmPassword.TabIndex = 65;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtbxConfirmPassword
            // 
            this.txtbxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxConfirmPassword.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxConfirmPassword.Location = new System.Drawing.Point(481, 191);
            this.txtbxConfirmPassword.Name = "txtbxConfirmPassword";
            this.txtbxConfirmPassword.PasswordChar = '*';
            this.txtbxConfirmPassword.Size = new System.Drawing.Size(175, 22);
            this.txtbxConfirmPassword.TabIndex = 64;
            this.txtbxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.Location = new System.Drawing.Point(830, 144);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(34, 15);
            this.lblAge.TabIndex = 63;
            this.lblAge.Text = "Age";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(310, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 15);
            this.lblPassword.TabIndex = 62;
            this.lblPassword.Text = "Password";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMail.Location = new System.Drawing.Point(830, 86);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(43, 15);
            this.lblMail.TabIndex = 61;
            this.lblMail.Text = "Mail";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(310, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 15);
            this.lblName.TabIndex = 60;
            this.lblName.Text = "Name";
            // 
            // txtbxAge
            // 
            this.txtbxAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxAge.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxAge.Location = new System.Drawing.Point(904, 141);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.Size = new System.Drawing.Size(50, 22);
            this.txtbxAge.TabIndex = 59;
            // 
            // txtbxMail
            // 
            this.txtbxMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxMail.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxMail.Location = new System.Drawing.Point(904, 86);
            this.txtbxMail.Name = "txtbxMail";
            this.txtbxMail.Size = new System.Drawing.Size(207, 22);
            this.txtbxMail.TabIndex = 58;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxPassword.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxPassword.Location = new System.Drawing.Point(481, 135);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '*';
            this.txtbxPassword.Size = new System.Drawing.Size(175, 22);
            this.txtbxPassword.TabIndex = 57;
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // txtbxName
            // 
            this.txtbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxName.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxName.Location = new System.Drawing.Point(481, 84);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(175, 22);
            this.txtbxName.TabIndex = 56;
            // 
            // recepientControl1
            // 
            this.recepientControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.recepientControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recepientControl1.Location = new System.Drawing.Point(404, 378);
            this.recepientControl1.Name = "recepientControl1";
            this.recepientControl1.Size = new System.Drawing.Size(576, 166);
            this.recepientControl1.TabIndex = 71;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Controls.Add(this.btnGoBack);
            this.pnlMenu.Location = new System.Drawing.Point(-1, 23);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(182, 791);
            this.pnlMenu.TabIndex = 72;
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
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.pnlTitleBar.Controls.Add(this.lblFormName);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnExitTop);
            this.pnlTitleBar.Location = new System.Drawing.Point(-3, -15);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1397, 41);
            this.pnlTitleBar.TabIndex = 73;
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblFormName.Location = new System.Drawing.Point(16, 19);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(168, 17);
            this.lblFormName.TabIndex = 8;
            this.lblFormName.Text = "Recepient Update";
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
            // RecepientUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.blur_back1;
            this.ClientSize = new System.Drawing.Size(1350, 813);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.recepientControl1);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.cmbobxBloodType);
            this.Controls.Add(this.rdiobtnFemale);
            this.Controls.Add(this.rdiobtnMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtbxConfirmPassword);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtbxAge);
            this.Controls.Add(this.txtbxMail);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.btnUpdateAccount);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecepientUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecepientUpdateForm";
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.ComboBox cmbobxBloodType;
        private System.Windows.Forms.RadioButton rdiobtnFemale;
        private System.Windows.Forms.RadioButton rdiobtnMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtbxConfirmPassword;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.TextBox txtbxMail;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.TextBox txtbxName;
        private RecepientControl recepientControl1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExitTop;
    }
}