namespace FuerstFinal1._0
{
    partial class frmMain
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
            this.lblWhatToDo = new System.Windows.Forms.Label();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.btnEditAnimal = new System.Windows.Forms.Button();
            this.btnAddRelationship = new System.Windows.Forms.Button();
            this.btnCheckRelationship = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(136, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "COW TRACKER";
            // 
            // lblWhatToDo
            // 
            this.lblWhatToDo.AutoSize = true;
            this.lblWhatToDo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhatToDo.Location = new System.Drawing.Point(12, 86);
            this.lblWhatToDo.Name = "lblWhatToDo";
            this.lblWhatToDo.Size = new System.Drawing.Size(287, 25);
            this.lblWhatToDo.TabIndex = 1;
            this.lblWhatToDo.Text = "What would you like to do?";
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(33, 140);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnimal.TabIndex = 2;
            this.btnAddAnimal.Text = "Add Animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // btnEditAnimal
            // 
            this.btnEditAnimal.Location = new System.Drawing.Point(33, 197);
            this.btnEditAnimal.Name = "btnEditAnimal";
            this.btnEditAnimal.Size = new System.Drawing.Size(98, 23);
            this.btnEditAnimal.TabIndex = 3;
            this.btnEditAnimal.Text = "View/Edit Animal";
            this.btnEditAnimal.UseVisualStyleBackColor = true;
            this.btnEditAnimal.Click += new System.EventHandler(this.btnEditAnimal_Click);
            // 
            // btnAddRelationship
            // 
            this.btnAddRelationship.Location = new System.Drawing.Point(33, 276);
            this.btnAddRelationship.Name = "btnAddRelationship";
            this.btnAddRelationship.Size = new System.Drawing.Size(98, 23);
            this.btnAddRelationship.TabIndex = 5;
            this.btnAddRelationship.Text = "Add Relationship";
            this.btnAddRelationship.UseVisualStyleBackColor = true;
            this.btnAddRelationship.Click += new System.EventHandler(this.btnAddRelationship_Click);
            // 
            // btnCheckRelationship
            // 
            this.btnCheckRelationship.Location = new System.Drawing.Point(32, 349);
            this.btnCheckRelationship.Name = "btnCheckRelationship";
            this.btnCheckRelationship.Size = new System.Drawing.Size(127, 23);
            this.btnCheckRelationship.TabIndex = 6;
            this.btnCheckRelationship.Text = "Check Relationship";
            this.btnCheckRelationship.UseVisualStyleBackColor = true;
            this.btnCheckRelationship.Click += new System.EventHandler(this.btnCheckRelationship_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(484, 459);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 494);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckRelationship);
            this.Controls.Add(this.btnAddRelationship);
            this.Controls.Add(this.btnEditAnimal);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.lblWhatToDo);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWhatToDo;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.Button btnEditAnimal;
        private System.Windows.Forms.Button btnAddRelationship;
        private System.Windows.Forms.Button btnCheckRelationship;
        private System.Windows.Forms.Button btnExit;
    }
}

