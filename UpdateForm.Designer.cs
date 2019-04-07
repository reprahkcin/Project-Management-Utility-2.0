namespace Project_Management_Utility_2._0
{
    partial class UpdateForm
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
            this.note_textBox = new System.Windows.Forms.TextBox();
            this.nextSteps_textBox = new System.Windows.Forms.TextBox();
            this.addUpdate_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // note_textBox
            // 
            this.note_textBox.Location = new System.Drawing.Point(13, 36);
            this.note_textBox.Multiline = true;
            this.note_textBox.Name = "note_textBox";
            this.note_textBox.Size = new System.Drawing.Size(775, 131);
            this.note_textBox.TabIndex = 0;
            // 
            // nextSteps_textBox
            // 
            this.nextSteps_textBox.Location = new System.Drawing.Point(13, 206);
            this.nextSteps_textBox.Multiline = true;
            this.nextSteps_textBox.Name = "nextSteps_textBox";
            this.nextSteps_textBox.Size = new System.Drawing.Size(775, 140);
            this.nextSteps_textBox.TabIndex = 1;
            // 
            // addUpdate_btn
            // 
            this.addUpdate_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addUpdate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUpdate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUpdate_btn.Location = new System.Drawing.Point(627, 353);
            this.addUpdate_btn.Name = "addUpdate_btn";
            this.addUpdate_btn.Size = new System.Drawing.Size(160, 50);
            this.addUpdate_btn.TabIndex = 2;
            this.addUpdate_btn.Text = "Add Update";
            this.addUpdate_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(461, 353);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(160, 50);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Next Steps";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Update";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.addUpdate_btn);
            this.Controls.Add(this.nextSteps_textBox);
            this.Controls.Add(this.note_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox note_textBox;
        private System.Windows.Forms.TextBox nextSteps_textBox;
        private System.Windows.Forms.Button addUpdate_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}