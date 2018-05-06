namespace FuerstFinal1._0
{
    partial class frmViewAnimal
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
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblIDInfo = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblGenderInfo = new System.Windows.Forms.Label();
            this.lblHerd = new System.Windows.Forms.Label();
            this.lblHerdInfo = new System.Windows.Forms.Label();
            this.lblBirthWeight = new System.Windows.Forms.Label();
            this.lblBirthWeightInfo = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblBirthDateInfo = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(139, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 41);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "COW TRACKER";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(492, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(13, 97);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(58, 13);
            this.lblIDNumber.TabIndex = 21;
            this.lblIDNumber.Text = "ID Number";
            // 
            // lblIDInfo
            // 
            this.lblIDInfo.AutoSize = true;
            this.lblIDInfo.Location = new System.Drawing.Point(160, 97);
            this.lblIDInfo.Name = "lblIDInfo";
            this.lblIDInfo.Size = new System.Drawing.Size(81, 13);
            this.lblIDInfo.TabIndex = 22;
            this.lblIDInfo.Text = "**IDINFOHERE";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(13, 130);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 23;
            this.lblGender.Text = "Gender";
            // 
            // lblGenderInfo
            // 
            this.lblGenderInfo.AutoSize = true;
            this.lblGenderInfo.Location = new System.Drawing.Point(163, 129);
            this.lblGenderInfo.Name = "lblGenderInfo";
            this.lblGenderInfo.Size = new System.Drawing.Size(116, 13);
            this.lblGenderInfo.TabIndex = 24;
            this.lblGenderInfo.Text = "**GENDERINFOHERE";
            // 
            // lblHerd
            // 
            this.lblHerd.AutoSize = true;
            this.lblHerd.Location = new System.Drawing.Point(13, 167);
            this.lblHerd.Name = "lblHerd";
            this.lblHerd.Size = new System.Drawing.Size(30, 13);
            this.lblHerd.TabIndex = 25;
            this.lblHerd.Text = "Herd";
            // 
            // lblHerdInfo
            // 
            this.lblHerdInfo.AutoSize = true;
            this.lblHerdInfo.Location = new System.Drawing.Point(163, 167);
            this.lblHerdInfo.Name = "lblHerdInfo";
            this.lblHerdInfo.Size = new System.Drawing.Size(101, 13);
            this.lblHerdInfo.TabIndex = 26;
            this.lblHerdInfo.Text = "**HERDINFOHERE";
            // 
            // lblBirthWeight
            // 
            this.lblBirthWeight.AutoSize = true;
            this.lblBirthWeight.Location = new System.Drawing.Point(13, 237);
            this.lblBirthWeight.Name = "lblBirthWeight";
            this.lblBirthWeight.Size = new System.Drawing.Size(65, 13);
            this.lblBirthWeight.TabIndex = 31;
            this.lblBirthWeight.Text = "Birth Weight";
            // 
            // lblBirthWeightInfo
            // 
            this.lblBirthWeightInfo.AutoSize = true;
            this.lblBirthWeightInfo.Location = new System.Drawing.Point(163, 237);
            this.lblBirthWeightInfo.Name = "lblBirthWeightInfo";
            this.lblBirthWeightInfo.Size = new System.Drawing.Size(117, 13);
            this.lblBirthWeightInfo.TabIndex = 32;
            this.lblBirthWeightInfo.Text = "**BIRTHWEIGHTINFO";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(13, 203);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 33;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblBirthDateInfo
            // 
            this.lblBirthDateInfo.AutoSize = true;
            this.lblBirthDateInfo.Location = new System.Drawing.Point(163, 203);
            this.lblBirthDateInfo.Name = "lblBirthDateInfo";
            this.lblBirthDateInfo.Size = new System.Drawing.Size(102, 13);
            this.lblBirthDateInfo.TabIndex = 34;
            this.lblBirthDateInfo.Text = "**BIRTHDATEINFO";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(13, 275);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 35;
            this.lblNotes.Text = "Notes";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(146, 275);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(403, 96);
            this.rtbNotes.TabIndex = 36;
            this.rtbNotes.Text = "";
            // 
            // frmViewAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 436);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.lblBirthDateInfo);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblBirthWeightInfo);
            this.Controls.Add(this.lblBirthWeight);
            this.Controls.Add(this.lblHerdInfo);
            this.Controls.Add(this.lblHerd);
            this.Controls.Add(this.lblGenderInfo);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblIDInfo);
            this.Controls.Add(this.lblIDNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmViewAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewAnimal";
            this.Load += new System.EventHandler(this.frmViewAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblIDInfo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblGenderInfo;
        private System.Windows.Forms.Label lblHerd;
        private System.Windows.Forms.Label lblHerdInfo;
        private System.Windows.Forms.Label lblBirthWeight;
        private System.Windows.Forms.Label lblBirthWeightInfo;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblBirthDateInfo;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox rtbNotes;
    }
}