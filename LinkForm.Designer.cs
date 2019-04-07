namespace Project_Management_Utility_2._0
{
    partial class LinkForm
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
            this.LinkUrl = new System.Windows.Forms.TextBox();
            this.linkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.linkNotes = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinkUrl
            // 
            this.LinkUrl.Location = new System.Drawing.Point(13, 13);
            this.LinkUrl.Name = "LinkUrl";
            this.LinkUrl.Size = new System.Drawing.Size(775, 26);
            this.LinkUrl.TabIndex = 0;
            this.LinkUrl.Text = "URL";
            // 
            // linkTypeComboBox
            // 
            this.linkTypeComboBox.FormattingEnabled = true;
            this.linkTypeComboBox.Items.AddRange(new object[] {
            "Resource from SME",
            "Shared Resource",
            "Reference",
            "Final Output"});
            this.linkTypeComboBox.Location = new System.Drawing.Point(13, 46);
            this.linkTypeComboBox.Name = "linkTypeComboBox";
            this.linkTypeComboBox.Size = new System.Drawing.Size(775, 28);
            this.linkTypeComboBox.TabIndex = 1;
            this.linkTypeComboBox.Text = "Link Type";
            // 
            // linkNotes
            // 
            this.linkNotes.Location = new System.Drawing.Point(13, 81);
            this.linkNotes.Multiline = true;
            this.linkNotes.Name = "linkNotes";
            this.linkNotes.Size = new System.Drawing.Size(775, 66);
            this.linkNotes.TabIndex = 2;
            this.linkNotes.Text = "Notes";
            // 
            // Add
            // 
            this.Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(653, 154);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(135, 43);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(512, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 43);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // LinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 209);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.linkNotes);
            this.Controls.Add(this.linkTypeComboBox);
            this.Controls.Add(this.LinkUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LinkForm";
            this.Text = "LinkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LinkUrl;
        private System.Windows.Forms.ComboBox linkTypeComboBox;
        private System.Windows.Forms.TextBox linkNotes;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
    }
}