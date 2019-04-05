namespace Project_Management_Utility_2._0
{
    partial class AssociateForm
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
            this.Position = new System.Windows.Forms.ComboBox();
            this.AssociateEmail = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.Position.Location = new System.Drawing.Point(19, 93);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(543, 28);
            this.Position.TabIndex = 3;
            this.Position.Text = "Role";
            // 
            // AssociateEmail
            // 
            this.AssociateEmail.Location = new System.Drawing.Point(19, 61);
            this.AssociateEmail.Name = "AssociateEmail";
            this.AssociateEmail.Size = new System.Drawing.Size(543, 26);
            this.AssociateEmail.TabIndex = 2;
            this.AssociateEmail.Text = "Email Address";
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(578, 29);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(126, 92);
            this.Update.TabIndex = 5;
            this.Update.Text = "Add/Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(543, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Full Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 128);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(543, 90);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Notes...";
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.Location = new System.Drawing.Point(578, 128);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(126, 90);
            this.Cancel_btn.TabIndex = 7;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // Associate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 243);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.AssociateEmail);
            this.Controls.Add(this.Position);
            this.Name = "Associate";
            this.Text = "Add/Edit Associate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Position;
        private System.Windows.Forms.TextBox AssociateEmail;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Cancel_btn;
    }
}