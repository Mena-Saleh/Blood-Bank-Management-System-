
namespace Blood_Bank_Management_System
{
    partial class AdminManageBloodBankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageBloodBankForm));
            this.btnGoBack = new System.Windows.Forms.Button();
            this.pnlBloodBank = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lstviewBloodSamples = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colBloodType = new System.Windows.Forms.ColumnHeader();
            this.colBloodQuantity = new System.Windows.Forms.ColumnHeader();
            this.colRecievedDate = new System.Windows.Forms.ColumnHeader();
            this.colExpireyDate = new System.Windows.Forms.ColumnHeader();
            this.lblBloodBank = new System.Windows.Forms.Label();
            this.pnlUpdateOrInsert = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblExpireyDate = new System.Windows.Forms.Label();
            this.lblRecievedDate = new System.Windows.Forms.Label();
            this.mnthcalExpireyDate = new System.Windows.Forms.MonthCalendar();
            this.cmbobxBloodAmount = new System.Windows.Forms.ComboBox();
            this.lblmg = new System.Windows.Forms.Label();
            this.cmbobxBloodType = new System.Windows.Forms.ComboBox();
            this.btnUpdateOrInsert = new System.Windows.Forms.Button();
            this.mnthcalRecievedDate = new System.Windows.Forms.MonthCalendar();
            this.lblBloodQuantity = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblFormName = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExitTop = new System.Windows.Forms.Button();
            this.pnlBloodBank.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlUpdateOrInsert.SuspendLayout();
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
            // pnlBloodBank
            // 
            this.pnlBloodBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.pnlBloodBank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBloodBank.Controls.Add(this.panel1);
            this.pnlBloodBank.Controls.Add(this.lstviewBloodSamples);
            this.pnlBloodBank.Controls.Add(this.lblBloodBank);
            this.pnlBloodBank.Location = new System.Drawing.Point(523, 62);
            this.pnlBloodBank.Name = "pnlBloodBank";
            this.pnlBloodBank.Size = new System.Drawing.Size(725, 666);
            this.pnlBloodBank.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDisplayAll);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Location = new System.Drawing.Point(0, 608);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 56);
            this.panel1.TabIndex = 24;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.btnDisplayAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnDisplayAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayAll.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDisplayAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnDisplayAll.Location = new System.Drawing.Point(36, -1);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(150, 57);
            this.btnDisplayAll.TabIndex = 4;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = false;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnDelete.Location = new System.Drawing.Point(201, -1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 57);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnUpdate.Location = new System.Drawing.Point(366, -1);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 57);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(63)))), ((int)(((byte)(85)))));
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnInsert.Location = new System.Drawing.Point(532, -1);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(150, 57);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.lstviewBloodSamples.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstviewBloodSamples.FullRowSelect = true;
            this.lstviewBloodSamples.HideSelection = false;
            this.lstviewBloodSamples.LabelEdit = true;
            this.lstviewBloodSamples.Location = new System.Drawing.Point(15, 31);
            this.lstviewBloodSamples.MultiSelect = false;
            this.lstviewBloodSamples.Name = "lstviewBloodSamples";
            this.lstviewBloodSamples.Size = new System.Drawing.Size(687, 550);
            this.lstviewBloodSamples.TabIndex = 23;
            this.lstviewBloodSamples.UseCompatibleStateImageBehavior = false;
            this.lstviewBloodSamples.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
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
            // lblBloodBank
            // 
            this.lblBloodBank.AutoSize = true;
            this.lblBloodBank.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBloodBank.Location = new System.Drawing.Point(15, 10);
            this.lblBloodBank.Name = "lblBloodBank";
            this.lblBloodBank.Size = new System.Drawing.Size(108, 17);
            this.lblBloodBank.TabIndex = 8;
            this.lblBloodBank.Text = "Blood Bank";
            // 
            // pnlUpdateOrInsert
            // 
            this.pnlUpdateOrInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.pnlUpdateOrInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateOrInsert.Controls.Add(this.btnCancel);
            this.pnlUpdateOrInsert.Controls.Add(this.lblExpireyDate);
            this.pnlUpdateOrInsert.Controls.Add(this.lblRecievedDate);
            this.pnlUpdateOrInsert.Controls.Add(this.mnthcalExpireyDate);
            this.pnlUpdateOrInsert.Controls.Add(this.cmbobxBloodAmount);
            this.pnlUpdateOrInsert.Controls.Add(this.lblmg);
            this.pnlUpdateOrInsert.Controls.Add(this.cmbobxBloodType);
            this.pnlUpdateOrInsert.Controls.Add(this.btnUpdateOrInsert);
            this.pnlUpdateOrInsert.Controls.Add(this.mnthcalRecievedDate);
            this.pnlUpdateOrInsert.Controls.Add(this.lblBloodQuantity);
            this.pnlUpdateOrInsert.Controls.Add(this.lblBloodType);
            this.pnlUpdateOrInsert.Location = new System.Drawing.Point(435, 163);
            this.pnlUpdateOrInsert.Name = "pnlUpdateOrInsert";
            this.pnlUpdateOrInsert.Size = new System.Drawing.Size(655, 462);
            this.pnlUpdateOrInsert.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnCancel.Location = new System.Drawing.Point(424, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(181, 57);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblExpireyDate
            // 
            this.lblExpireyDate.AutoSize = true;
            this.lblExpireyDate.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpireyDate.Location = new System.Drawing.Point(330, 340);
            this.lblExpireyDate.Name = "lblExpireyDate";
            this.lblExpireyDate.Size = new System.Drawing.Size(115, 15);
            this.lblExpireyDate.TabIndex = 20;
            this.lblExpireyDate.Text = "Expirey Date";
            // 
            // lblRecievedDate
            // 
            this.lblRecievedDate.AutoSize = true;
            this.lblRecievedDate.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecievedDate.Location = new System.Drawing.Point(35, 340);
            this.lblRecievedDate.Name = "lblRecievedDate";
            this.lblRecievedDate.Size = new System.Drawing.Size(124, 15);
            this.lblRecievedDate.TabIndex = 19;
            this.lblRecievedDate.Text = "Recieved Date";
            // 
            // mnthcalExpireyDate
            // 
            this.mnthcalExpireyDate.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnthcalExpireyDate.Location = new System.Drawing.Point(330, 124);
            this.mnthcalExpireyDate.MaxSelectionCount = 1;
            this.mnthcalExpireyDate.Name = "mnthcalExpireyDate";
            this.mnthcalExpireyDate.TabIndex = 18;
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
            this.cmbobxBloodAmount.Location = new System.Drawing.Point(191, 75);
            this.cmbobxBloodAmount.Name = "cmbobxBloodAmount";
            this.cmbobxBloodAmount.Size = new System.Drawing.Size(151, 23);
            this.cmbobxBloodAmount.TabIndex = 17;
            // 
            // lblmg
            // 
            this.lblmg.AutoSize = true;
            this.lblmg.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblmg.Location = new System.Drawing.Point(359, 83);
            this.lblmg.Name = "lblmg";
            this.lblmg.Size = new System.Drawing.Size(25, 15);
            this.lblmg.TabIndex = 16;
            this.lblmg.Text = "mg";
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
            this.cmbobxBloodType.Location = new System.Drawing.Point(191, 28);
            this.cmbobxBloodType.Name = "cmbobxBloodType";
            this.cmbobxBloodType.Size = new System.Drawing.Size(151, 23);
            this.cmbobxBloodType.TabIndex = 15;
            // 
            // btnUpdateOrInsert
            // 
            this.btnUpdateOrInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(84)))), ((int)(((byte)(91)))));
            this.btnUpdateOrInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.btnUpdateOrInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateOrInsert.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateOrInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.btnUpdateOrInsert.Location = new System.Drawing.Point(161, 388);
            this.btnUpdateOrInsert.Name = "btnUpdateOrInsert";
            this.btnUpdateOrInsert.Size = new System.Drawing.Size(181, 57);
            this.btnUpdateOrInsert.TabIndex = 3;
            this.btnUpdateOrInsert.Text = "Update";
            this.btnUpdateOrInsert.UseVisualStyleBackColor = false;
            this.btnUpdateOrInsert.Click += new System.EventHandler(this.btnUpdateOrInsert_Click);
            // 
            // mnthcalRecievedDate
            // 
            this.mnthcalRecievedDate.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnthcalRecievedDate.Location = new System.Drawing.Point(35, 124);
            this.mnthcalRecievedDate.MaxSelectionCount = 1;
            this.mnthcalRecievedDate.Name = "mnthcalRecievedDate";
            this.mnthcalRecievedDate.TabIndex = 2;
            // 
            // lblBloodQuantity
            // 
            this.lblBloodQuantity.AutoSize = true;
            this.lblBloodQuantity.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBloodQuantity.Location = new System.Drawing.Point(50, 83);
            this.lblBloodQuantity.Name = "lblBloodQuantity";
            this.lblBloodQuantity.Size = new System.Drawing.Size(133, 15);
            this.lblBloodQuantity.TabIndex = 1;
            this.lblBloodQuantity.Text = "Blood Quantity";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBloodType.Location = new System.Drawing.Point(50, 31);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(97, 15);
            this.lblBloodType.TabIndex = 0;
            this.lblBloodType.Text = "Blood Type";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Controls.Add(this.btnGoBack);
            this.pnlMenu.Location = new System.Drawing.Point(-1, 23);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(182, 791);
            this.pnlMenu.TabIndex = 28;
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
            this.pnlTitleBar.TabIndex = 29;
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.lblFormName.Location = new System.Drawing.Point(16, 19);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(208, 17);
            this.lblFormName.TabIndex = 8;
            this.lblFormName.Text = "BloodBank Management";
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
            // AdminManageBloodBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blood_Bank_Management_System.Properties.Resources.BluredBackGround;
            this.ClientSize = new System.Drawing.Size(1350, 813);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlUpdateOrInsert);
            this.Controls.Add(this.pnlBloodBank);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminManageBloodBankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminManageBloodBankForm";
            this.pnlBloodBank.ResumeLayout(false);
            this.pnlBloodBank.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlUpdateOrInsert.ResumeLayout(false);
            this.pnlUpdateOrInsert.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.Panel pnlBloodBank;
        private System.Windows.Forms.Label lblBloodBank;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.ListView lstviewBloodSamples;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colBloodType;
        private System.Windows.Forms.ColumnHeader colBloodQuantity;
        private System.Windows.Forms.ColumnHeader colRecievedDate;
        private System.Windows.Forms.ColumnHeader colExpireyDate;
        private System.Windows.Forms.Panel pnlUpdateOrInsert;
        private System.Windows.Forms.Button btnUpdateOrInsert;
        private System.Windows.Forms.MonthCalendar mnthcalRecievedDate;
        private System.Windows.Forms.Label lblBloodQuantity;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.ComboBox cmbobxBloodType;
        private System.Windows.Forms.ComboBox cmbobxBloodAmount;
        private System.Windows.Forms.Label lblmg;
        private System.Windows.Forms.MonthCalendar mnthcalExpireyDate;
        private System.Windows.Forms.Label lblExpireyDate;
        private System.Windows.Forms.Label lblRecievedDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExitTop;
        private System.Windows.Forms.Button btnCancel;
    }
}