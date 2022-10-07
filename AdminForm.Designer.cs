
namespace Blood_Bank_Management_System
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.btnManageBloodBank = new System.Windows.Forms.Button();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlRequestApproval = new System.Windows.Forms.Panel();
            this.lblRequestsCount = new System.Windows.Forms.Label();
            this.lblml = new System.Windows.Forms.Label();
            this.lblRequests = new System.Windows.Forms.Label();
            this.txtbxQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnRefuseRequest = new System.Windows.Forms.Button();
            this.btnAcceptRequest = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDiseases = new System.Windows.Forms.Label();
            this.chckbxBloodPressureDisorders = new System.Windows.Forms.CheckBox();
            this.chckbxThyroidDisease = new System.Windows.Forms.CheckBox();
            this.chckbxDiabetes = new System.Windows.Forms.CheckBox();
            this.chckbxHepatitis = new System.Windows.Forms.CheckBox();
            this.chckbxCancer = new System.Windows.Forms.CheckBox();
            this.chckbxHeartDisorders = new System.Windows.Forms.CheckBox();
            this.rchtxtbxOtherDisease = new System.Windows.Forms.RichTextBox();
            this.lblOtherDisease = new System.Windows.Forms.Label();
            this.lblDaysFromLastDonation = new System.Windows.Forms.Label();
            this.txtbxLastDonationDate = new System.Windows.Forms.TextBox();
            this.lblLastDonationDate = new System.Windows.Forms.Label();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.adminCredentialsControl1 = new Blood_Bank_Management_System.AdminCredentialsControl();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExitTop = new System.Windows.Forms.Button();
            this.pnlRequestApproval.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageBloodBank
            // 
            this.btnManageBloodBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.btnManageBloodBank.FlatAppearance.BorderSize = 0;
            this.btnManageBloodBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBloodBank.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageBloodBank.Image = global::Blood_Bank_Management_System.Properties.Resources.blood;
            this.btnManageBloodBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBloodBank.Location = new System.Drawing.Point(1, 328);
            this.btnManageBloodBank.Name = "btnManageBloodBank";
            this.btnManageBloodBank.Size = new System.Drawing.Size(181, 57);
            this.btnManageBloodBank.TabIndex = 6;
            this.btnManageBloodBank.Text = "Blood Bank";
            this.btnManageBloodBank.UseVisualStyleBackColor = false;
            this.btnManageBloodBank.Click += new System.EventHandler(this.btnManageBloodBank_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.btnUpdateAdmin.FlatAppearance.BorderSize = 0;
            this.btnUpdateAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAdmin.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateAdmin.Image = global::Blood_Bank_Management_System.Properties.Resources.refresh;
            this.btnUpdateAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAdmin.Location = new System.Drawing.Point(1, 200);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(181, 57);
            this.btnUpdateAdmin.TabIndex = 5;
            this.btnUpdateAdmin.Text = "Update";
            this.btnUpdateAdmin.UseVisualStyleBackColor = false;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.btnManageUsers.FlatAppearance.BorderSize = 0;
            this.btnManageUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageUsers.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageUsers.Image = global::Blood_Bank_Management_System.Properties.Resources.users;
            this.btnManageUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUsers.Location = new System.Drawing.Point(1, 264);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(181, 57);
            this.btnManageUsers.TabIndex = 4;
            this.btnManageUsers.Text = "Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignOut.Image = global::Blood_Bank_Management_System.Properties.Resources.angle_small_left;
            this.btnSignOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.Location = new System.Drawing.Point(1, 676);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(181, 57);
            this.btnSignOut.TabIndex = 2;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // pnlRequestApproval
            // 
            this.pnlRequestApproval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(94)))), ((int)(((byte)(88)))));
            this.pnlRequestApproval.Controls.Add(this.lblRequestsCount);
            this.pnlRequestApproval.Controls.Add(this.lblml);
            this.pnlRequestApproval.Controls.Add(this.lblRequests);
            this.pnlRequestApproval.Controls.Add(this.txtbxQuantity);
            this.pnlRequestApproval.Controls.Add(this.lblQuantity);
            this.pnlRequestApproval.Controls.Add(this.btnRefuseRequest);
            this.pnlRequestApproval.Controls.Add(this.btnAcceptRequest);
            this.pnlRequestApproval.Controls.Add(this.panel3);
            this.pnlRequestApproval.Controls.Add(this.rchtxtbxOtherDisease);
            this.pnlRequestApproval.Controls.Add(this.lblOtherDisease);
            this.pnlRequestApproval.Controls.Add(this.lblDaysFromLastDonation);
            this.pnlRequestApproval.Controls.Add(this.txtbxLastDonationDate);
            this.pnlRequestApproval.Controls.Add(this.lblLastDonationDate);
            this.pnlRequestApproval.Controls.Add(this.txtbxAge);
            this.pnlRequestApproval.Controls.Add(this.lblAge);
            this.pnlRequestApproval.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlRequestApproval.Location = new System.Drawing.Point(849, 26);
            this.pnlRequestApproval.Name = "pnlRequestApproval";
            this.pnlRequestApproval.Size = new System.Drawing.Size(1040, 1037);
            this.pnlRequestApproval.TabIndex = 3;
            // 
            // lblRequestsCount
            // 
            this.lblRequestsCount.AutoSize = true;
            this.lblRequestsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblRequestsCount.Location = new System.Drawing.Point(297, 763);
            this.lblRequestsCount.Name = "lblRequestsCount";
            this.lblRequestsCount.Size = new System.Drawing.Size(196, 15);
            this.lblRequestsCount.TabIndex = 31;
            this.lblRequestsCount.Text = "Remaining Requests: 0";
            // 
            // lblml
            // 
            this.lblml.AutoSize = true;
            this.lblml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblml.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblml.Location = new System.Drawing.Point(308, 75);
            this.lblml.Name = "lblml";
            this.lblml.Size = new System.Drawing.Size(25, 15);
            this.lblml.TabIndex = 30;
            this.lblml.Text = "ml";
            // 
            // lblRequests
            // 
            this.lblRequests.AutoSize = true;
            this.lblRequests.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRequests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblRequests.Location = new System.Drawing.Point(15, 9);
            this.lblRequests.Name = "lblRequests";
            this.lblRequests.Size = new System.Drawing.Size(213, 20);
            this.lblRequests.TabIndex = 4;
            this.lblRequests.Text = "Requests Approval";
            // 
            // txtbxQuantity
            // 
            this.txtbxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxQuantity.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxQuantity.Location = new System.Drawing.Point(189, 75);
            this.txtbxQuantity.Name = "txtbxQuantity";
            this.txtbxQuantity.ReadOnly = true;
            this.txtbxQuantity.Size = new System.Drawing.Size(94, 20);
            this.txtbxQuantity.TabIndex = 29;
            this.txtbxQuantity.TabStop = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblQuantity.Location = new System.Drawing.Point(24, 75);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(71, 13);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnRefuseRequest
            // 
            this.btnRefuseRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.btnRefuseRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnRefuseRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefuseRequest.Location = new System.Drawing.Point(262, 673);
            this.btnRefuseRequest.Name = "btnRefuseRequest";
            this.btnRefuseRequest.Size = new System.Drawing.Size(150, 57);
            this.btnRefuseRequest.TabIndex = 27;
            this.btnRefuseRequest.Text = "Refuse";
            this.btnRefuseRequest.UseVisualStyleBackColor = false;
            this.btnRefuseRequest.Click += new System.EventHandler(this.btnRefuseRequest_Click);
            // 
            // btnAcceptRequest
            // 
            this.btnAcceptRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.btnAcceptRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnAcceptRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptRequest.Location = new System.Drawing.Point(61, 673);
            this.btnAcceptRequest.Name = "btnAcceptRequest";
            this.btnAcceptRequest.Size = new System.Drawing.Size(150, 57);
            this.btnAcceptRequest.TabIndex = 26;
            this.btnAcceptRequest.Text = "Accept";
            this.btnAcceptRequest.UseVisualStyleBackColor = false;
            this.btnAcceptRequest.Click += new System.EventHandler(this.btnAcceptRequest_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblDiseases);
            this.panel3.Controls.Add(this.chckbxBloodPressureDisorders);
            this.panel3.Controls.Add(this.chckbxThyroidDisease);
            this.panel3.Controls.Add(this.chckbxDiabetes);
            this.panel3.Controls.Add(this.chckbxHepatitis);
            this.panel3.Controls.Add(this.chckbxCancer);
            this.panel3.Controls.Add(this.chckbxHeartDisorders);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(15, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 222);
            this.panel3.TabIndex = 25;
            // 
            // lblDiseases
            // 
            this.lblDiseases.AutoSize = true;
            this.lblDiseases.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiseases.ForeColor = System.Drawing.Color.Black;
            this.lblDiseases.Location = new System.Drawing.Point(3, 3);
            this.lblDiseases.Name = "lblDiseases";
            this.lblDiseases.Size = new System.Drawing.Size(71, 13);
            this.lblDiseases.TabIndex = 24;
            this.lblDiseases.Text = "Disease:";
            // 
            // chckbxBloodPressureDisorders
            // 
            this.chckbxBloodPressureDisorders.AutoCheck = false;
            this.chckbxBloodPressureDisorders.AutoSize = true;
            this.chckbxBloodPressureDisorders.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chckbxBloodPressureDisorders.ForeColor = System.Drawing.Color.Black;
            this.chckbxBloodPressureDisorders.Location = new System.Drawing.Point(14, 34);
            this.chckbxBloodPressureDisorders.Name = "chckbxBloodPressureDisorders";
            this.chckbxBloodPressureDisorders.Size = new System.Drawing.Size(221, 17);
            this.chckbxBloodPressureDisorders.TabIndex = 16;
            this.chckbxBloodPressureDisorders.Text = "Blood Pressure Disorders";
            this.chckbxBloodPressureDisorders.UseVisualStyleBackColor = true;
            // 
            // chckbxThyroidDisease
            // 
            this.chckbxThyroidDisease.AutoCheck = false;
            this.chckbxThyroidDisease.AutoSize = true;
            this.chckbxThyroidDisease.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chckbxThyroidDisease.ForeColor = System.Drawing.Color.Black;
            this.chckbxThyroidDisease.Location = new System.Drawing.Point(14, 63);
            this.chckbxThyroidDisease.Name = "chckbxThyroidDisease";
            this.chckbxThyroidDisease.Size = new System.Drawing.Size(149, 17);
            this.chckbxThyroidDisease.TabIndex = 17;
            this.chckbxThyroidDisease.Text = "Thyroid Disease";
            this.chckbxThyroidDisease.UseVisualStyleBackColor = true;
            // 
            // chckbxDiabetes
            // 
            this.chckbxDiabetes.AutoCheck = false;
            this.chckbxDiabetes.AutoSize = true;
            this.chckbxDiabetes.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chckbxDiabetes.ForeColor = System.Drawing.Color.Black;
            this.chckbxDiabetes.Location = new System.Drawing.Point(14, 92);
            this.chckbxDiabetes.Name = "chckbxDiabetes";
            this.chckbxDiabetes.Size = new System.Drawing.Size(93, 17);
            this.chckbxDiabetes.TabIndex = 18;
            this.chckbxDiabetes.Text = "Diabetes";
            this.chckbxDiabetes.UseVisualStyleBackColor = true;
            // 
            // chckbxHepatitis
            // 
            this.chckbxHepatitis.AutoCheck = false;
            this.chckbxHepatitis.AutoSize = true;
            this.chckbxHepatitis.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chckbxHepatitis.ForeColor = System.Drawing.Color.Black;
            this.chckbxHepatitis.Location = new System.Drawing.Point(14, 177);
            this.chckbxHepatitis.Name = "chckbxHepatitis";
            this.chckbxHepatitis.Size = new System.Drawing.Size(101, 17);
            this.chckbxHepatitis.TabIndex = 21;
            this.chckbxHepatitis.Text = "Hepatitis";
            this.chckbxHepatitis.UseVisualStyleBackColor = true;
            // 
            // chckbxCancer
            // 
            this.chckbxCancer.AutoCheck = false;
            this.chckbxCancer.AutoSize = true;
            this.chckbxCancer.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chckbxCancer.ForeColor = System.Drawing.Color.Black;
            this.chckbxCancer.Location = new System.Drawing.Point(14, 121);
            this.chckbxCancer.Name = "chckbxCancer";
            this.chckbxCancer.Size = new System.Drawing.Size(77, 17);
            this.chckbxCancer.TabIndex = 19;
            this.chckbxCancer.Text = "Cancer";
            this.chckbxCancer.UseVisualStyleBackColor = true;
            // 
            // chckbxHeartDisorders
            // 
            this.chckbxHeartDisorders.AutoCheck = false;
            this.chckbxHeartDisorders.AutoSize = true;
            this.chckbxHeartDisorders.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chckbxHeartDisorders.ForeColor = System.Drawing.Color.Black;
            this.chckbxHeartDisorders.Location = new System.Drawing.Point(14, 149);
            this.chckbxHeartDisorders.Name = "chckbxHeartDisorders";
            this.chckbxHeartDisorders.Size = new System.Drawing.Size(149, 17);
            this.chckbxHeartDisorders.TabIndex = 20;
            this.chckbxHeartDisorders.Text = "Heart Disorders";
            this.chckbxHeartDisorders.UseVisualStyleBackColor = true;
            // 
            // rchtxtbxOtherDisease
            // 
            this.rchtxtbxOtherDisease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rchtxtbxOtherDisease.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rchtxtbxOtherDisease.Location = new System.Drawing.Point(15, 489);
            this.rchtxtbxOtherDisease.Name = "rchtxtbxOtherDisease";
            this.rchtxtbxOtherDisease.ReadOnly = true;
            this.rchtxtbxOtherDisease.Size = new System.Drawing.Size(407, 134);
            this.rchtxtbxOtherDisease.TabIndex = 23;
            this.rchtxtbxOtherDisease.TabStop = false;
            this.rchtxtbxOtherDisease.Text = "";
            // 
            // lblOtherDisease
            // 
            this.lblOtherDisease.AutoSize = true;
            this.lblOtherDisease.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOtherDisease.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblOtherDisease.Location = new System.Drawing.Point(19, 444);
            this.lblOtherDisease.Name = "lblOtherDisease";
            this.lblOtherDisease.Size = new System.Drawing.Size(119, 13);
            this.lblOtherDisease.TabIndex = 22;
            this.lblOtherDisease.Text = "Other Disease:";
            // 
            // lblDaysFromLastDonation
            // 
            this.lblDaysFromLastDonation.AutoSize = true;
            this.lblDaysFromLastDonation.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDaysFromLastDonation.Location = new System.Drawing.Point(376, 161);
            this.lblDaysFromLastDonation.Name = "lblDaysFromLastDonation";
            this.lblDaysFromLastDonation.Size = new System.Drawing.Size(0, 13);
            this.lblDaysFromLastDonation.TabIndex = 4;
            // 
            // txtbxLastDonationDate
            // 
            this.txtbxLastDonationDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxLastDonationDate.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxLastDonationDate.Location = new System.Drawing.Point(189, 156);
            this.txtbxLastDonationDate.Name = "txtbxLastDonationDate";
            this.txtbxLastDonationDate.ReadOnly = true;
            this.txtbxLastDonationDate.Size = new System.Drawing.Size(177, 20);
            this.txtbxLastDonationDate.TabIndex = 0;
            this.txtbxLastDonationDate.TabStop = false;
            // 
            // lblLastDonationDate
            // 
            this.lblLastDonationDate.AutoSize = true;
            this.lblLastDonationDate.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastDonationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblLastDonationDate.Location = new System.Drawing.Point(25, 159);
            this.lblLastDonationDate.Name = "lblLastDonationDate";
            this.lblLastDonationDate.Size = new System.Drawing.Size(151, 13);
            this.lblLastDonationDate.TabIndex = 2;
            this.lblLastDonationDate.Text = "Last Donation Date";
            // 
            // txtbxAge
            // 
            this.txtbxAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxAge.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxAge.Location = new System.Drawing.Point(189, 117);
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.ReadOnly = true;
            this.txtbxAge.Size = new System.Drawing.Size(94, 20);
            this.txtbxAge.TabIndex = 0;
            this.txtbxAge.TabStop = false;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblAge.Location = new System.Drawing.Point(25, 117);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(31, 13);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age";
            // 
            // adminCredentialsControl1
            // 
            this.adminCredentialsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.adminCredentialsControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminCredentialsControl1.ForeColor = System.Drawing.Color.Black;
            this.adminCredentialsControl1.Location = new System.Drawing.Point(509, 247);
            this.adminCredentialsControl1.Name = "adminCredentialsControl1";
            this.adminCredentialsControl1.Size = new System.Drawing.Size(490, 333);
            this.adminCredentialsControl1.TabIndex = 5;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Controls.Add(this.btnManageBloodBank);
            this.pnlMenu.Controls.Add(this.btnUpdateAdmin);
            this.pnlMenu.Controls.Add(this.btnSignOut);
            this.pnlMenu.Controls.Add(this.btnManageUsers);
            this.pnlMenu.Location = new System.Drawing.Point(-1, 23);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(182, 791);
            this.pnlMenu.TabIndex = 27;
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
            this.pnlTitleBar.TabIndex = 28;
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
            this.lblFormName.Text = "Admin";
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.blur_back1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1350, 813);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.adminCredentialsControl1);
            this.Controls.Add(this.pnlRequestApproval);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.pnlRequestApproval.ResumeLayout(false);
            this.pnlRequestApproval.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Panel pnlRequestApproval;
        private System.Windows.Forms.Label lblLastDonationDate;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtbxLastDonationDate;
        private System.Windows.Forms.Label lblDaysFromLastDonation;
        private System.Windows.Forms.CheckBox chckbxHepatitis;
        private System.Windows.Forms.CheckBox chckbxHeartDisorders;
        private System.Windows.Forms.CheckBox chckbxCancer;
        private System.Windows.Forms.CheckBox chckbxDiabetes;
        private System.Windows.Forms.CheckBox chckbxThyroidDisease;
        private System.Windows.Forms.CheckBox chckbxBloodPressureDisorders;
        private System.Windows.Forms.Button btnRefuseRequest;
        private System.Windows.Forms.Button btnAcceptRequest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDiseases;
        private System.Windows.Forms.RichTextBox rchtxtbxOtherDisease;
        private System.Windows.Forms.Label lblOtherDisease;
        private System.Windows.Forms.Label lblml;
        private System.Windows.Forms.TextBox txtbxQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRequests;
        private System.Windows.Forms.Button btnUpdateAdmin;
        private System.Windows.Forms.Button btnManageUsers;
        private AdminCredentialsControl adminCredentialsControl1;
        private System.Windows.Forms.Button btnManageBloodBank;
        private System.Windows.Forms.Label lblRequestsCount;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExitTop;
    }
}