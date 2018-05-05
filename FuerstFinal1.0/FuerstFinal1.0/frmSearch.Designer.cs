namespace FuerstFinal1._0
{
    partial class frmSearch
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditThisCow = new System.Windows.Forms.Button();
            this.lstCowList = new System.Windows.Forms.ListBox();
            this.lblID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnViewCow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(215, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 41);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "COW TRACKER";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(617, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 36;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 198);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEditThisCow
            // 
            this.btnEditThisCow.Enabled = false;
            this.btnEditThisCow.Location = new System.Drawing.Point(337, 198);
            this.btnEditThisCow.Name = "btnEditThisCow";
            this.btnEditThisCow.Size = new System.Drawing.Size(141, 23);
            this.btnEditThisCow.TabIndex = 40;
            this.btnEditThisCow.Text = "Edit This Cow";
            this.btnEditThisCow.UseVisualStyleBackColor = true;
            this.btnEditThisCow.Click += new System.EventHandler(this.btnEditThisCow_Click);
            // 
            // lstCowList
            // 
            this.lstCowList.FormattingEnabled = true;
            this.lstCowList.Location = new System.Drawing.Point(394, 100);
            this.lstCowList.Name = "lstCowList";
            this.lstCowList.Size = new System.Drawing.Size(277, 69);
            this.lstCowList.TabIndex = 41;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 123);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 13);
            this.lblID.TabIndex = 42;
            this.lblID.Text = "Animal ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 43;
            // 
            // btnViewCow
            // 
            this.btnViewCow.Enabled = false;
            this.btnViewCow.Location = new System.Drawing.Point(189, 198);
            this.btnViewCow.Name = "btnViewCow";
            this.btnViewCow.Size = new System.Drawing.Size(120, 23);
            this.btnViewCow.TabIndex = 48;
            this.btnViewCow.Text = "View This Cow";
            this.btnViewCow.UseVisualStyleBackColor = true;
            this.btnViewCow.Click += new System.EventHandler(this.btnViewCow_Click);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 253);
            this.Controls.Add(this.btnViewCow);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lstCowList);
            this.Controls.Add(this.btnEditThisCow);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEditThisCow;
        private System.Windows.Forms.ListBox lstCowList;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnViewCow;
    }
}