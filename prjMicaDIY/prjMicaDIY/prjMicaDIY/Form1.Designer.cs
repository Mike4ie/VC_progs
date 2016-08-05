namespace prjMicaDIY
{
    partial class frmProduct
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(88, 213);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Show Sales";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(26, 16);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(207, 173);
            this.lstDisplay.TabIndex = 1;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnDisplay);
            this.Name = "frmProduct";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListBox lstDisplay;
    }
}

