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
            this.associateRole_comboBox = new System.Windows.Forms.ComboBox();
            this.associateEmail_textBox = new System.Windows.Forms.TextBox();
            this.UpdateComment = new System.Windows.Forms.Button();
            this.associateName_textBox = new System.Windows.Forms.TextBox();
            this.associateNotes_textBox = new System.Windows.Forms.TextBox();
            this.associateCancel_btn = new System.Windows.Forms.Button();
            this.associatePhone_textBox = new System.Windows.Forms.TextBox();
            this.associateDepartment_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // associateRole_comboBox
            // 
            this.associateRole_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.associateRole_comboBox.FormattingEnabled = true;
            this.associateRole_comboBox.Items.AddRange(new object[] {
            "Stakeholder",
            "SME",
            "Instructor",
            "Developer",
            "ID"});
            this.associateRole_comboBox.Location = new System.Drawing.Point(12, 110);
            this.associateRole_comboBox.Name = "associateRole_comboBox";
            this.associateRole_comboBox.Size = new System.Drawing.Size(543, 28);
            this.associateRole_comboBox.TabIndex = 4;
            // 
            // associateEmail_textBox
            // 
            this.associateEmail_textBox.Location = new System.Drawing.Point(12, 45);
            this.associateEmail_textBox.Name = "associateEmail_textBox";
            this.associateEmail_textBox.Size = new System.Drawing.Size(543, 26);
            this.associateEmail_textBox.TabIndex = 2;
            this.associateEmail_textBox.Text = "Email Address";
            // 
            // UpdateComment
            // 
            this.UpdateComment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateComment.Location = new System.Drawing.Point(571, 13);
            this.UpdateComment.Name = "UpdateComment";
            this.UpdateComment.Size = new System.Drawing.Size(133, 92);
            this.UpdateComment.TabIndex = 6;
            this.UpdateComment.Text = "Save/\r\nUpdate";
            this.UpdateComment.UseVisualStyleBackColor = true;
            // 
            // associateName_textBox
            // 
            this.associateName_textBox.Location = new System.Drawing.Point(12, 13);
            this.associateName_textBox.Name = "associateName_textBox";
            this.associateName_textBox.Size = new System.Drawing.Size(543, 26);
            this.associateName_textBox.TabIndex = 1;
            this.associateName_textBox.Text = "Full Name";
            // 
            // associateNotes_textBox
            // 
            this.associateNotes_textBox.Location = new System.Drawing.Point(12, 176);
            this.associateNotes_textBox.Multiline = true;
            this.associateNotes_textBox.Name = "associateNotes_textBox";
            this.associateNotes_textBox.Size = new System.Drawing.Size(543, 168);
            this.associateNotes_textBox.TabIndex = 6;
            this.associateNotes_textBox.Text = "Notes...";
            // 
            // associateCancel_btn
            // 
            this.associateCancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.associateCancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.associateCancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.associateCancel_btn.Location = new System.Drawing.Point(571, 301);
            this.associateCancel_btn.Name = "associateCancel_btn";
            this.associateCancel_btn.Size = new System.Drawing.Size(133, 43);
            this.associateCancel_btn.TabIndex = 7;
            this.associateCancel_btn.Text = "Cancel";
            this.associateCancel_btn.UseVisualStyleBackColor = true;
            // 
            // associatePhone_textBox
            // 
            this.associatePhone_textBox.Location = new System.Drawing.Point(12, 144);
            this.associatePhone_textBox.Name = "associatePhone_textBox";
            this.associatePhone_textBox.Size = new System.Drawing.Size(543, 26);
            this.associatePhone_textBox.TabIndex = 5;
            this.associatePhone_textBox.Text = "Phone Number";
            // 
            // associateDepartment_textBox
            // 
            this.associateDepartment_textBox.Location = new System.Drawing.Point(12, 77);
            this.associateDepartment_textBox.Name = "associateDepartment_textBox";
            this.associateDepartment_textBox.Size = new System.Drawing.Size(543, 26);
            this.associateDepartment_textBox.TabIndex = 3;
            this.associateDepartment_textBox.Text = "Department";
            // 
            // AssociateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 355);
            this.Controls.Add(this.associateDepartment_textBox);
            this.Controls.Add(this.associatePhone_textBox);
            this.Controls.Add(this.associateCancel_btn);
            this.Controls.Add(this.associateNotes_textBox);
            this.Controls.Add(this.associateName_textBox);
            this.Controls.Add(this.UpdateComment);
            this.Controls.Add(this.associateEmail_textBox);
            this.Controls.Add(this.associateRole_comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssociateForm";
            this.Text = "Add/Edit Associate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox associateRole_comboBox;
        private System.Windows.Forms.TextBox associateEmail_textBox;
        private System.Windows.Forms.Button UpdateComment;
        private System.Windows.Forms.TextBox associateName_textBox;
        private System.Windows.Forms.TextBox associateNotes_textBox;
        private System.Windows.Forms.Button associateCancel_btn;
        private System.Windows.Forms.TextBox associatePhone_textBox;
        private System.Windows.Forms.TextBox associateDepartment_textBox;
    }
}