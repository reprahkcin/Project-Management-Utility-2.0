namespace Project_Management_Utility_2._0
{
    partial class Form1
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
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.ProjectDescription = new System.Windows.Forms.TextBox();
            this.AssociateEmail = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.ComboBox();
            this.Associate = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(13, 38);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(682, 26);
            this.ProjectName.TabIndex = 0;
            // 
            // ProjectDescription
            // 
            this.ProjectDescription.Location = new System.Drawing.Point(13, 70);
            this.ProjectDescription.Multiline = true;
            this.ProjectDescription.Name = "ProjectDescription";
            this.ProjectDescription.Size = new System.Drawing.Size(682, 520);
            this.ProjectDescription.TabIndex = 1;
            // 
            // AssociateEmail
            // 
            this.AssociateEmail.Location = new System.Drawing.Point(6, 57);
            this.AssociateEmail.Name = "AssociateEmail";
            this.AssociateEmail.Size = new System.Drawing.Size(438, 26);
            this.AssociateEmail.TabIndex = 2;
            // 
            // Position
            // 
            this.Position.FormattingEnabled = true;
            this.Position.Items.AddRange(new object[] {
            "Stakeholder",
            "SME",
            "Instructor",
            "Developer",
            "ID"});
            this.Position.Location = new System.Drawing.Point(6, 89);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(438, 28);
            this.Position.TabIndex = 3;
            // 
            // Associate
            // 
            this.Associate.Location = new System.Drawing.Point(6, 25);
            this.Associate.Name = "Associate";
            this.Associate.Size = new System.Drawing.Size(438, 26);
            this.Associate.TabIndex = 4;
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(450, 25);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(129, 44);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Associate);
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.AssociateEmail);
            this.groupBox1.Controls.Add(this.Position);
            this.groupBox1.Location = new System.Drawing.Point(13, 718);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 194);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Associates";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(585, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Inquiry";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(720, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Initial";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(720, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 60);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add Associate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "You have X days left\r\nto work on this";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Project";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 1568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProjectDescription);
            this.Controls.Add(this.ProjectName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.TextBox ProjectDescription;
        private System.Windows.Forms.TextBox AssociateEmail;
        private System.Windows.Forms.ComboBox Position;
        private System.Windows.Forms.TextBox Associate;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

