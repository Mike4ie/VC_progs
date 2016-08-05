namespace prjBinary
{
    partial class frmBinary
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateOfTrans = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.rdbDesposit = new System.Windows.Forms.RadioButton();
            this.rdbWithdraw = new System.Windows.Forms.RadioButton();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.btnInitialise = new System.Windows.Forms.Button();
            this.btnViewTrans = new System.Windows.Forms.Button();
            this.btnAddTrans = new System.Windows.Forms.Button();
            this.btnMonthlySummary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbxTransHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox1.Location = new System.Drawing.Point(121, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblDateOfTrans
            // 
            this.lblDateOfTrans.AutoSize = true;
            this.lblDateOfTrans.Location = new System.Drawing.Point(14, 20);
            this.lblDateOfTrans.Name = "lblDateOfTrans";
            this.lblDateOfTrans.Size = new System.Drawing.Size(101, 13);
            this.lblDateOfTrans.TabIndex = 2;
            this.lblDateOfTrans.Text = "Date of Transaction";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(14, 60);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount";
            // 
            // rdbDesposit
            // 
            this.rdbDesposit.AutoSize = true;
            this.rdbDesposit.Location = new System.Drawing.Point(121, 101);
            this.rdbDesposit.Name = "rdbDesposit";
            this.rdbDesposit.Size = new System.Drawing.Size(85, 17);
            this.rdbDesposit.TabIndex = 5;
            this.rdbDesposit.TabStop = true;
            this.rdbDesposit.Text = "radioButton1";
            this.rdbDesposit.UseVisualStyleBackColor = true;
            // 
            // rdbWithdraw
            // 
            this.rdbWithdraw.AutoSize = true;
            this.rdbWithdraw.Location = new System.Drawing.Point(121, 125);
            this.rdbWithdraw.Name = "rdbWithdraw";
            this.rdbWithdraw.Size = new System.Drawing.Size(85, 17);
            this.rdbWithdraw.TabIndex = 6;
            this.rdbWithdraw.TabStop = true;
            this.rdbWithdraw.Text = "radioButton2";
            this.rdbWithdraw.UseVisualStyleBackColor = true;
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(12, 272);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(98, 13);
            this.lblTransaction.TabIndex = 7;
            this.lblTransaction.Text = "Transaction History";
            // 
            // btnInitialise
            // 
            this.btnInitialise.Location = new System.Drawing.Point(40, 378);
            this.btnInitialise.Name = "btnInitialise";
            this.btnInitialise.Size = new System.Drawing.Size(75, 23);
            this.btnInitialise.TabIndex = 9;
            this.btnInitialise.Text = "Initialise File";
            this.btnInitialise.UseVisualStyleBackColor = true;
            this.btnInitialise.Click += new System.EventHandler(this.btnInitialise_Click);
            // 
            // btnViewTrans
            // 
            this.btnViewTrans.Location = new System.Drawing.Point(122, 377);
            this.btnViewTrans.Name = "btnViewTrans";
            this.btnViewTrans.Size = new System.Drawing.Size(75, 23);
            this.btnViewTrans.TabIndex = 10;
            this.btnViewTrans.Text = "View Transaction";
            this.btnViewTrans.UseVisualStyleBackColor = true;
            // 
            // btnAddTrans
            // 
            this.btnAddTrans.Location = new System.Drawing.Point(204, 376);
            this.btnAddTrans.Name = "btnAddTrans";
            this.btnAddTrans.Size = new System.Drawing.Size(75, 23);
            this.btnAddTrans.TabIndex = 11;
            this.btnAddTrans.Text = "Add Transaction";
            this.btnAddTrans.UseVisualStyleBackColor = true;
            // 
            // btnMonthlySummary
            // 
            this.btnMonthlySummary.Location = new System.Drawing.Point(40, 408);
            this.btnMonthlySummary.Name = "btnMonthlySummary";
            this.btnMonthlySummary.Size = new System.Drawing.Size(75, 23);
            this.btnMonthlySummary.TabIndex = 12;
            this.btnMonthlySummary.Text = "Monthly Summary";
            this.btnMonthlySummary.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(122, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(204, 406);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lbxTransHistory
            // 
            this.lbxTransHistory.FormattingEnabled = true;
            this.lbxTransHistory.Location = new System.Drawing.Point(121, 163);
            this.lbxTransHistory.Name = "lbxTransHistory";
            this.lbxTransHistory.Size = new System.Drawing.Size(120, 186);
            this.lbxTransHistory.TabIndex = 15;
            // 
            // frmBinary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 464);
            this.Controls.Add(this.lbxTransHistory);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMonthlySummary);
            this.Controls.Add(this.btnAddTrans);
            this.Controls.Add(this.btnViewTrans);
            this.Controls.Add(this.btnInitialise);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.rdbWithdraw);
            this.Controls.Add(this.rdbDesposit);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDateOfTrans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmBinary";
            this.Text = "Monthly Transactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateOfTrans;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.RadioButton rdbDesposit;
        private System.Windows.Forms.RadioButton rdbWithdraw;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Button btnInitialise;
        private System.Windows.Forms.Button btnViewTrans;
        private System.Windows.Forms.Button btnAddTrans;
        private System.Windows.Forms.Button btnMonthlySummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lbxTransHistory;
    }
}

