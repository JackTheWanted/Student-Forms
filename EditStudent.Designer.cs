namespace Student_Forms
{
    partial class EditStudent
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
            this.lblPrevStudentName = new System.Windows.Forms.Label();
            this.btnEditFirst = new System.Windows.Forms.Button();
            this.btnEditLast = new System.Windows.Forms.Button();
            this.btnEditBoth = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEditMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrevStudentName
            // 
            this.lblPrevStudentName.AutoSize = true;
            this.lblPrevStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrevStudentName.Location = new System.Drawing.Point(2, 9);
            this.lblPrevStudentName.Name = "lblPrevStudentName";
            this.lblPrevStudentName.Size = new System.Drawing.Size(301, 25);
            this.lblPrevStudentName.TabIndex = 0;
            this.lblPrevStudentName.Text = "The student\'s current name is:";
            // 
            // btnEditFirst
            // 
            this.btnEditFirst.Location = new System.Drawing.Point(293, 52);
            this.btnEditFirst.Name = "btnEditFirst";
            this.btnEditFirst.Size = new System.Drawing.Size(107, 23);
            this.btnEditFirst.TabIndex = 1;
            this.btnEditFirst.Text = "Change First Name";
            this.btnEditFirst.UseVisualStyleBackColor = true;
            this.btnEditFirst.Click += new System.EventHandler(this.btnEditFirst_Click);
            // 
            // btnEditLast
            // 
            this.btnEditLast.Location = new System.Drawing.Point(293, 100);
            this.btnEditLast.Name = "btnEditLast";
            this.btnEditLast.Size = new System.Drawing.Size(107, 23);
            this.btnEditLast.TabIndex = 2;
            this.btnEditLast.Text = "Change Last Name";
            this.btnEditLast.UseVisualStyleBackColor = true;
            this.btnEditLast.Click += new System.EventHandler(this.btnEditLast_Click);
            // 
            // btnEditBoth
            // 
            this.btnEditBoth.Location = new System.Drawing.Point(120, 137);
            this.btnEditBoth.Name = "btnEditBoth";
            this.btnEditBoth.Size = new System.Drawing.Size(148, 23);
            this.btnEditBoth.TabIndex = 3;
            this.btnEditBoth.Text = "Change Both";
            this.btnEditBoth.UseVisualStyleBackColor = true;
            this.btnEditBoth.Click += new System.EventHandler(this.btnEditBoth_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 52);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(148, 20);
            this.txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(148, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "New first name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "New last name:";
            // 
            // lblEditMessage
            // 
            this.lblEditMessage.AutoSize = true;
            this.lblEditMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditMessage.Location = new System.Drawing.Point(2, 175);
            this.lblEditMessage.Name = "lblEditMessage";
            this.lblEditMessage.Size = new System.Drawing.Size(0, 25);
            this.lblEditMessage.TabIndex = 8;
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 209);
            this.Controls.Add(this.lblEditMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnEditBoth);
            this.Controls.Add(this.btnEditLast);
            this.Controls.Add(this.btnEditFirst);
            this.Controls.Add(this.lblPrevStudentName);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrevStudentName;
        private System.Windows.Forms.Button btnEditFirst;
        private System.Windows.Forms.Button btnEditLast;
        private System.Windows.Forms.Button btnEditBoth;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEditMessage;
    }
}