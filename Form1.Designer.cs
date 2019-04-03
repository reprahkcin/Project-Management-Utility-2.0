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
            this.projectName_textBox = new System.Windows.Forms.TextBox();
            this.projectDescription_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.learningObjective_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.term_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.projectStatus_comboBox = new System.Windows.Forms.ComboBox();
            this.projectType_comboBox = new System.Windows.Forms.ComboBox();
            this.nextSteps_textBox = new System.Windows.Forms.TextBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_deliverables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_textBox = new System.Windows.Forms.TextBox();
            this.courseNumber_textBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // projectName_textBox
            // 
            this.projectName_textBox.Location = new System.Drawing.Point(13, 52);
            this.projectName_textBox.Name = "projectName_textBox";
            this.projectName_textBox.Size = new System.Drawing.Size(682, 26);
            this.projectName_textBox.TabIndex = 5;
            this.projectName_textBox.Text = "Project Name";
            // 
            // projectDescription_textBox
            // 
            this.projectDescription_textBox.Location = new System.Drawing.Point(13, 88);
            this.projectDescription_textBox.Multiline = true;
            this.projectDescription_textBox.Name = "projectDescription_textBox";
            this.projectDescription_textBox.Size = new System.Drawing.Size(682, 520);
            this.projectDescription_textBox.TabIndex = 7;
            this.projectDescription_textBox.Text = "Project Description...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(13, 885);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Associates";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(6, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 36);
            this.button3.TabIndex = 16;
            this.button3.Text = "Add Associate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "You have X days left\r\nto work on this";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date Created";
            // 
            // learningObjective_textBox
            // 
            this.learningObjective_textBox.Location = new System.Drawing.Point(13, 619);
            this.learningObjective_textBox.Multiline = true;
            this.learningObjective_textBox.Name = "learningObjective_textBox";
            this.learningObjective_textBox.Size = new System.Drawing.Size(682, 70);
            this.learningObjective_textBox.TabIndex = 8;
            this.learningObjective_textBox.Text = "Learning Objective...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(705, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Project ID: XXX-XXX";
            // 
            // term_textBox
            // 
            this.term_textBox.Location = new System.Drawing.Point(616, 14);
            this.term_textBox.Name = "term_textBox";
            this.term_textBox.Size = new System.Drawing.Size(79, 26);
            this.term_textBox.TabIndex = 4;
            this.term_textBox.Text = "Term";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(13, 974);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 80);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deliverables";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(19, 999);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 36);
            this.button4.TabIndex = 17;
            this.button4.Text = "Add Deliverable";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(706, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 790);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timestamps";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date Started";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date Started";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Approved";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date Last Modified";
            // 
            // projectStatus_comboBox
            // 
            this.projectStatus_comboBox.FormattingEnabled = true;
            this.projectStatus_comboBox.Items.AddRange(new object[] {
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
            this.projectStatus_comboBox.Location = new System.Drawing.Point(705, 52);
            this.projectStatus_comboBox.Name = "projectStatus_comboBox";
            this.projectStatus_comboBox.Size = new System.Drawing.Size(312, 28);
            this.projectStatus_comboBox.TabIndex = 6;
            this.projectStatus_comboBox.Text = "Status";
            // 
            // projectType_comboBox
            // 
            this.projectType_comboBox.FormattingEnabled = true;
            this.projectType_comboBox.Items.AddRange(new object[] {
            "Course-Related - NEW",
            "Course-Related - REFRESH",
            "Course-Related - Hot Fix",
            "Internal - SHORT TERM",
            "Internal - LONG TERM",
            "Miscellaneous"});
            this.projectType_comboBox.Location = new System.Drawing.Point(13, 14);
            this.projectType_comboBox.Name = "projectType_comboBox";
            this.projectType_comboBox.Size = new System.Drawing.Size(271, 28);
            this.projectType_comboBox.TabIndex = 1;
            this.projectType_comboBox.Text = "Project Type";
            // 
            // nextSteps_textBox
            // 
            this.nextSteps_textBox.Location = new System.Drawing.Point(12, 700);
            this.nextSteps_textBox.Multiline = true;
            this.nextSteps_textBox.Name = "nextSteps_textBox";
            this.nextSteps_textBox.Size = new System.Drawing.Size(683, 70);
            this.nextSteps_textBox.TabIndex = 9;
            this.nextSteps_textBox.Text = "Next Steps...";
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "Shared",
            "Source Files",
            "Misc. Resources",
            "Asana Link",
            "TeamGantt Link",
            "Jira Link",
            "Reference Link"});
            this.comboBox10.Location = new System.Drawing.Point(454, 780);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(241, 28);
            this.comboBox10.TabIndex = 11;
            this.comboBox10.Text = "Link Category";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(12, 780);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(436, 26);
            this.textBox11.TabIndex = 10;
            this.textBox11.Text = "Project Resources Link";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 816);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(436, 26);
            this.textBox10.TabIndex = 12;
            this.textBox10.Text = "Project Resources Link";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.term,
            this.status,
            this.num_deliverables});
            this.dataGridView1.Location = new System.Drawing.Point(1047, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(645, 1027);
            this.dataGridView1.TabIndex = 32;
            // 
            // name
            // 
            this.name.HeaderText = "Project Name";
            this.name.Name = "name";
            this.name.Width = 250;
            // 
            // term
            // 
            this.term.HeaderText = "Term";
            this.term.Name = "term";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // num_deliverables
            // 
            this.num_deliverables.HeaderText = "# of Del.";
            this.num_deliverables.Name = "num_deliverables";
            // 
            // department_textBox
            // 
            this.department_textBox.Location = new System.Drawing.Point(291, 14);
            this.department_textBox.Name = "department_textBox";
            this.department_textBox.Size = new System.Drawing.Size(227, 26);
            this.department_textBox.TabIndex = 2;
            this.department_textBox.Text = "Department";
            // 
            // courseNumber_textBox
            // 
            this.courseNumber_textBox.Location = new System.Drawing.Point(524, 14);
            this.courseNumber_textBox.Name = "courseNumber_textBox";
            this.courseNumber_textBox.Size = new System.Drawing.Size(86, 26);
            this.courseNumber_textBox.TabIndex = 3;
            this.courseNumber_textBox.Text = "Course #";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 852);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(436, 26);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "Project Resources Link";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Shared",
            "Source Files",
            "Misc. Resources",
            "Asana Link",
            "TeamGantt Link",
            "Jira Link",
            "Reference Link"});
            this.comboBox1.Location = new System.Drawing.Point(454, 852);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Link Category";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Shared",
            "Source Files",
            "Misc. Resources",
            "Asana Link",
            "TeamGantt Link",
            "Jira Link",
            "Reference Link"});
            this.comboBox2.Location = new System.Drawing.Point(454, 816);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(241, 28);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.Text = "Link Category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1713, 1129);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.courseNumber_textBox);
            this.Controls.Add(this.department_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.nextSteps_textBox);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.projectType_comboBox);
            this.Controls.Add(this.projectStatus_comboBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.term_textBox);
            this.Controls.Add(this.learningObjective_textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectDescription_textBox);
            this.Controls.Add(this.projectName_textBox);
            this.Name = "Form1";
            this.Text = "The Wizard\'s Wizard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projectName_textBox;
        private System.Windows.Forms.TextBox projectDescription_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox learningObjective_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox term_textBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox projectStatus_comboBox;
        private System.Windows.Forms.ComboBox projectType_comboBox;
        private System.Windows.Forms.TextBox nextSteps_textBox;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox department_textBox;
        private System.Windows.Forms.TextBox courseNumber_textBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn term;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_deliverables;
    }
}

