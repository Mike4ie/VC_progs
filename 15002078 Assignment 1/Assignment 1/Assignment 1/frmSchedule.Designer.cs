namespace Assignment_1
{
    partial class frmSchedule
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
            this.tbcSchedule = new System.Windows.Forms.TabControl();
            this.tbpAddRecord = new System.Windows.Forms.TabPage();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.tbpSeachRecord = new System.Windows.Forms.TabPage();
            this.txtSearchVal = new System.Windows.Forms.TextBox();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.cmbSearchCrit = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbpChangePass = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.tbpReport = new System.Windows.Forms.TabPage();
            this.btnSaveRep = new System.Windows.Forms.Button();
            this.btnGenRep = new System.Windows.Forms.Button();
            this.btnOpenRep = new System.Windows.Forms.Button();
            this.lblSearchCrit = new System.Windows.Forms.Label();
            this.lblSearchVal = new System.Windows.Forms.Label();
            this.tbcSchedule.SuspendLayout();
            this.tbpAddRecord.SuspendLayout();
            this.tbpSeachRecord.SuspendLayout();
            this.tbpChangePass.SuspendLayout();
            this.tbpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcSchedule
            // 
            this.tbcSchedule.Controls.Add(this.tbpAddRecord);
            this.tbcSchedule.Controls.Add(this.tbpSeachRecord);
            this.tbcSchedule.Controls.Add(this.tbpChangePass);
            this.tbcSchedule.Controls.Add(this.tbpReport);
            this.tbcSchedule.Location = new System.Drawing.Point(12, 12);
            this.tbcSchedule.Name = "tbcSchedule";
            this.tbcSchedule.SelectedIndex = 0;
            this.tbcSchedule.Size = new System.Drawing.Size(302, 237);
            this.tbcSchedule.TabIndex = 0;
            // 
            // tbpAddRecord
            // 
            this.tbpAddRecord.Controls.Add(this.btnAddPatient);
            this.tbpAddRecord.Controls.Add(this.lblPhoneNum);
            this.tbpAddRecord.Controls.Add(this.lblSurname);
            this.tbpAddRecord.Controls.Add(this.lblFirstname);
            this.tbpAddRecord.Controls.Add(this.txtPhoneNum);
            this.tbpAddRecord.Controls.Add(this.txtSurname);
            this.tbpAddRecord.Controls.Add(this.txtFirstname);
            this.tbpAddRecord.Location = new System.Drawing.Point(4, 22);
            this.tbpAddRecord.Name = "tbpAddRecord";
            this.tbpAddRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddRecord.Size = new System.Drawing.Size(294, 211);
            this.tbpAddRecord.TabIndex = 0;
            this.tbpAddRecord.Text = "Add Patient";
            this.tbpAddRecord.UseVisualStyleBackColor = true;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(29, 182);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(198, 23);
            this.btnAddPatient.TabIndex = 7;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(26, 98);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNum.TabIndex = 6;
            this.lblPhoneNum.Text = "Phone Number";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(26, 67);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Surname";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(26, 34);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(57, 13);
            this.lblFirstname.TabIndex = 4;
            this.lblFirstname.Text = "First Name";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(127, 95);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNum.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(127, 64);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(127, 31);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // tbpSeachRecord
            // 
            this.tbpSeachRecord.Controls.Add(this.lblSearchVal);
            this.tbpSeachRecord.Controls.Add(this.lblSearchCrit);
            this.tbpSeachRecord.Controls.Add(this.txtSearchVal);
            this.tbpSeachRecord.Controls.Add(this.lbxResults);
            this.tbpSeachRecord.Controls.Add(this.cmbSearchCrit);
            this.tbpSeachRecord.Controls.Add(this.btnSearch);
            this.tbpSeachRecord.Location = new System.Drawing.Point(4, 22);
            this.tbpSeachRecord.Name = "tbpSeachRecord";
            this.tbpSeachRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSeachRecord.Size = new System.Drawing.Size(294, 211);
            this.tbpSeachRecord.TabIndex = 1;
            this.tbpSeachRecord.Text = "Patient Search";
            this.tbpSeachRecord.UseVisualStyleBackColor = true;
            // 
            // txtSearchVal
            // 
            this.txtSearchVal.Location = new System.Drawing.Point(139, 55);
            this.txtSearchVal.Name = "txtSearchVal";
            this.txtSearchVal.Size = new System.Drawing.Size(120, 20);
            this.txtSearchVal.TabIndex = 3;
            // 
            // lbxResults
            // 
            this.lbxResults.FormattingEnabled = true;
            this.lbxResults.Location = new System.Drawing.Point(28, 110);
            this.lbxResults.Name = "lbxResults";
            this.lbxResults.Size = new System.Drawing.Size(232, 95);
            this.lbxResults.TabIndex = 2;
            // 
            // cmbSearchCrit
            // 
            this.cmbSearchCrit.FormattingEnabled = true;
            this.cmbSearchCrit.Items.AddRange(new object[] {
            "Firstname",
            "Surname",
            "Phone Number"});
            this.cmbSearchCrit.Location = new System.Drawing.Point(139, 28);
            this.cmbSearchCrit.Name = "cmbSearchCrit";
            this.cmbSearchCrit.Size = new System.Drawing.Size(121, 21);
            this.cmbSearchCrit.TabIndex = 1;
            this.cmbSearchCrit.SelectedIndexChanged += new System.EventHandler(this.cmbSearchCrit_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(28, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(231, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbpChangePass
            // 
            this.tbpChangePass.Controls.Add(this.label6);
            this.tbpChangePass.Controls.Add(this.label5);
            this.tbpChangePass.Controls.Add(this.lblUsername);
            this.tbpChangePass.Controls.Add(this.txtNewPass);
            this.tbpChangePass.Controls.Add(this.txtCurrentPass);
            this.tbpChangePass.Controls.Add(this.txtUser);
            this.tbpChangePass.Controls.Add(this.btnPassword);
            this.tbpChangePass.Location = new System.Drawing.Point(4, 22);
            this.tbpChangePass.Name = "tbpChangePass";
            this.tbpChangePass.Size = new System.Drawing.Size(294, 211);
            this.tbpChangePass.TabIndex = 2;
            this.tbpChangePass.Text = "Change Password";
            this.tbpChangePass.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Current Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(15, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(125, 118);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(100, 20);
            this.txtNewPass.TabIndex = 3;
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(125, 57);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentPass.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(125, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 1;
            // 
            // btnPassword
            // 
            this.btnPassword.Location = new System.Drawing.Point(61, 161);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(113, 23);
            this.btnPassword.TabIndex = 0;
            this.btnPassword.Text = "Change Password";
            this.btnPassword.UseVisualStyleBackColor = true;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // tbpReport
            // 
            this.tbpReport.Controls.Add(this.btnOpenRep);
            this.tbpReport.Controls.Add(this.btnGenRep);
            this.tbpReport.Controls.Add(this.btnSaveRep);
            this.tbpReport.Location = new System.Drawing.Point(4, 22);
            this.tbpReport.Name = "tbpReport";
            this.tbpReport.Size = new System.Drawing.Size(294, 211);
            this.tbpReport.TabIndex = 3;
            this.tbpReport.Text = "Report";
            this.tbpReport.UseVisualStyleBackColor = true;
            // 
            // btnSaveRep
            // 
            this.btnSaveRep.Location = new System.Drawing.Point(3, 138);
            this.btnSaveRep.Name = "btnSaveRep";
            this.btnSaveRep.Size = new System.Drawing.Size(288, 70);
            this.btnSaveRep.TabIndex = 0;
            this.btnSaveRep.Text = "Save report";
            this.btnSaveRep.UseVisualStyleBackColor = true;
            this.btnSaveRep.Click += new System.EventHandler(this.btnSaveRep_Click);
            // 
            // btnGenRep
            // 
            this.btnGenRep.Location = new System.Drawing.Point(3, 70);
            this.btnGenRep.Name = "btnGenRep";
            this.btnGenRep.Size = new System.Drawing.Size(288, 62);
            this.btnGenRep.TabIndex = 1;
            this.btnGenRep.Text = "Generate report";
            this.btnGenRep.UseVisualStyleBackColor = true;
            this.btnGenRep.Click += new System.EventHandler(this.btnGenRep_Click);
            // 
            // btnOpenRep
            // 
            this.btnOpenRep.Location = new System.Drawing.Point(3, 3);
            this.btnOpenRep.Name = "btnOpenRep";
            this.btnOpenRep.Size = new System.Drawing.Size(288, 61);
            this.btnOpenRep.TabIndex = 3;
            this.btnOpenRep.Text = "Open report";
            this.btnOpenRep.UseVisualStyleBackColor = true;
            this.btnOpenRep.Click += new System.EventHandler(this.btnOpenRep_Click);
            // 
            // lblSearchCrit
            // 
            this.lblSearchCrit.AutoSize = true;
            this.lblSearchCrit.Location = new System.Drawing.Point(25, 31);
            this.lblSearchCrit.Name = "lblSearchCrit";
            this.lblSearchCrit.Size = new System.Drawing.Size(75, 13);
            this.lblSearchCrit.TabIndex = 4;
            this.lblSearchCrit.Text = "Search criteria";
            // 
            // lblSearchVal
            // 
            this.lblSearchVal.AutoSize = true;
            this.lblSearchVal.Location = new System.Drawing.Point(25, 58);
            this.lblSearchVal.Name = "lblSearchVal";
            this.lblSearchVal.Size = new System.Drawing.Size(71, 13);
            this.lblSearchVal.TabIndex = 5;
            this.lblSearchVal.Text = "Search Value";
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 261);
            this.Controls.Add(this.tbcSchedule);
            this.Name = "frmSchedule";
            this.Text = "Schedule";
            this.tbcSchedule.ResumeLayout(false);
            this.tbpAddRecord.ResumeLayout(false);
            this.tbpAddRecord.PerformLayout();
            this.tbpSeachRecord.ResumeLayout(false);
            this.tbpSeachRecord.PerformLayout();
            this.tbpChangePass.ResumeLayout(false);
            this.tbpChangePass.PerformLayout();
            this.tbpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcSchedule;
        private System.Windows.Forms.TabPage tbpAddRecord;
        private System.Windows.Forms.TabPage tbpSeachRecord;
        private System.Windows.Forms.TabPage tbpChangePass;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtSearchVal;
        private System.Windows.Forms.ListBox lbxResults;
        private System.Windows.Forms.ComboBox cmbSearchCrit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.TabPage tbpReport;
        private System.Windows.Forms.Button btnGenRep;
        private System.Windows.Forms.Button btnSaveRep;
        private System.Windows.Forms.Button btnOpenRep;
        private System.Windows.Forms.Label lblSearchVal;
        private System.Windows.Forms.Label lblSearchCrit;
    }
}