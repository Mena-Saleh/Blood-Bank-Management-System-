
namespace Blood_Bank_Management_System
{
    partial class RecepientControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbxDoctorOfTheCase = new System.Windows.Forms.TextBox();
            this.txtbxHospital = new System.Windows.Forms.TextBox();
            this.lblHospital = new System.Windows.Forms.Label();
            this.lblDoctorOfTheCase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxDoctorOfTheCase
            // 
            this.txtbxDoctorOfTheCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxDoctorOfTheCase.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxDoctorOfTheCase.Location = new System.Drawing.Point(278, 104);
            this.txtbxDoctorOfTheCase.Name = "txtbxDoctorOfTheCase";
            this.txtbxDoctorOfTheCase.Size = new System.Drawing.Size(277, 22);
            this.txtbxDoctorOfTheCase.TabIndex = 0;
            // 
            // txtbxHospital
            // 
            this.txtbxHospital.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxHospital.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbxHospital.Location = new System.Drawing.Point(278, 65);
            this.txtbxHospital.Name = "txtbxHospital";
            this.txtbxHospital.Size = new System.Drawing.Size(277, 22);
            this.txtbxHospital.TabIndex = 0;
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHospital.Location = new System.Drawing.Point(51, 72);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(79, 15);
            this.lblHospital.TabIndex = 1;
            this.lblHospital.Text = "Hospital";
            // 
            // lblDoctorOfTheCase
            // 
            this.lblDoctorOfTheCase.AutoSize = true;
            this.lblDoctorOfTheCase.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDoctorOfTheCase.Location = new System.Drawing.Point(51, 111);
            this.lblDoctorOfTheCase.Name = "lblDoctorOfTheCase";
            this.lblDoctorOfTheCase.Size = new System.Drawing.Size(169, 15);
            this.lblDoctorOfTheCase.TabIndex = 2;
            this.lblDoctorOfTheCase.Text = "Doctor Of The Case";
            // 
            // RecepientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.lblDoctorOfTheCase);
            this.Controls.Add(this.lblHospital);
            this.Controls.Add(this.txtbxHospital);
            this.Controls.Add(this.txtbxDoctorOfTheCase);
            this.Name = "RecepientControl";
            this.Size = new System.Drawing.Size(584, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxDoctorOfTheCase;
        private System.Windows.Forms.TextBox txtbxHospital;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.Label lblDoctorOfTheCase;
    }
}
