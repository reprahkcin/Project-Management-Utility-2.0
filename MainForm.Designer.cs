namespace Project_Management_Utility_2._0
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.projectName_textBox = new System.Windows.Forms.TextBox();
            this.projectDescription_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.learningObjective_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.term_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.projectStatus_comboBox = new System.Windows.Forms.ComboBox();
            this.projectType_comboBox = new System.Windows.Forms.ComboBox();
            this.nextSteps_textBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.department_textBox = new System.Windows.Forms.TextBox();
            this.courseNumber_textBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isShared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associateEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associateRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.collectionDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectionCourseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leadDeveloper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // projectName_textBox
            // 
            this.projectName_textBox.Location = new System.Drawing.Point(13, 88);
            this.projectName_textBox.Name = "projectName_textBox";
            this.projectName_textBox.Size = new System.Drawing.Size(682, 26);
            this.projectName_textBox.TabIndex = 5;
            this.projectName_textBox.Text = "Project Name";
            // 
            // projectDescription_textBox
            // 
            this.projectDescription_textBox.Location = new System.Drawing.Point(12, 147);
            this.projectDescription_textBox.Multiline = true;
            this.projectDescription_textBox.Name = "projectDescription_textBox";
            this.projectDescription_textBox.Size = new System.Drawing.Size(682, 210);
            this.projectDescription_textBox.TabIndex = 7;
            this.projectDescription_textBox.Text = "Project Description...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(13, 1093);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 280);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Associates";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(842, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 36);
            this.button3.TabIndex = 16;
            this.button3.Text = "Add Associate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // learningObjective_textBox
            // 
            this.learningObjective_textBox.Location = new System.Drawing.Point(13, 363);
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
            this.label3.Location = new System.Drawing.Point(800, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Project ID: XXX-XXX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // term_textBox
            // 
            this.term_textBox.Location = new System.Drawing.Point(615, 52);
            this.term_textBox.Name = "term_textBox";
            this.term_textBox.Size = new System.Drawing.Size(79, 26);
            this.term_textBox.TabIndex = 4;
            this.term_textBox.Text = "Term";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 786);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1005, 301);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deliverables";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(843, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 36);
            this.button4.TabIndex = 17;
            this.button4.Text = "Add Deliverable";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView5);
            this.groupBox3.Location = new System.Drawing.Point(706, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 302);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History";
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
            this.projectType_comboBox.Location = new System.Drawing.Point(12, 52);
            this.projectType_comboBox.Name = "projectType_comboBox";
            this.projectType_comboBox.Size = new System.Drawing.Size(271, 28);
            this.projectType_comboBox.TabIndex = 1;
            this.projectType_comboBox.Text = "Project Type";
            // 
            // nextSteps_textBox
            // 
            this.nextSteps_textBox.Location = new System.Drawing.Point(12, 1379);
            this.nextSteps_textBox.Multiline = true;
            this.nextSteps_textBox.Name = "nextSteps_textBox";
            this.nextSteps_textBox.Size = new System.Drawing.Size(852, 70);
            this.nextSteps_textBox.TabIndex = 9;
            this.nextSteps_textBox.Text = "What\'s Next?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.collectionDepartment,
            this.collectionCourseNumber,
            this.name,
            this.dueDate,
            this.status,
            this.priority,
            this.leadDeveloper});
            this.dataGridView1.Location = new System.Drawing.Point(1035, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1178, 1397);
            this.dataGridView1.TabIndex = 32;
            // 
            // department_textBox
            // 
            this.department_textBox.Location = new System.Drawing.Point(289, 52);
            this.department_textBox.Name = "department_textBox";
            this.department_textBox.Size = new System.Drawing.Size(227, 26);
            this.department_textBox.TabIndex = 2;
            this.department_textBox.Text = "Department";
            // 
            // courseNumber_textBox
            // 
            this.courseNumber_textBox.Location = new System.Drawing.Point(522, 52);
            this.courseNumber_textBox.Name = "courseNumber_textBox";
            this.courseNumber_textBox.Size = new System.Drawing.Size(86, 26);
            this.courseNumber_textBox.TabIndex = 3;
            this.courseNumber_textBox.Text = "Course #";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(12, 439);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1005, 341);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Links";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(843, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Link";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(870, 1379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 70);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(705, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(312, 28);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Text = "Priority";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2225, 30);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(279, 25);
            this.toolStripStatusLabel1.Text = "Start typing to create new project.";
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
            this.dataGridView2.Size = new System.Drawing.Size(993, 259);
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
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qty,
            this.duration,
            this.mediaType,
            this.deliverableName});
            this.dataGridView3.Location = new System.Drawing.Point(6, 26);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(993, 222);
            this.dataGridView3.TabIndex = 18;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.associateName,
            this.associateEmail,
            this.associateRole});
            this.dataGridView4.Location = new System.Drawing.Point(7, 26);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(991, 201);
            this.dataGridView4.TabIndex = 17;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.timeEvent});
            this.dataGridView5.Location = new System.Drawing.Point(7, 26);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 28;
            this.dataGridView5.Size = new System.Drawing.Size(298, 270);
            this.dataGridView5.TabIndex = 0;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.Width = 50;
            // 
            // duration
            // 
            this.duration.HeaderText = "Est. Duration";
            this.duration.Name = "duration";
            this.duration.Width = 120;
            // 
            // mediaType
            // 
            this.mediaType.HeaderText = "Type";
            this.mediaType.Name = "mediaType";
            this.mediaType.Width = 150;
            // 
            // deliverableName
            // 
            this.deliverableName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deliverableName.HeaderText = "Name";
            this.deliverableName.Name = "deliverableName";
            // 
            // associateName
            // 
            this.associateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.associateName.HeaderText = "Name";
            this.associateName.Name = "associateName";
            // 
            // associateEmail
            // 
            this.associateEmail.HeaderText = "Email";
            this.associateEmail.Name = "associateEmail";
            this.associateEmail.Width = 250;
            // 
            // associateRole
            // 
            this.associateRole.HeaderText = "Role";
            this.associateRole.Name = "associateRole";
            this.associateRole.Width = 150;
            // 
            // time
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.time.DefaultCellStyle = dataGridViewCellStyle1;
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            // 
            // timeEvent
            // 
            this.timeEvent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeEvent.HeaderText = "Event";
            this.timeEvent.Name = "timeEvent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Due Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(296, 26);
            this.dateTimePicker1.TabIndex = 35;
            // 
            // collectionDepartment
            // 
            this.collectionDepartment.HeaderText = "Department";
            this.collectionDepartment.Name = "collectionDepartment";
            this.collectionDepartment.Width = 125;
            // 
            // collectionCourseNumber
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.collectionCourseNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.collectionCourseNumber.HeaderText = "#";
            this.collectionCourseNumber.Name = "collectionCourseNumber";
            this.collectionCourseNumber.Width = 50;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Project Name";
            this.name.Name = "name";
            // 
            // dueDate
            // 
            this.dueDate.HeaderText = "Due";
            this.dueDate.Name = "dueDate";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // priority
            // 
            this.priority.HeaderText = "Priority";
            this.priority.Name = "priority";
            // 
            // leadDeveloper
            // 
            this.leadDeveloper.HeaderText = "Lead Developer";
            this.leadDeveloper.Name = "leadDeveloper";
            this.leadDeveloper.Width = 200;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(2225, 1487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.courseNumber_textBox);
            this.Controls.Add(this.department_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nextSteps_textBox);
            this.Controls.Add(this.projectType_comboBox);
            this.Controls.Add(this.projectStatus_comboBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.term_textBox);
            this.Controls.Add(this.learningObjective_textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectDescription_textBox);
            this.Controls.Add(this.projectName_textBox);
            this.Name = "MainForm";
            this.Text = "The Wizard\'s Wizard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projectName_textBox;
        private System.Windows.Forms.TextBox projectDescription_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox learningObjective_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox term_textBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox projectStatus_comboBox;
        private System.Windows.Forms.ComboBox projectType_comboBox;
        private System.Windows.Forms.TextBox nextSteps_textBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox department_textBox;
        private System.Windows.Forms.TextBox courseNumber_textBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn isShared;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn associateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn associateEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn associateRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaType;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverableName;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectionCourseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn leadDeveloper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

