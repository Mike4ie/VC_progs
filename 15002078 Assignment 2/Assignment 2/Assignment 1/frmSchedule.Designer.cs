namespace Assignment_3
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
            this.components = new System.ComponentModel.Container();
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
            this.lblSearchVal = new System.Windows.Forms.Label();
            this.lblSearchCrit = new System.Windows.Forms.Label();
            this.txtSearchVal = new System.Windows.Forms.TextBox();
            this.lbxResults = new System.Windows.Forms.ListBox();
            this.cmbSearchCrit = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbpAddAppointment = new System.Windows.Forms.TabPage();
            this.txtAddDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPPhonenum = new System.Windows.Forms.Label();
            this.txtAddPhonenum = new System.Windows.Forms.TextBox();
            this.lblPSurname = new System.Windows.Forms.Label();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblTimeslot = new System.Windows.Forms.Label();
            this.tbpDeleteAppointment = new System.Windows.Forms.TabPage();
            this.btnDelFind = new System.Windows.Forms.Button();
            this.lblDelName = new System.Windows.Forms.Label();
            this.lblDelDate = new System.Windows.Forms.Label();
            this.lblDelTime = new System.Windows.Forms.Label();
            this.lblDelAvail = new System.Windows.Forms.Label();
            this.lblDelID = new System.Windows.Forms.Label();
            this.lblDelSur = new System.Windows.Forms.Label();
            this.txtDelAppID = new System.Windows.Forms.TextBox();
            this.lblDeleteApp = new System.Windows.Forms.Label();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.tbpEditAppointment = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEDUpdate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblEdAvail = new System.Windows.Forms.Label();
            this.txtEDSur = new System.Windows.Forms.TextBox();
            this.txtEDName = new System.Windows.Forms.TextBox();
            this.txtEDDate = new System.Windows.Forms.TextBox();
            this.txtEDTime = new System.Windows.Forms.TextBox();
            this.txtEDAvail = new System.Windows.Forms.TextBox();
            this.txtEDID = new System.Windows.Forms.TextBox();
            this.btnEdFind = new System.Windows.Forms.Button();
            this.tbpChangePass = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.tbpReport = new System.Windows.Forms.TabPage();
            this.btnOpenRep = new System.Windows.Forms.Button();
            this.btnGenRep = new System.Windows.Forms.Button();
            this.btnSaveRep = new System.Windows.Forms.Button();
            this.tbpSearch = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSrSur = new System.Windows.Forms.TextBox();
            this.txtSrName = new System.Windows.Forms.TextBox();
            this.txtSrDate = new System.Windows.Forms.TextBox();
            this.txtSrTime = new System.Windows.Forms.TextBox();
            this.btnDataSearch = new System.Windows.Forms.Button();
            this.txtSrID = new System.Windows.Forms.TextBox();
            this.tbpDatabase = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAddID = new System.Windows.Forms.TextBox();
            this.txtAddTime = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtAddAvail = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblDelPhone = new System.Windows.Forms.Label();
            this.txtSrAvail = new System.Windows.Forms.TextBox();
            this.tIMESLOTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSAVAILIBLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTPHONENUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPPOINTMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aPPOINTMENTSDataSet = new Assignment_3.APPOINTMENTSDataSet();
            this.aPPOINTMENTTableAdapter = new Assignment_3.APPOINTMENTSDataSetTableAdapters.APPOINTMENTTableAdapter();
            this.txtEDPhone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtgSearch = new System.Windows.Forms.DataGridView();
            this.tIMESLOTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSAVAILIBLEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTSURNAMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pATIENTPHONENUMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSrPhone = new System.Windows.Forms.TextBox();
            this.tbcSchedule.SuspendLayout();
            this.tbpAddRecord.SuspendLayout();
            this.tbpSeachRecord.SuspendLayout();
            this.tbpAddAppointment.SuspendLayout();
            this.tbpDeleteAppointment.SuspendLayout();
            this.tbpEditAppointment.SuspendLayout();
            this.tbpChangePass.SuspendLayout();
            this.tbpReport.SuspendLayout();
            this.tbpSearch.SuspendLayout();
            this.tbpDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcSchedule
            // 
            this.tbcSchedule.Controls.Add(this.tbpAddRecord);
            this.tbcSchedule.Controls.Add(this.tbpSeachRecord);
            this.tbcSchedule.Controls.Add(this.tbpAddAppointment);
            this.tbcSchedule.Controls.Add(this.tbpDeleteAppointment);
            this.tbcSchedule.Controls.Add(this.tbpEditAppointment);
            this.tbcSchedule.Controls.Add(this.tbpChangePass);
            this.tbcSchedule.Controls.Add(this.tbpReport);
            this.tbcSchedule.Controls.Add(this.tbpSearch);
            this.tbcSchedule.Controls.Add(this.tbpDatabase);
            this.tbcSchedule.Location = new System.Drawing.Point(12, 12);
            this.tbcSchedule.Multiline = true;
            this.tbcSchedule.Name = "tbcSchedule";
            this.tbcSchedule.SelectedIndex = 0;
            this.tbcSchedule.Size = new System.Drawing.Size(512, 548);
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
            this.tbpAddRecord.Location = new System.Drawing.Point(4, 40);
            this.tbpAddRecord.Name = "tbpAddRecord";
            this.tbpAddRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddRecord.Size = new System.Drawing.Size(504, 504);
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
            this.tbpSeachRecord.Location = new System.Drawing.Point(4, 40);
            this.tbpSeachRecord.Name = "tbpSeachRecord";
            this.tbpSeachRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSeachRecord.Size = new System.Drawing.Size(504, 504);
            this.tbpSeachRecord.TabIndex = 1;
            this.tbpSeachRecord.Text = "Patient Search";
            this.tbpSeachRecord.UseVisualStyleBackColor = true;
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
            // lblSearchCrit
            // 
            this.lblSearchCrit.AutoSize = true;
            this.lblSearchCrit.Location = new System.Drawing.Point(25, 31);
            this.lblSearchCrit.Name = "lblSearchCrit";
            this.lblSearchCrit.Size = new System.Drawing.Size(75, 13);
            this.lblSearchCrit.TabIndex = 4;
            this.lblSearchCrit.Text = "Search criteria";
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
            // tbpAddAppointment
            // 
            this.tbpAddAppointment.Controls.Add(this.label23);
            this.tbpAddAppointment.Controls.Add(this.txtAddAvail);
            this.tbpAddAppointment.Controls.Add(this.label22);
            this.tbpAddAppointment.Controls.Add(this.txtAddTime);
            this.tbpAddAppointment.Controls.Add(this.txtAddID);
            this.tbpAddAppointment.Controls.Add(this.txtAddDate);
            this.tbpAddAppointment.Controls.Add(this.label1);
            this.tbpAddAppointment.Controls.Add(this.btnAdd);
            this.tbpAddAppointment.Controls.Add(this.lblPPhonenum);
            this.tbpAddAppointment.Controls.Add(this.txtAddPhonenum);
            this.tbpAddAppointment.Controls.Add(this.lblPSurname);
            this.tbpAddAppointment.Controls.Add(this.txtAddSurname);
            this.tbpAddAppointment.Controls.Add(this.lblPName);
            this.tbpAddAppointment.Controls.Add(this.txtAddName);
            this.tbpAddAppointment.Controls.Add(this.lblTimeslot);
            this.tbpAddAppointment.Location = new System.Drawing.Point(4, 40);
            this.tbpAddAppointment.Name = "tbpAddAppointment";
            this.tbpAddAppointment.Size = new System.Drawing.Size(504, 504);
            this.tbpAddAppointment.TabIndex = 4;
            this.tbpAddAppointment.Text = "Add Appointment";
            this.tbpAddAppointment.UseVisualStyleBackColor = true;
            this.tbpAddAppointment.Click += new System.EventHandler(this.tbpAddAppointment_Click);
            // 
            // txtAddDate
            // 
            this.txtAddDate.Location = new System.Drawing.Point(31, 83);
            this.txtAddDate.Name = "txtAddDate";
            this.txtAddDate.Size = new System.Drawing.Size(100, 20);
            this.txtAddDate.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Appointment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPPhonenum
            // 
            this.lblPPhonenum.AutoSize = true;
            this.lblPPhonenum.Location = new System.Drawing.Point(225, 201);
            this.lblPPhonenum.Name = "lblPPhonenum";
            this.lblPPhonenum.Size = new System.Drawing.Size(112, 13);
            this.lblPPhonenum.TabIndex = 7;
            this.lblPPhonenum.Text = "Patient Phone number";
            // 
            // txtAddPhonenum
            // 
            this.txtAddPhonenum.Location = new System.Drawing.Point(31, 188);
            this.txtAddPhonenum.Name = "txtAddPhonenum";
            this.txtAddPhonenum.Size = new System.Drawing.Size(100, 20);
            this.txtAddPhonenum.TabIndex = 6;
            // 
            // lblPSurname
            // 
            this.lblPSurname.AutoSize = true;
            this.lblPSurname.Location = new System.Drawing.Point(225, 175);
            this.lblPSurname.Name = "lblPSurname";
            this.lblPSurname.Size = new System.Drawing.Size(85, 13);
            this.lblPSurname.TabIndex = 5;
            this.lblPSurname.Text = "Patient Surname";
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(31, 162);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(100, 20);
            this.txtAddSurname.TabIndex = 4;
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Location = new System.Drawing.Point(225, 143);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(71, 13);
            this.lblPName.TabIndex = 3;
            this.lblPName.Text = "Patient Name";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(31, 136);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(100, 20);
            this.txtAddName.TabIndex = 2;
            // 
            // lblTimeslot
            // 
            this.lblTimeslot.AutoSize = true;
            this.lblTimeslot.Location = new System.Drawing.Point(223, 57);
            this.lblTimeslot.Name = "lblTimeslot";
            this.lblTimeslot.Size = new System.Drawing.Size(46, 13);
            this.lblTimeslot.TabIndex = 1;
            this.lblTimeslot.Text = "Timeslot";
            // 
            // tbpDeleteAppointment
            // 
            this.tbpDeleteAppointment.Controls.Add(this.lblDelPhone);
            this.tbpDeleteAppointment.Controls.Add(this.btnDelFind);
            this.tbpDeleteAppointment.Controls.Add(this.lblDelName);
            this.tbpDeleteAppointment.Controls.Add(this.lblDelDate);
            this.tbpDeleteAppointment.Controls.Add(this.lblDelTime);
            this.tbpDeleteAppointment.Controls.Add(this.lblDelAvail);
            this.tbpDeleteAppointment.Controls.Add(this.lblDelID);
            this.tbpDeleteAppointment.Controls.Add(this.lblDelSur);
            this.tbpDeleteAppointment.Controls.Add(this.txtDelAppID);
            this.tbpDeleteAppointment.Controls.Add(this.lblDeleteApp);
            this.tbpDeleteAppointment.Controls.Add(this.btnDeleteAppointment);
            this.tbpDeleteAppointment.Location = new System.Drawing.Point(4, 40);
            this.tbpDeleteAppointment.Name = "tbpDeleteAppointment";
            this.tbpDeleteAppointment.Size = new System.Drawing.Size(504, 504);
            this.tbpDeleteAppointment.TabIndex = 5;
            this.tbpDeleteAppointment.Text = "Delete Appointment";
            this.tbpDeleteAppointment.UseVisualStyleBackColor = true;
            // 
            // btnDelFind
            // 
            this.btnDelFind.Location = new System.Drawing.Point(51, 48);
            this.btnDelFind.Name = "btnDelFind";
            this.btnDelFind.Size = new System.Drawing.Size(75, 23);
            this.btnDelFind.TabIndex = 10;
            this.btnDelFind.Text = "Find";
            this.btnDelFind.UseVisualStyleBackColor = true;
            this.btnDelFind.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblDelName
            // 
            this.lblDelName.AutoSize = true;
            this.lblDelName.Location = new System.Drawing.Point(25, 186);
            this.lblDelName.Name = "lblDelName";
            this.lblDelName.Size = new System.Drawing.Size(71, 13);
            this.lblDelName.TabIndex = 9;
            this.lblDelName.Text = "Patient Name";
            // 
            // lblDelDate
            // 
            this.lblDelDate.AutoSize = true;
            this.lblDelDate.Location = new System.Drawing.Point(25, 164);
            this.lblDelDate.Name = "lblDelDate";
            this.lblDelDate.Size = new System.Drawing.Size(30, 13);
            this.lblDelDate.TabIndex = 8;
            this.lblDelDate.Text = "Date";
            // 
            // lblDelTime
            // 
            this.lblDelTime.AutoSize = true;
            this.lblDelTime.Location = new System.Drawing.Point(25, 139);
            this.lblDelTime.Name = "lblDelTime";
            this.lblDelTime.Size = new System.Drawing.Size(46, 13);
            this.lblDelTime.TabIndex = 7;
            this.lblDelTime.Text = "Timeslot";
            // 
            // lblDelAvail
            // 
            this.lblDelAvail.AutoSize = true;
            this.lblDelAvail.Location = new System.Drawing.Point(25, 116);
            this.lblDelAvail.Name = "lblDelAvail";
            this.lblDelAvail.Size = new System.Drawing.Size(48, 13);
            this.lblDelAvail.TabIndex = 6;
            this.lblDelAvail.Text = "Availibity";
            // 
            // lblDelID
            // 
            this.lblDelID.AutoSize = true;
            this.lblDelID.Location = new System.Drawing.Point(25, 93);
            this.lblDelID.Name = "lblDelID";
            this.lblDelID.Size = new System.Drawing.Size(80, 13);
            this.lblDelID.TabIndex = 5;
            this.lblDelID.Text = "Appointment ID";
            // 
            // lblDelSur
            // 
            this.lblDelSur.AutoSize = true;
            this.lblDelSur.Location = new System.Drawing.Point(25, 208);
            this.lblDelSur.Name = "lblDelSur";
            this.lblDelSur.Size = new System.Drawing.Size(85, 13);
            this.lblDelSur.TabIndex = 4;
            this.lblDelSur.Text = "Patient Surname";
            // 
            // txtDelAppID
            // 
            this.txtDelAppID.Location = new System.Drawing.Point(25, 22);
            this.txtDelAppID.Name = "txtDelAppID";
            this.txtDelAppID.Size = new System.Drawing.Size(131, 20);
            this.txtDelAppID.TabIndex = 3;
            // 
            // lblDeleteApp
            // 
            this.lblDeleteApp.AutoSize = true;
            this.lblDeleteApp.Location = new System.Drawing.Point(189, 25);
            this.lblDeleteApp.Name = "lblDeleteApp";
            this.lblDeleteApp.Size = new System.Drawing.Size(80, 13);
            this.lblDeleteApp.TabIndex = 2;
            this.lblDeleteApp.Text = "Appointment ID";
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Location = new System.Drawing.Point(25, 305);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(131, 23);
            this.btnDeleteAppointment.TabIndex = 1;
            this.btnDeleteAppointment.Text = "Delete Appointment";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // tbpEditAppointment
            // 
            this.tbpEditAppointment.Controls.Add(this.label16);
            this.tbpEditAppointment.Controls.Add(this.txtEDPhone);
            this.tbpEditAppointment.Controls.Add(this.label15);
            this.tbpEditAppointment.Controls.Add(this.btnEDUpdate);
            this.tbpEditAppointment.Controls.Add(this.label14);
            this.tbpEditAppointment.Controls.Add(this.label13);
            this.tbpEditAppointment.Controls.Add(this.label12);
            this.tbpEditAppointment.Controls.Add(this.label11);
            this.tbpEditAppointment.Controls.Add(this.lblEdAvail);
            this.tbpEditAppointment.Controls.Add(this.txtEDSur);
            this.tbpEditAppointment.Controls.Add(this.txtEDName);
            this.tbpEditAppointment.Controls.Add(this.txtEDDate);
            this.tbpEditAppointment.Controls.Add(this.txtEDTime);
            this.tbpEditAppointment.Controls.Add(this.txtEDAvail);
            this.tbpEditAppointment.Controls.Add(this.txtEDID);
            this.tbpEditAppointment.Controls.Add(this.btnEdFind);
            this.tbpEditAppointment.Location = new System.Drawing.Point(4, 40);
            this.tbpEditAppointment.Name = "tbpEditAppointment";
            this.tbpEditAppointment.Size = new System.Drawing.Size(504, 504);
            this.tbpEditAppointment.TabIndex = 6;
            this.tbpEditAppointment.Text = "Edit Appointment";
            this.tbpEditAppointment.UseVisualStyleBackColor = true;
            this.tbpEditAppointment.Click += new System.EventHandler(this.tbpEditAppointment_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(200, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Appointment ID";
            // 
            // btnEDUpdate
            // 
            this.btnEDUpdate.Location = new System.Drawing.Point(88, 252);
            this.btnEDUpdate.Name = "btnEDUpdate";
            this.btnEDUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnEDUpdate.TabIndex = 12;
            this.btnEDUpdate.Text = "Update";
            this.btnEDUpdate.UseVisualStyleBackColor = true;
            this.btnEDUpdate.Click += new System.EventHandler(this.btnEDUpdate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(150, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Patient Surname";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(147, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Patient Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(147, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Timeslot";
            // 
            // lblEdAvail
            // 
            this.lblEdAvail.AutoSize = true;
            this.lblEdAvail.Location = new System.Drawing.Point(147, 85);
            this.lblEdAvail.Name = "lblEdAvail";
            this.lblEdAvail.Size = new System.Drawing.Size(48, 13);
            this.lblEdAvail.TabIndex = 7;
            this.lblEdAvail.Text = "Availibity";
            // 
            // txtEDSur
            // 
            this.txtEDSur.Location = new System.Drawing.Point(40, 187);
            this.txtEDSur.Name = "txtEDSur";
            this.txtEDSur.Size = new System.Drawing.Size(100, 20);
            this.txtEDSur.TabIndex = 6;
            // 
            // txtEDName
            // 
            this.txtEDName.Location = new System.Drawing.Point(40, 160);
            this.txtEDName.Name = "txtEDName";
            this.txtEDName.Size = new System.Drawing.Size(100, 20);
            this.txtEDName.TabIndex = 5;
            // 
            // txtEDDate
            // 
            this.txtEDDate.Location = new System.Drawing.Point(40, 133);
            this.txtEDDate.Name = "txtEDDate";
            this.txtEDDate.Size = new System.Drawing.Size(100, 20);
            this.txtEDDate.TabIndex = 4;
            // 
            // txtEDTime
            // 
            this.txtEDTime.Location = new System.Drawing.Point(40, 106);
            this.txtEDTime.Name = "txtEDTime";
            this.txtEDTime.Size = new System.Drawing.Size(100, 20);
            this.txtEDTime.TabIndex = 3;
            // 
            // txtEDAvail
            // 
            this.txtEDAvail.Location = new System.Drawing.Point(40, 79);
            this.txtEDAvail.Name = "txtEDAvail";
            this.txtEDAvail.Size = new System.Drawing.Size(100, 20);
            this.txtEDAvail.TabIndex = 2;
            // 
            // txtEDID
            // 
            this.txtEDID.Location = new System.Drawing.Point(40, 24);
            this.txtEDID.Name = "txtEDID";
            this.txtEDID.Size = new System.Drawing.Size(100, 20);
            this.txtEDID.TabIndex = 1;
            // 
            // btnEdFind
            // 
            this.btnEdFind.Location = new System.Drawing.Point(88, 50);
            this.btnEdFind.Name = "btnEdFind";
            this.btnEdFind.Size = new System.Drawing.Size(75, 23);
            this.btnEdFind.TabIndex = 0;
            this.btnEdFind.Text = "Find";
            this.btnEdFind.UseVisualStyleBackColor = true;
            this.btnEdFind.Click += new System.EventHandler(this.button1_Click_1);
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
            this.tbpChangePass.Location = new System.Drawing.Point(4, 40);
            this.tbpChangePass.Name = "tbpChangePass";
            this.tbpChangePass.Size = new System.Drawing.Size(504, 504);
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
            this.tbpReport.Location = new System.Drawing.Point(4, 40);
            this.tbpReport.Name = "tbpReport";
            this.tbpReport.Size = new System.Drawing.Size(504, 504);
            this.tbpReport.TabIndex = 3;
            this.tbpReport.Text = "Report";
            this.tbpReport.UseVisualStyleBackColor = true;
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
            // tbpSearch
            // 
            this.tbpSearch.Controls.Add(this.txtSrPhone);
            this.tbpSearch.Controls.Add(this.label17);
            this.tbpSearch.Controls.Add(this.dtgSearch);
            this.tbpSearch.Controls.Add(this.txtSrAvail);
            this.tbpSearch.Controls.Add(this.label9);
            this.tbpSearch.Controls.Add(this.label8);
            this.tbpSearch.Controls.Add(this.label7);
            this.tbpSearch.Controls.Add(this.label4);
            this.tbpSearch.Controls.Add(this.label3);
            this.tbpSearch.Controls.Add(this.label2);
            this.tbpSearch.Controls.Add(this.txtSrSur);
            this.tbpSearch.Controls.Add(this.txtSrName);
            this.tbpSearch.Controls.Add(this.txtSrDate);
            this.tbpSearch.Controls.Add(this.txtSrTime);
            this.tbpSearch.Controls.Add(this.btnDataSearch);
            this.tbpSearch.Controls.Add(this.txtSrID);
            this.tbpSearch.Location = new System.Drawing.Point(4, 40);
            this.tbpSearch.Name = "tbpSearch";
            this.tbpSearch.Size = new System.Drawing.Size(504, 504);
            this.tbpSearch.TabIndex = 7;
            this.tbpSearch.Text = "Search";
            this.tbpSearch.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Patient Surname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Patient Name";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Timeslot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Availibilty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Appointment ID";
            // 
            // txtSrSur
            // 
            this.txtSrSur.Location = new System.Drawing.Point(42, 152);
            this.txtSrSur.Name = "txtSrSur";
            this.txtSrSur.Size = new System.Drawing.Size(100, 20);
            this.txtSrSur.TabIndex = 6;
            // 
            // txtSrName
            // 
            this.txtSrName.Location = new System.Drawing.Point(42, 126);
            this.txtSrName.Name = "txtSrName";
            this.txtSrName.Size = new System.Drawing.Size(100, 20);
            this.txtSrName.TabIndex = 5;
            // 
            // txtSrDate
            // 
            this.txtSrDate.Location = new System.Drawing.Point(42, 100);
            this.txtSrDate.Name = "txtSrDate";
            this.txtSrDate.Size = new System.Drawing.Size(100, 20);
            this.txtSrDate.TabIndex = 4;
            // 
            // txtSrTime
            // 
            this.txtSrTime.Location = new System.Drawing.Point(42, 74);
            this.txtSrTime.Name = "txtSrTime";
            this.txtSrTime.Size = new System.Drawing.Size(100, 20);
            this.txtSrTime.TabIndex = 3;
            // 
            // btnDataSearch
            // 
            this.btnDataSearch.Location = new System.Drawing.Point(42, 215);
            this.btnDataSearch.Name = "btnDataSearch";
            this.btnDataSearch.Size = new System.Drawing.Size(100, 23);
            this.btnDataSearch.TabIndex = 1;
            this.btnDataSearch.Text = "Search";
            this.btnDataSearch.UseVisualStyleBackColor = true;
            this.btnDataSearch.Click += new System.EventHandler(this.btnDataSearch_Click);
            // 
            // txtSrID
            // 
            this.txtSrID.Location = new System.Drawing.Point(42, 22);
            this.txtSrID.Name = "txtSrID";
            this.txtSrID.Size = new System.Drawing.Size(100, 20);
            this.txtSrID.TabIndex = 0;
            // 
            // tbpDatabase
            // 
            this.tbpDatabase.Controls.Add(this.dataGridView1);
            this.tbpDatabase.Location = new System.Drawing.Point(4, 40);
            this.tbpDatabase.Name = "tbpDatabase";
            this.tbpDatabase.Size = new System.Drawing.Size(504, 504);
            this.tbpDatabase.TabIndex = 8;
            this.tbpDatabase.Text = "Database";
            this.tbpDatabase.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIMESLOTDataGridViewTextBoxColumn,
            this.iSAVAILIBLEDataGridViewTextBoxColumn,
            this.pATIENTNAMEDataGridViewTextBoxColumn,
            this.pATIENTSURNAMEDataGridViewTextBoxColumn,
            this.pATIENTPHONENUMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aPPOINTMENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 471);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtAddID
            // 
            this.txtAddID.Location = new System.Drawing.Point(31, 31);
            this.txtAddID.Name = "txtAddID";
            this.txtAddID.Size = new System.Drawing.Size(100, 20);
            this.txtAddID.TabIndex = 11;
            // 
            // txtAddTime
            // 
            this.txtAddTime.Location = new System.Drawing.Point(31, 57);
            this.txtAddTime.Name = "txtAddTime";
            this.txtAddTime.Size = new System.Drawing.Size(100, 20);
            this.txtAddTime.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(228, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "Appointment ID";
            // 
            // txtAddAvail
            // 
            this.txtAddAvail.Location = new System.Drawing.Point(31, 109);
            this.txtAddAvail.Name = "txtAddAvail";
            this.txtAddAvail.Size = new System.Drawing.Size(100, 20);
            this.txtAddAvail.TabIndex = 14;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(226, 115);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Availibility";
            // 
            // lblDelPhone
            // 
            this.lblDelPhone.AutoSize = true;
            this.lblDelPhone.Location = new System.Drawing.Point(25, 233);
            this.lblDelPhone.Name = "lblDelPhone";
            this.lblDelPhone.Size = new System.Drawing.Size(112, 13);
            this.lblDelPhone.TabIndex = 11;
            this.lblDelPhone.Text = "Patient Phone number";
            // 
            // txtSrAvail
            // 
            this.txtSrAvail.Location = new System.Drawing.Point(42, 48);
            this.txtSrAvail.Name = "txtSrAvail";
            this.txtSrAvail.Size = new System.Drawing.Size(100, 20);
            this.txtSrAvail.TabIndex = 13;
            // 
            // tIMESLOTDataGridViewTextBoxColumn
            // 
            this.tIMESLOTDataGridViewTextBoxColumn.DataPropertyName = "TIMESLOT";
            this.tIMESLOTDataGridViewTextBoxColumn.HeaderText = "TIMESLOT";
            this.tIMESLOTDataGridViewTextBoxColumn.Name = "tIMESLOTDataGridViewTextBoxColumn";
            // 
            // iSAVAILIBLEDataGridViewTextBoxColumn
            // 
            this.iSAVAILIBLEDataGridViewTextBoxColumn.DataPropertyName = "IS_AVAILIBLE";
            this.iSAVAILIBLEDataGridViewTextBoxColumn.HeaderText = "IS_AVAILIBLE";
            this.iSAVAILIBLEDataGridViewTextBoxColumn.Name = "iSAVAILIBLEDataGridViewTextBoxColumn";
            // 
            // pATIENTNAMEDataGridViewTextBoxColumn
            // 
            this.pATIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_NAME";
            this.pATIENTNAMEDataGridViewTextBoxColumn.HeaderText = "PATIENT_NAME";
            this.pATIENTNAMEDataGridViewTextBoxColumn.Name = "pATIENTNAMEDataGridViewTextBoxColumn";
            // 
            // pATIENTSURNAMEDataGridViewTextBoxColumn
            // 
            this.pATIENTSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_SURNAME";
            this.pATIENTSURNAMEDataGridViewTextBoxColumn.HeaderText = "PATIENT_SURNAME";
            this.pATIENTSURNAMEDataGridViewTextBoxColumn.Name = "pATIENTSURNAMEDataGridViewTextBoxColumn";
            // 
            // pATIENTPHONENUMDataGridViewTextBoxColumn
            // 
            this.pATIENTPHONENUMDataGridViewTextBoxColumn.DataPropertyName = "PATIENT_PHONENUM";
            this.pATIENTPHONENUMDataGridViewTextBoxColumn.HeaderText = "PATIENT_PHONENUM";
            this.pATIENTPHONENUMDataGridViewTextBoxColumn.Name = "pATIENTPHONENUMDataGridViewTextBoxColumn";
            // 
            // aPPOINTMENTBindingSource
            // 
            this.aPPOINTMENTBindingSource.DataMember = "APPOINTMENT";
            this.aPPOINTMENTBindingSource.DataSource = this.aPPOINTMENTSDataSet;
            // 
            // aPPOINTMENTSDataSet
            // 
            this.aPPOINTMENTSDataSet.DataSetName = "APPOINTMENTSDataSet";
            this.aPPOINTMENTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aPPOINTMENTTableAdapter
            // 
            this.aPPOINTMENTTableAdapter.ClearBeforeFill = true;
            // 
            // txtEDPhone
            // 
            this.txtEDPhone.Location = new System.Drawing.Point(40, 214);
            this.txtEDPhone.Name = "txtEDPhone";
            this.txtEDPhone.Size = new System.Drawing.Size(100, 20);
            this.txtEDPhone.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(150, 220);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Patient Phone number";
            // 
            // dtgSearch
            // 
            this.dtgSearch.AutoGenerateColumns = false;
            this.dtgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIMESLOTDataGridViewTextBoxColumn1,
            this.iSAVAILIBLEDataGridViewTextBoxColumn1,
            this.pATIENTNAMEDataGridViewTextBoxColumn1,
            this.pATIENTSURNAMEDataGridViewTextBoxColumn1,
            this.pATIENTPHONENUMDataGridViewTextBoxColumn1});
            this.dtgSearch.DataSource = this.aPPOINTMENTBindingSource;
            this.dtgSearch.Location = new System.Drawing.Point(42, 244);
            this.dtgSearch.Name = "dtgSearch";
            this.dtgSearch.Size = new System.Drawing.Size(416, 264);
            this.dtgSearch.TabIndex = 14;
            // 
            // tIMESLOTDataGridViewTextBoxColumn1
            // 
            this.tIMESLOTDataGridViewTextBoxColumn1.DataPropertyName = "TIMESLOT";
            this.tIMESLOTDataGridViewTextBoxColumn1.HeaderText = "TIMESLOT";
            this.tIMESLOTDataGridViewTextBoxColumn1.Name = "tIMESLOTDataGridViewTextBoxColumn1";
            // 
            // iSAVAILIBLEDataGridViewTextBoxColumn1
            // 
            this.iSAVAILIBLEDataGridViewTextBoxColumn1.DataPropertyName = "IS_AVAILIBLE";
            this.iSAVAILIBLEDataGridViewTextBoxColumn1.HeaderText = "IS_AVAILIBLE";
            this.iSAVAILIBLEDataGridViewTextBoxColumn1.Name = "iSAVAILIBLEDataGridViewTextBoxColumn1";
            // 
            // pATIENTNAMEDataGridViewTextBoxColumn1
            // 
            this.pATIENTNAMEDataGridViewTextBoxColumn1.DataPropertyName = "PATIENT_NAME";
            this.pATIENTNAMEDataGridViewTextBoxColumn1.HeaderText = "PATIENT_NAME";
            this.pATIENTNAMEDataGridViewTextBoxColumn1.Name = "pATIENTNAMEDataGridViewTextBoxColumn1";
            // 
            // pATIENTSURNAMEDataGridViewTextBoxColumn1
            // 
            this.pATIENTSURNAMEDataGridViewTextBoxColumn1.DataPropertyName = "PATIENT_SURNAME";
            this.pATIENTSURNAMEDataGridViewTextBoxColumn1.HeaderText = "PATIENT_SURNAME";
            this.pATIENTSURNAMEDataGridViewTextBoxColumn1.Name = "pATIENTSURNAMEDataGridViewTextBoxColumn1";
            // 
            // pATIENTPHONENUMDataGridViewTextBoxColumn1
            // 
            this.pATIENTPHONENUMDataGridViewTextBoxColumn1.DataPropertyName = "PATIENT_PHONENUM";
            this.pATIENTPHONENUMDataGridViewTextBoxColumn1.HeaderText = "PATIENT_PHONENUM";
            this.pATIENTPHONENUMDataGridViewTextBoxColumn1.Name = "pATIENTPHONENUMDataGridViewTextBoxColumn1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(148, 181);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Patient Phone number";
            // 
            // txtSrPhone
            // 
            this.txtSrPhone.Location = new System.Drawing.Point(42, 178);
            this.txtSrPhone.Name = "txtSrPhone";
            this.txtSrPhone.Size = new System.Drawing.Size(100, 20);
            this.txtSrPhone.TabIndex = 16;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 561);
            this.Controls.Add(this.tbcSchedule);
            this.Name = "frmSchedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            this.tbcSchedule.ResumeLayout(false);
            this.tbpAddRecord.ResumeLayout(false);
            this.tbpAddRecord.PerformLayout();
            this.tbpSeachRecord.ResumeLayout(false);
            this.tbpSeachRecord.PerformLayout();
            this.tbpAddAppointment.ResumeLayout(false);
            this.tbpAddAppointment.PerformLayout();
            this.tbpDeleteAppointment.ResumeLayout(false);
            this.tbpDeleteAppointment.PerformLayout();
            this.tbpEditAppointment.ResumeLayout(false);
            this.tbpEditAppointment.PerformLayout();
            this.tbpChangePass.ResumeLayout(false);
            this.tbpChangePass.PerformLayout();
            this.tbpReport.ResumeLayout(false);
            this.tbpSearch.ResumeLayout(false);
            this.tbpSearch.PerformLayout();
            this.tbpDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPPOINTMENTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSearch)).EndInit();
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
        private System.Windows.Forms.TabPage tbpAddAppointment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPPhonenum;
        private System.Windows.Forms.TextBox txtAddPhonenum;
        private System.Windows.Forms.Label lblPSurname;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TabPage tbpDeleteAppointment;
        private System.Windows.Forms.TabPage tbpEditAppointment;
        private System.Windows.Forms.TabPage tbpSearch;
        private System.Windows.Forms.Label lblDeleteApp;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.TabPage tbpDatabase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private APPOINTMENTSDataSet aPPOINTMENTSDataSet;
        private System.Windows.Forms.BindingSource aPPOINTMENTBindingSource;
        private APPOINTMENTSDataSetTableAdapters.APPOINTMENTTableAdapter aPPOINTMENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMESLOTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSAVAILIBLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTPHONENUMDataGridViewTextBoxColumn;
        public System.Windows.Forms.Label lblTimeslot;
        private System.Windows.Forms.TextBox txtAddDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelAppID;
        private System.Windows.Forms.Button btnDataSearch;
        private System.Windows.Forms.TextBox txtSrID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSrSur;
        private System.Windows.Forms.TextBox txtSrName;
        private System.Windows.Forms.TextBox txtSrDate;
        private System.Windows.Forms.TextBox txtSrTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnEDUpdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEdAvail;
        private System.Windows.Forms.TextBox txtEDSur;
        private System.Windows.Forms.TextBox txtEDName;
        private System.Windows.Forms.TextBox txtEDDate;
        private System.Windows.Forms.TextBox txtEDTime;
        private System.Windows.Forms.TextBox txtEDAvail;
        private System.Windows.Forms.TextBox txtEDID;
        private System.Windows.Forms.Button btnEdFind;
        private System.Windows.Forms.Button btnDelFind;
        private System.Windows.Forms.Label lblDelName;
        private System.Windows.Forms.Label lblDelDate;
        private System.Windows.Forms.Label lblDelTime;
        private System.Windows.Forms.Label lblDelAvail;
        private System.Windows.Forms.Label lblDelID;
        private System.Windows.Forms.Label lblDelSur;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtAddTime;
        private System.Windows.Forms.TextBox txtAddID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtAddAvail;
        private System.Windows.Forms.Label lblDelPhone;
        private System.Windows.Forms.TextBox txtSrAvail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEDPhone;
        private System.Windows.Forms.DataGridView dtgSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMESLOTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSAVAILIBLEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTSURNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATIENTPHONENUMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtSrPhone;
        private System.Windows.Forms.Label label17;
    }
}