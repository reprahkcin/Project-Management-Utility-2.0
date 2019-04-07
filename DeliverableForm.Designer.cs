namespace Project_Management_Utility_2._0
{
    partial class DeliverableForm
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
            this.estimatedTimePer_textBox = new System.Windows.Forms.TextBox();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.accessibility_comboBox = new System.Windows.Forms.ComboBox();
            this.teamResponsible_comboBox = new System.Windows.Forms.ComboBox();
            this.quantity_textBox = new System.Windows.Forms.TextBox();
            this.description_textBox = new System.Windows.Forms.TextBox();
            this.mediaType_comboBox = new System.Windows.Forms.ComboBox();
            this.notes_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dueDate_picker = new System.Windows.Forms.DateTimePicker();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.finalLink_textBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isShared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLink_btn = new System.Windows.Forms.Button();
            this.priority_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.duration_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // estimatedTimePer_textBox
            // 
            this.estimatedTimePer_textBox.Location = new System.Drawing.Point(96, 231);
            this.estimatedTimePer_textBox.Name = "estimatedTimePer_textBox";
            this.estimatedTimePer_textBox.Size = new System.Drawing.Size(216, 26);
            this.estimatedTimePer_textBox.TabIndex = 7;
            // 
            // status_comboBox
            // 
            this.status_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Items.AddRange(new object[] {
            "Under Review",
            "Approved",
            "Discovery",
            "Ready for Action",
            "Working",
            "On Hold",
            "Cancelled",
            "Complete",
            "Waiting for Content",
            "Approval Pending",
            "Revisions Pending",
            "Late"});
            this.status_comboBox.Location = new System.Drawing.Point(16, 32);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(296, 28);
            this.status_comboBox.TabIndex = 1;
            // 
            // accessibility_comboBox
            // 
            this.accessibility_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accessibility_comboBox.FormattingEnabled = true;
            this.accessibility_comboBox.Items.AddRange(new object[] {
            "Captions",
            "Full WCAG 2.0"});
            this.accessibility_comboBox.Location = new System.Drawing.Point(318, 231);
            this.accessibility_comboBox.Name = "accessibility_comboBox";
            this.accessibility_comboBox.Size = new System.Drawing.Size(302, 28);
            this.accessibility_comboBox.TabIndex = 8;
            // 
            // teamResponsible_comboBox
            // 
            this.teamResponsible_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teamResponsible_comboBox.FormattingEnabled = true;
            this.teamResponsible_comboBox.Items.AddRange(new object[] {
            "Custom",
            "Web",
            "Audio",
            "Video"});
            this.teamResponsible_comboBox.Location = new System.Drawing.Point(318, 167);
            this.teamResponsible_comboBox.Name = "teamResponsible_comboBox";
            this.teamResponsible_comboBox.Size = new System.Drawing.Size(301, 28);
            this.teamResponsible_comboBox.TabIndex = 5;
            // 
            // quantity_textBox
            // 
            this.quantity_textBox.Location = new System.Drawing.Point(16, 231);
            this.quantity_textBox.Name = "quantity_textBox";
            this.quantity_textBox.Size = new System.Drawing.Size(74, 26);
            this.quantity_textBox.TabIndex = 6;
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(16, 365);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(603, 194);
            this.description_textBox.TabIndex = 10;
            // 
            // mediaType_comboBox
            // 
            this.mediaType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mediaType_comboBox.FormattingEnabled = true;
            this.mediaType_comboBox.Items.AddRange(new object[] {
            "Animation",
            "Interactive",
            "AR",
            "VR",
            "Graphics",
            "Programming",
            "Narration/Audio",
            "Video",
            "Web Site",
            "Editing",
            "Maintenence & Repair"});
            this.mediaType_comboBox.Location = new System.Drawing.Point(16, 167);
            this.mediaType_comboBox.Name = "mediaType_comboBox";
            this.mediaType_comboBox.Size = new System.Drawing.Size(296, 28);
            this.mediaType_comboBox.TabIndex = 4;
            // 
            // notes_textBox
            // 
            this.notes_textBox.Location = new System.Drawing.Point(16, 598);
            this.notes_textBox.Multiline = true;
            this.notes_textBox.Name = "notes_textBox";
            this.notes_textBox.Size = new System.Drawing.Size(603, 276);
            this.notes_textBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(457, 1323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add/Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(305, 1323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 43);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dueDate_picker
            // 
            this.dueDate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dueDate_picker.Location = new System.Drawing.Point(124, 294);
            this.dueDate_picker.Name = "dueDate_picker";
            this.dueDate_picker.Size = new System.Drawing.Size(496, 26);
            this.dueDate_picker.TabIndex = 9;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(16, 103);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(603, 26);
            this.name_textBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Due Date:";
            // 
            // finalLink_textBox
            // 
            this.finalLink_textBox.Location = new System.Drawing.Point(19, 1270);
            this.finalLink_textBox.Name = "finalLink_textBox";
            this.finalLink_textBox.Size = new System.Drawing.Size(481, 26);
            this.finalLink_textBox.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Controls.Add(this.addLink_btn);
            this.groupBox4.Location = new System.Drawing.Point(16, 892);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(603, 341);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Links";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Remove Link";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.url,
            this.type,
            this.isShared});
            this.dataGridView2.Location = new System.Drawing.Point(6, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(591, 259);
            this.dataGridView2.TabIndex = 17;
            // 
            // url
            // 
            this.url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.url.HeaderText = "Link";
            this.url.Name = "url";
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.Width = 200;
            // 
            // isShared
            // 
            this.isShared.HeaderText = "Shared";
            this.isShared.Name = "isShared";
            // 
            // addLink_btn
            // 
            this.addLink_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLink_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLink_btn.Location = new System.Drawing.Point(441, 290);
            this.addLink_btn.Name = "addLink_btn";
            this.addLink_btn.Size = new System.Drawing.Size(156, 36);
            this.addLink_btn.TabIndex = 13;
            this.addLink_btn.Text = "Add/Edit Link";
            this.addLink_btn.UseVisualStyleBackColor = true;
            // 
            // priority_comboBox
            // 
            this.priority_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priority_comboBox.FormattingEnabled = true;
            this.priority_comboBox.Items.AddRange(new object[] {
            "Rush",
            "High",
            "Medium",
            "Low",
            "On-going"});
            this.priority_comboBox.Location = new System.Drawing.Point(323, 32);
            this.priority_comboBox.Name = "priority_comboBox";
            this.priority_comboBox.Size = new System.Drawing.Size(296, 28);
            this.priority_comboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Deliverable Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Media Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(314, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Team Responsible";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Estimated Time Per";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Accessibility";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Deliverable Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Notes and Discovery";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 1247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Final Link";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(506, 1247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Duration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 45;
            this.label12.Text = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(319, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 20);
            this.label13.TabIndex = 46;
            this.label13.Text = "Priority";
            // 
            // duration_maskedTextBox
            // 
            this.duration_maskedTextBox.Location = new System.Drawing.Point(507, 1269);
            this.duration_maskedTextBox.Mask = "00:00:00";
            this.duration_maskedTextBox.Name = "duration_maskedTextBox";
            this.duration_maskedTextBox.Size = new System.Drawing.Size(100, 26);
            this.duration_maskedTextBox.TabIndex = 15;
            this.duration_maskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.duration_maskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Duration_maskedTextBox_MaskInputRejected);
            // 
            // DeliverableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 1382);
            this.Controls.Add(this.duration_maskedTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priority_comboBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.finalLink_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.dueDate_picker);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.notes_textBox);
            this.Controls.Add(this.estimatedTimePer_textBox);
            this.Controls.Add(this.mediaType_comboBox);
            this.Controls.Add(this.teamResponsible_comboBox);
            this.Controls.Add(this.accessibility_comboBox);
            this.Controls.Add(this.status_comboBox);
            this.Controls.Add(this.description_textBox);
            this.Controls.Add(this.quantity_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeliverableForm";
            this.Text = "Add/Edit Deliverable";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox estimatedTimePer_textBox;
        private System.Windows.Forms.ComboBox status_comboBox;
        private System.Windows.Forms.ComboBox accessibility_comboBox;
        private System.Windows.Forms.ComboBox teamResponsible_comboBox;
        private System.Windows.Forms.TextBox quantity_textBox;
        private System.Windows.Forms.TextBox description_textBox;
        private System.Windows.Forms.ComboBox mediaType_comboBox;
        private System.Windows.Forms.TextBox notes_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dueDate_picker;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox finalLink_textBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn isShared;
        private System.Windows.Forms.Button addLink_btn;
        private System.Windows.Forms.ComboBox priority_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox duration_maskedTextBox;
    }
}