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
            this.duration_textBox = new System.Windows.Forms.TextBox();
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
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // estimatedTimePer_textBox
            // 
            this.estimatedTimePer_textBox.Location = new System.Drawing.Point(92, 78);
            this.estimatedTimePer_textBox.Name = "estimatedTimePer_textBox";
            this.estimatedTimePer_textBox.Size = new System.Drawing.Size(216, 26);
            this.estimatedTimePer_textBox.TabIndex = 26;
            this.estimatedTimePer_textBox.Text = "Estimated Time Per";
            // 
            // status_comboBox
            // 
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
            this.status_comboBox.Location = new System.Drawing.Point(12, 1045);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(296, 28);
            this.status_comboBox.TabIndex = 25;
            this.status_comboBox.Text = "Status";
            // 
            // accessibility_comboBox
            // 
            this.accessibility_comboBox.FormattingEnabled = true;
            this.accessibility_comboBox.Items.AddRange(new object[] {
            "Captions",
            "Full WCAG 2.0"});
            this.accessibility_comboBox.Location = new System.Drawing.Point(313, 78);
            this.accessibility_comboBox.Name = "accessibility_comboBox";
            this.accessibility_comboBox.Size = new System.Drawing.Size(302, 28);
            this.accessibility_comboBox.TabIndex = 19;
            this.accessibility_comboBox.Text = "Accessibility";
            // 
            // teamResponsible_comboBox
            // 
            this.teamResponsible_comboBox.FormattingEnabled = true;
            this.teamResponsible_comboBox.Items.AddRange(new object[] {
            "Custom",
            "Web",
            "Audio",
            "Video"});
            this.teamResponsible_comboBox.Location = new System.Drawing.Point(314, 44);
            this.teamResponsible_comboBox.Name = "teamResponsible_comboBox";
            this.teamResponsible_comboBox.Size = new System.Drawing.Size(301, 28);
            this.teamResponsible_comboBox.TabIndex = 18;
            this.teamResponsible_comboBox.Text = "Team Responsible";
            // 
            // quantity_textBox
            // 
            this.quantity_textBox.Location = new System.Drawing.Point(12, 78);
            this.quantity_textBox.Name = "quantity_textBox";
            this.quantity_textBox.Size = new System.Drawing.Size(74, 26);
            this.quantity_textBox.TabIndex = 14;
            this.quantity_textBox.Text = "Quantity";
            // 
            // duration_textBox
            // 
            this.duration_textBox.Location = new System.Drawing.Point(499, 973);
            this.duration_textBox.Name = "duration_textBox";
            this.duration_textBox.Size = new System.Drawing.Size(116, 26);
            this.duration_textBox.TabIndex = 15;
            this.duration_textBox.Text = "Duration";
            // 
            // description_textBox
            // 
            this.description_textBox.Location = new System.Drawing.Point(12, 112);
            this.description_textBox.Multiline = true;
            this.description_textBox.Name = "description_textBox";
            this.description_textBox.Size = new System.Drawing.Size(603, 194);
            this.description_textBox.TabIndex = 13;
            this.description_textBox.Text = "Deliverable Description...";
            // 
            // mediaType_comboBox
            // 
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
            this.mediaType_comboBox.Location = new System.Drawing.Point(12, 44);
            this.mediaType_comboBox.Name = "mediaType_comboBox";
            this.mediaType_comboBox.Size = new System.Drawing.Size(296, 28);
            this.mediaType_comboBox.TabIndex = 16;
            this.mediaType_comboBox.Text = "Media Type";
            // 
            // notes_textBox
            // 
            this.notes_textBox.Location = new System.Drawing.Point(12, 312);
            this.notes_textBox.Multiline = true;
            this.notes_textBox.Name = "notes_textBox";
            this.notes_textBox.Size = new System.Drawing.Size(603, 276);
            this.notes_textBox.TabIndex = 27;
            this.notes_textBox.Text = "Notes and Discovery...";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(499, 1030);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 43);
            this.button1.TabIndex = 28;
            this.button1.Text = "Add/Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(377, 1030);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 43);
            this.button2.TabIndex = 29;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dueDate_picker
            // 
            this.dueDate_picker.Location = new System.Drawing.Point(309, 941);
            this.dueDate_picker.Name = "dueDate_picker";
            this.dueDate_picker.Size = new System.Drawing.Size(306, 26);
            this.dueDate_picker.TabIndex = 30;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(12, 12);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(603, 26);
            this.name_textBox.TabIndex = 31;
            this.name_textBox.Text = "Deliverable Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 942);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Due Date:";
            // 
            // finalLink_textBox
            // 
            this.finalLink_textBox.Location = new System.Drawing.Point(12, 973);
            this.finalLink_textBox.Name = "finalLink_textBox";
            this.finalLink_textBox.Size = new System.Drawing.Size(481, 26);
            this.finalLink_textBox.TabIndex = 33;
            this.finalLink_textBox.Text = "Final Link";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Controls.Add(this.addLink_btn);
            this.groupBox4.Location = new System.Drawing.Point(12, 594);
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
            this.button3.TabIndex = 19;
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
            this.addLink_btn.TabIndex = 11;
            this.addLink_btn.Text = "Add/Edit Link";
            this.addLink_btn.UseVisualStyleBackColor = true;
            // 
            // priority_comboBox
            // 
            this.priority_comboBox.FormattingEnabled = true;
            this.priority_comboBox.Items.AddRange(new object[] {
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
            this.priority_comboBox.Location = new System.Drawing.Point(12, 1011);
            this.priority_comboBox.Name = "priority_comboBox";
            this.priority_comboBox.Size = new System.Drawing.Size(296, 28);
            this.priority_comboBox.TabIndex = 20;
            this.priority_comboBox.Text = "Priority";
            // 
            // DeliverableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 1085);
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
            this.Controls.Add(this.duration_textBox);
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
        private System.Windows.Forms.TextBox duration_textBox;
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
    }
}