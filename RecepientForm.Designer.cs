
namespace Blood_Bank_Management_System
{
    partial class RecepientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepientForm));
            this.btnSwitchSamplesView = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnAB = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.lstviewBloodSamples = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colBloodType = new System.Windows.Forms.ColumnHeader();
            this.colBloodQuantity = new System.Windows.Forms.ColumnHeader();
            this.colRecievedDate = new System.Windows.Forms.ColumnHeader();
            this.colExpireyDate = new System.Windows.Forms.ColumnHeader();
            this.pnlMySamples = new System.Windows.Forms.Panel();
            this.lblRequestedSamplesHistory = new System.Windows.Forms.Label();
            this.btnDeleteFromHistory = new System.Windows.Forms.Button();
            this.lstviewRequestedSamples = new System.Windows.Forms.ListView();
            this.colIDReq = new System.Windows.Forms.ColumnHeader();
            this.colBloodTypeReq = new System.Windows.Forms.ColumnHeader();
            this.colBloodQuantityReq = new System.Windows.Forms.ColumnHeader();
            this.colRecievedDateReq = new System.Windows.Forms.ColumnHeader();
            this.colExpireyDateReq = new System.Windows.Forms.ColumnHeader();
            this.colHospital = new System.Windows.Forms.ColumnHeader();
            this.pnlBloodBank = new System.Windows.Forms.Panel();
            this.chckbxConfirmHospital = new System.Windows.Forms.CheckBox();
            this.lblBloodBank = new System.Windows.Forms.Label();
            this.pnlBloodType = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExitTop = new System.Windows.Forms.Button();
            this.pnlMySamples.SuspendLayout();
            this.pnlBloodBank.SuspendLayout();
            this.pnlBloodType.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSwitchSamplesView
            // 
            this.btnSwitchSamplesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(84)))), ((int)(((byte)(101)))));
            this.btnSwitchSamplesView.FlatAppearance.BorderSize = 0;
            this.btnSwitchSamplesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchSamplesView.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSwitchSamplesView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnSwitchSamplesView.Image = global::Blood_Bank_Management_System.Properties.Resources.blood;
            this.btnSwitchSamplesView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSwitchSamplesView.Location = new System.Drawing.Point(1, 200);
            this.btnSwitchSamplesView.Name = "btnSwitchSamplesView";
            this.btnSwitchSamplesView.Size = new System.Drawing.Size(181, 57);
            this.btnSwitchSamplesView.TabIndex = 5;
            this.btnSwitchSamplesView.Text = "Blood Bank";
            this.btnSwitchSamplesView.UseVisualStyleBackColor = false;
            this.btnSwitchSamplesView.Click += new System.EventHandler(this.btnSwitchSamplesView_Click);
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
            this.btnDeleteAccount.Location = new System.Drawing.Point(1, 328);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(181, 57);
            this.btnDeleteAccount.TabIndex = 4;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
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
            this.btnUpdateAccount.Location = new System.Drawing.Point(1, 264);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(181, 57);
            this.btnUpdateAccount.TabIndex = 3;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = false;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
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
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(76)))), ((int)(((byte)(71)))));
            this.btnDisplayAll.FlatAppearance.BorderSize = 0;
            this.btnDisplayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAll.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnDisplayAll.Location = new System.Drawing.Point(-1, 421);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(60, 40);
            this.btnDisplayAll.TabIndex = 5;
            this.btnDisplayAll.Text = "All";
            this.btnDisplayAll.UseVisualStyleBackColor = false;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblType.Location = new System.Drawing.Point(7, 29);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 17);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type";
            // 
            // btnA
            // 
            this.btnA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(76)))), ((int)(((byte)(71)))));
            this.btnA.FlatAppearance.BorderSize = 0;
            this.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnA.Location = new System.Drawing.Point(-1, 138);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(60, 40);
            this.btnA.TabIndex = 17;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = false;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(76)))), ((int)(((byte)(71)))));
            this.btnB.FlatAppearance.BorderSize = 0;
            this.btnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnB.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnB.Location = new System.Drawing.Point(-1, 184);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(60, 40);
            this.btnB.TabIndex = 18;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnAB
            // 
            this.btnAB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(76)))), ((int)(((byte)(71)))));
            this.btnAB.FlatAppearance.BorderSize = 0;
            this.btnAB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAB.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnAB.Location = new System.Drawing.Point(-1, 230);
            this.btnAB.Name = "btnAB";
            this.btnAB.Size = new System.Drawing.Size(60, 40);
            this.btnAB.TabIndex = 19;
            this.btnAB.Text = "AB";
            this.btnAB.UseVisualStyleBackColor = false;
            this.btnAB.Click += new System.EventHandler(this.btnAB_Click);
            // 
            // btnO
            // 
            this.btnO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(76)))), ((int)(((byte)(71)))));
            this.btnO.FlatAppearance.BorderSize = 0;
            this.btnO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnO.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnO.Location = new System.Drawing.Point(-1, 276);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(60, 40);
            this.btnO.TabIndex = 20;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = false;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.btnRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnRequest.Location = new System.Drawing.Point(413, 636);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(181, 57);
            this.btnRequest.TabIndex = 21;
            this.btnRequest.Text = "Request Sample";
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lstviewBloodSamples
            // 
            this.lstviewBloodSamples.AccessibleName = "lstViewBloodSamples";
            this.lstviewBloodSamples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstviewBloodSamples.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colBloodType,
            this.colBloodQuantity,
            this.colRecievedDate,
            this.colExpireyDate});
            this.lstviewBloodSamples.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstviewBloodSamples.FullRowSelect = true;
            this.lstviewBloodSamples.HideSelection = false;
            this.lstviewBloodSamples.LabelEdit = true;
            this.lstviewBloodSamples.Location = new System.Drawing.Point(15, 46);
            this.lstviewBloodSamples.Name = "lstviewBloodSamples";
            this.lstviewBloodSamples.Size = new System.Drawing.Size(605, 530);
            this.lstviewBloodSamples.TabIndex = 22;
            this.lstviewBloodSamples.UseCompatibleStateImageBehavior = false;
            this.lstviewBloodSamples.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "";
            this.colID.Width = 0;
            // 
            // colBloodType
            // 
            this.colBloodType.Text = "Blood Type";
            this.colBloodType.Width = 100;
            // 
            // colBloodQuantity
            // 
            this.colBloodQuantity.Text = "Blood Quantity";
            this.colBloodQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBloodQuantity.Width = 140;
            // 
            // colRecievedDate
            // 
            this.colRecievedDate.Text = "Recieved Date";
            this.colRecievedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRecievedDate.Width = 180;
            // 
            // colExpireyDate
            // 
            this.colExpireyDate.Text = "Expirey Date";
            this.colExpireyDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colExpireyDate.Width = 180;
            // 
            // pnlMySamples
            // 
            this.pnlMySamples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.pnlMySamples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMySamples.Controls.Add(this.lblRequestedSamplesHistory);
            this.pnlMySamples.Controls.Add(this.btnDeleteFromHistory);
            this.pnlMySamples.Controls.Add(this.lstviewRequestedSamples);
            this.pnlMySamples.Location = new System.Drawing.Point(526, 61);
            this.pnlMySamples.Name = "pnlMySamples";
            this.pnlMySamples.Size = new System.Drawing.Size(772, 711);
            this.pnlMySamples.TabIndex = 23;
            // 
            // lblRequestedSamplesHistory
            // 
            this.lblRequestedSamplesHistory.AutoSize = true;
            this.lblRequestedSamplesHistory.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRequestedSamplesHistory.Location = new System.Drawing.Point(14, 15);
            this.lblRequestedSamplesHistory.Name = "lblRequestedSamplesHistory";
            this.lblRequestedSamplesHistory.Size = new System.Drawing.Size(188, 17);
            this.lblRequestedSamplesHistory.TabIndex = 25;
            this.lblRequestedSamplesHistory.Text = "My Samples History";
            // 
            // btnDeleteFromHistory
            // 
            this.btnDeleteFromHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.btnDeleteFromHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnDeleteFromHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFromHistory.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteFromHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnDeleteFromHistory.Location = new System.Drawing.Point(530, 633);
            this.btnDeleteFromHistory.Name = "btnDeleteFromHistory";
            this.btnDeleteFromHistory.Size = new System.Drawing.Size(214, 57);
            this.btnDeleteFromHistory.TabIndex = 24;
            this.btnDeleteFromHistory.Text = "Delete From History";
            this.btnDeleteFromHistory.UseVisualStyleBackColor = false;
            this.btnDeleteFromHistory.Click += new System.EventHandler(this.btnDeleteFromHistory_Click);
            // 
            // lstviewRequestedSamples
            // 
            this.lstviewRequestedSamples.AccessibleName = "lstviewRequestedSamples";
            this.lstviewRequestedSamples.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstviewRequestedSamples.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIDReq,
            this.colBloodTypeReq,
            this.colBloodQuantityReq,
            this.colRecievedDateReq,
            this.colExpireyDateReq,
            this.colHospital});
            this.lstviewRequestedSamples.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstviewRequestedSamples.FullRowSelect = true;
            this.lstviewRequestedSamples.HideSelection = false;
            this.lstviewRequestedSamples.LabelEdit = true;
            this.lstviewRequestedSamples.Location = new System.Drawing.Point(14, 46);
            this.lstviewRequestedSamples.Name = "lstviewRequestedSamples";
            this.lstviewRequestedSamples.Size = new System.Drawing.Size(730, 496);
            this.lstviewRequestedSamples.TabIndex = 24;
            this.lstviewRequestedSamples.UseCompatibleStateImageBehavior = false;
            this.lstviewRequestedSamples.View = System.Windows.Forms.View.Details;
            // 
            // colIDReq
            // 
            this.colIDReq.Text = "";
            this.colIDReq.Width = 0;
            // 
            // colBloodTypeReq
            // 
            this.colBloodTypeReq.Text = "Blood Type";
            this.colBloodTypeReq.Width = 100;
            // 
            // colBloodQuantityReq
            // 
            this.colBloodQuantityReq.Text = "Blood Quantity";
            this.colBloodQuantityReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colBloodQuantityReq.Width = 140;
            // 
            // colRecievedDateReq
            // 
            this.colRecievedDateReq.Text = "Recieved Date";
            this.colRecievedDateReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colRecievedDateReq.Width = 180;
            // 
            // colExpireyDateReq
            // 
            this.colExpireyDateReq.Text = "Expirey Date";
            this.colExpireyDateReq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colExpireyDateReq.Width = 180;
            // 
            // colHospital
            // 
            this.colHospital.Text = "Hospital";
            this.colHospital.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colHospital.Width = 120;
            // 
            // pnlBloodBank
            // 
            this.pnlBloodBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.pnlBloodBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBloodBank.Controls.Add(this.chckbxConfirmHospital);
            this.pnlBloodBank.Controls.Add(this.lblBloodBank);
            this.pnlBloodBank.Controls.Add(this.pnlBloodType);
            this.pnlBloodBank.Controls.Add(this.lstviewBloodSamples);
            this.pnlBloodBank.Controls.Add(this.btnRequest);
            this.pnlBloodBank.Location = new System.Drawing.Point(588, 62);
            this.pnlBloodBank.Name = "pnlBloodBank";
            this.pnlBloodBank.Size = new System.Drawing.Size(709, 711);
            this.pnlBloodBank.TabIndex = 24;
            // 
            // chckbxConfirmHospital
            // 
            this.chckbxConfirmHospital.AutoSize = true;
            this.chckbxConfirmHospital.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chckbxConfirmHospital.Location = new System.Drawing.Point(24, 670);
            this.chckbxConfirmHospital.Name = "chckbxConfirmHospital";
            this.chckbxConfirmHospital.Size = new System.Drawing.Size(173, 19);
            this.chckbxConfirmHospital.TabIndex = 27;
            this.chckbxConfirmHospital.Text = "Confirm Hospital";
            this.chckbxConfirmHospital.UseVisualStyleBackColor = true;
            // 
            // lblBloodBank
            // 
            this.lblBloodBank.AutoSize = true;
            this.lblBloodBank.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBloodBank.Location = new System.Drawing.Point(15, 17);
            this.lblBloodBank.Name = "lblBloodBank";
            this.lblBloodBank.Size = new System.Drawing.Size(108, 17);
            this.lblBloodBank.TabIndex = 26;
            this.lblBloodBank.Text = "Blood Bank";
            // 
            // pnlBloodType
            // 
            this.pnlBloodType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(94)))), ((int)(((byte)(88)))));
            this.pnlBloodType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBloodType.Controls.Add(this.lblType);
            this.pnlBloodType.Controls.Add(this.btnA);
            this.pnlBloodType.Controls.Add(this.btnB);
            this.pnlBloodType.Controls.Add(this.btnDisplayAll);
            this.pnlBloodType.Controls.Add(this.btnAB);
            this.pnlBloodType.Controls.Add(this.btnO);
            this.pnlBloodType.Location = new System.Drawing.Point(647, -1);
            this.pnlBloodType.Name = "pnlBloodType";
            this.pnlBloodType.Size = new System.Drawing.Size(60, 724);
            this.pnlBloodType.TabIndex = 23;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.pnlMenu.Controls.Add(this.btnSignOut);
            this.pnlMenu.Controls.Add(this.btnSwitchSamplesView);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Controls.Add(this.btnUpdateAccount);
            this.pnlMenu.Controls.Add(this.btnDeleteAccount);
            this.pnlMenu.Location = new System.Drawing.Point(-1, 23);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(182, 791);
            this.pnlMenu.TabIndex = 25;
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
            this.pnlTitleBar.TabIndex = 26;
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblFormName.Location = new System.Drawing.Point(16, 19);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(98, 17);
            this.lblFormName.TabIndex = 8;
            this.lblFormName.Text = "Recepient";
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
            // RecepientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.blur_back1;
            this.ClientSize = new System.Drawing.Size(1350, 813);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlBloodBank);
            this.Controls.Add(this.pnlMySamples);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RecepientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecepientForm";
            this.Load += new System.EventHandler(this.RecepientForm_Load);
            this.pnlMySamples.ResumeLayout(false);
            this.pnlMySamples.PerformLayout();
            this.pnlBloodBank.ResumeLayout(false);
            this.pnlBloodBank.PerformLayout();
            this.pnlBloodType.ResumeLayout(false);
            this.pnlBloodType.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnAB;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.ListView lstviewBloodSamples;
        private System.Windows.Forms.ColumnHeader colBloodType;
        private System.Windows.Forms.ColumnHeader colBloodQuantity;
        private System.Windows.Forms.ColumnHeader colRecievedDate;
        private System.Windows.Forms.ColumnHeader colExpireyDate;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.Panel pnlMySamples;
        private System.Windows.Forms.Label lblRequestedSamplesHistory;
        private System.Windows.Forms.Button btnDeleteFromHistory;
        private System.Windows.Forms.ListView lstviewRequestedSamples;
        private System.Windows.Forms.ColumnHeader colBloodTypeReq;
        private System.Windows.Forms.ColumnHeader colBloodQuantityReq;
        private System.Windows.Forms.ColumnHeader colRecievedDateReq;
        private System.Windows.Forms.ColumnHeader colExpireyDateReq;
        private System.Windows.Forms.ColumnHeader colIDReq;
        private System.Windows.Forms.ColumnHeader colHospital;
        private System.Windows.Forms.Button btnSwitchSamplesView;
        private System.Windows.Forms.Panel pnlBloodBank;
        private System.Windows.Forms.Panel pnlBloodType;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExitTop;
        private System.Windows.Forms.Label lblBloodBank;
        private System.Windows.Forms.CheckBox chckbxConfirmHospital;
    }
}