﻿namespace FuerstFinal1._0
{
    partial class frmAddAnimal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNotMine = new System.Windows.Forms.RadioButton();
            this.radMine = new System.Windows.Forms.RadioButton();
            this.lblHerd = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblBirthWeight = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(95, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 41);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "COW TRACKER";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(331, 601);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 601);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "NON-OPTIONAL INFO";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 110);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 13);
            this.lblID.TabIndex = 21;
            this.lblID.Text = "Animal ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 110);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 22;
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.radMale);
            this.grpGender.Controls.Add(this.radFemale);
            this.grpGender.Controls.Add(this.label2);
            this.grpGender.Location = new System.Drawing.Point(15, 151);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(228, 36);
            this.grpGender.TabIndex = 23;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "groupBox1";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(156, 13);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 2;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Checked = true;
            this.radFemale.Location = new System.Drawing.Point(76, 13);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 1;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gender";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNotMine);
            this.groupBox1.Controls.Add(this.radMine);
            this.groupBox1.Controls.Add(this.lblHerd);
            this.groupBox1.Location = new System.Drawing.Point(15, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 39);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radNotMine
            // 
            this.radNotMine.AutoSize = true;
            this.radNotMine.Location = new System.Drawing.Point(156, 15);
            this.radNotMine.Name = "radNotMine";
            this.radNotMine.Size = new System.Drawing.Size(68, 17);
            this.radNotMine.TabIndex = 2;
            this.radNotMine.TabStop = true;
            this.radNotMine.Text = "Not Mine";
            this.radNotMine.UseVisualStyleBackColor = true;
            // 
            // radMine
            // 
            this.radMine.AutoSize = true;
            this.radMine.Checked = true;
            this.radMine.Location = new System.Drawing.Point(76, 15);
            this.radMine.Name = "radMine";
            this.radMine.Size = new System.Drawing.Size(48, 17);
            this.radMine.TabIndex = 1;
            this.radMine.TabStop = true;
            this.radMine.Text = "Mine";
            this.radMine.UseVisualStyleBackColor = true;
            // 
            // lblHerd
            // 
            this.lblHerd.AutoSize = true;
            this.lblHerd.Location = new System.Drawing.Point(12, 20);
            this.lblHerd.Name = "lblHerd";
            this.lblHerd.Size = new System.Drawing.Size(30, 13);
            this.lblHerd.TabIndex = 0;
            this.lblHerd.Text = "Herd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "OPTIONAL INFO";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(15, 292);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(49, 13);
            this.lblBirthdate.TabIndex = 26;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(91, 292);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            // 
            // lblBirthWeight
            // 
            this.lblBirthWeight.AutoSize = true;
            this.lblBirthWeight.Location = new System.Drawing.Point(15, 482);
            this.lblBirthWeight.Name = "lblBirthWeight";
            this.lblBirthWeight.Size = new System.Drawing.Size(65, 13);
            this.lblBirthWeight.TabIndex = 28;
            this.lblBirthWeight.Text = "Birth Weight";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 479);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(18, 524);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(35, 13);
            this.lblNotes.TabIndex = 30;
            this.lblNotes.Text = "Notes";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(82, 524);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(324, 71);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(250, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 636);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBirthWeight);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmAddAnimal";
            this.Text = "frmAddAnimal";
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNotMine;
        private System.Windows.Forms.RadioButton radMine;
        private System.Windows.Forms.Label lblHerd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblBirthWeight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSave;
    }
}