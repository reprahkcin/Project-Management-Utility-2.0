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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkForm));
            this.LinkUrl = new System.Windows.Forms.TextBox();
            this.linkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.linkNotes = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinkUrl
            // 
            this.LinkUrl.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkUrl.Location = new System.Drawing.Point(13, 38);
            this.LinkUrl.Name = "LinkUrl";
            this.LinkUrl.Size = new System.Drawing.Size(619, 29);
            this.LinkUrl.TabIndex = 1;
            // 
            // linkTypeComboBox
            // 
            this.linkTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.linkTypeComboBox.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTypeComboBox.FormattingEnabled = true;
            this.linkTypeComboBox.Items.AddRange(new object[] {
            "Resource from SME",
            "Shared Resource",
            "Reference",
            "Final Output",
            "Review Link"});
            this.linkTypeComboBox.Location = new System.Drawing.Point(12, 109);
            this.linkTypeComboBox.Name = "linkTypeComboBox";
            this.linkTypeComboBox.Size = new System.Drawing.Size(620, 30);
            this.linkTypeComboBox.TabIndex = 2;
            // 
            // linkNotes
            // 
            this.linkNotes.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkNotes.Location = new System.Drawing.Point(12, 184);
            this.linkNotes.Multiline = true;
            this.linkNotes.Name = "linkNotes";
            this.linkNotes.Size = new System.Drawing.Size(620, 66);
            this.linkNotes.TabIndex = 3;
            // 
            // Add
            // 
            this.Add.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(420, 256);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(212, 60);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(202, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Link Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "URL";
            // 
            // LinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(648, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.linkNotes);
            this.Controls.Add(this.linkTypeComboBox);
            this.Controls.Add(this.LinkUrl);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LinkForm";
            this.Text = "LinkForm";
            this.Load += new System.EventHandler(this.LinkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LinkUrl;
        private System.Windows.Forms.ComboBox linkTypeComboBox;
        private System.Windows.Forms.TextBox linkNotes;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}