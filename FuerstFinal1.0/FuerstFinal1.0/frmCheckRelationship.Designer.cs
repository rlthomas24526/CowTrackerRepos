﻿namespace FuerstFinal1._0
{
    partial class frmCheckRelationship
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCow1 = new System.Windows.Forms.Label();
            this.lblCow2 = new System.Windows.Forms.Label();
            this.lblSafe = new System.Windows.Forms.Label();
            this.lblNotSafe = new System.Windows.Forms.Label();
            this.lstCow1 = new System.Windows.Forms.ListBox();
            this.lstCow2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 41);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "COW TRACKER";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(233, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(95, 422);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(132, 23);
            this.btnCheck.TabIndex = 36;
            this.btnCheck.Text = "Check Relationship";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 422);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCow1
            // 
            this.lblCow1.AutoSize = true;
            this.lblCow1.Location = new System.Drawing.Point(29, 97);
            this.lblCow1.Name = "lblCow1";
            this.lblCow1.Size = new System.Drawing.Size(37, 13);
            this.lblCow1.TabIndex = 39;
            this.lblCow1.Text = "Cow 1";
            // 
            // lblCow2
            // 
            this.lblCow2.AutoSize = true;
            this.lblCow2.Location = new System.Drawing.Point(29, 223);
            this.lblCow2.Name = "lblCow2";
            this.lblCow2.Size = new System.Drawing.Size(37, 13);
            this.lblCow2.TabIndex = 41;
            this.lblCow2.Text = "Cow 2";
            // 
            // lblSafe
            // 
            this.lblSafe.AutoSize = true;
            this.lblSafe.Location = new System.Drawing.Point(112, 332);
            this.lblSafe.Name = "lblSafe";
            this.lblSafe.Size = new System.Drawing.Size(92, 13);
            this.lblSafe.TabIndex = 43;
            this.lblSafe.Text = "SAFE TO BREED";
            this.lblSafe.Visible = false;
            // 
            // lblNotSafe
            // 
            this.lblNotSafe.AutoSize = true;
            this.lblNotSafe.Location = new System.Drawing.Point(97, 366);
            this.lblNotSafe.Name = "lblNotSafe";
            this.lblNotSafe.Size = new System.Drawing.Size(118, 13);
            this.lblNotSafe.TabIndex = 44;
            this.lblNotSafe.Text = "NOT SAFE TO BREED";
            this.lblNotSafe.Visible = false;
            // 
            // lstCow1
            // 
            this.lstCow1.FormattingEnabled = true;
            this.lstCow1.Location = new System.Drawing.Point(95, 97);
            this.lstCow1.Name = "lstCow1";
            this.lstCow1.Size = new System.Drawing.Size(120, 95);
            this.lstCow1.TabIndex = 45;
            this.lstCow1.SelectedIndexChanged += new System.EventHandler(this.lstCow1_SelectedIndexChanged);
            // 
            // lstCow2
            // 
            this.lstCow2.FormattingEnabled = true;
            this.lstCow2.Location = new System.Drawing.Point(95, 223);
            this.lstCow2.Name = "lstCow2";
            this.lstCow2.Size = new System.Drawing.Size(120, 95);
            this.lstCow2.TabIndex = 46;
            this.lstCow2.SelectedIndexChanged += new System.EventHandler(this.lstCow2_SelectedIndexChanged);
            // 
            // frmCheckRelationship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 457);
            this.Controls.Add(this.lstCow2);
            this.Controls.Add(this.lstCow1);
            this.Controls.Add(this.lblNotSafe);
            this.Controls.Add(this.lblSafe);
            this.Controls.Add(this.lblCow2);
            this.Controls.Add(this.lblCow1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmCheckRelationship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckRelationship";
            this.Load += new System.EventHandler(this.frmCheckRelationship_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCow1;
        private System.Windows.Forms.Label lblCow2;
        private System.Windows.Forms.Label lblSafe;
        private System.Windows.Forms.Label lblNotSafe;
        private System.Windows.Forms.ListBox lstCow1;
        private System.Windows.Forms.ListBox lstCow2;
    }
}