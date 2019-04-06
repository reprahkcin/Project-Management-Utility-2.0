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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.projectName_textBox = new System.Windows.Forms.TextBox();
            this.projectDescription_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.associateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associateEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.associateRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addAssociate_btn = new System.Windows.Forms.Button();
            this.learningObjective_textBox = new System.Windows.Forms.TextBox();
            this.projectID_displayText = new System.Windows.Forms.Label();
            this.term_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDeliverable_btn = new System.Windows.Forms.Button();
            this.projectStatus_comboBox = new System.Windows.Forms.ComboBox();
            this.projectType_comboBox = new System.Windows.Forms.ComboBox();
            this.department_textBox = new System.Windows.Forms.TextBox();
            this.courseNumber_textBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isShared = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLink_btn = new System.Windows.Forms.Button();
            this.projectPriority_comboBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.ProjectDueDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddUpdate_btn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.collectionPath = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.load = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projectName_textBox
            // 
            this.projectName_textBox.Location = new System.Drawing.Point(12, 13);
            this.projectName_textBox.Name = "projectName_textBox";
            this.projectName_textBox.Size = new System.Drawing.Size(403, 26);
            this.projectName_textBox.TabIndex = 7;
            this.projectName_textBox.Text = "Project Name";
            this.projectName_textBox.TextChanged += new System.EventHandler(this.ProjectName_textBox_TextChanged);
            // 
            // projectDescription_textBox
            // 
            this.projectDescription_textBox.Location = new System.Drawing.Point(11, 207);
            this.projectDescription_textBox.Multiline = true;
            this.projectDescription_textBox.Name = "projectDescription_textBox";
            this.projectDescription_textBox.Size = new System.Drawing.Size(876, 235);
            this.projectDescription_textBox.TabIndex = 9;
            this.projectDescription_textBox.Text = "Project Description...";
            this.projectDescription_textBox.TextChanged += new System.EventHandler(this.ProjectDescription_textBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.dataGridView4);
            this.groupBox1.Controls.Add(this.addAssociate_btn);
            this.groupBox1.Location = new System.Drawing.Point(894, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 296);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Associates";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(379, 254);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(212, 36);
            this.button7.TabIndex = 19;
            this.button7.Text = "Remove Associate";
            this.button7.UseVisualStyleBackColor = true;
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
            this.dataGridView4.Size = new System.Drawing.Size(768, 222);
            this.dataGridView4.TabIndex = 17;
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
            // addAssociate_btn
            // 
            this.addAssociate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAssociate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAssociate_btn.Location = new System.Drawing.Point(597, 254);
            this.addAssociate_btn.Name = "addAssociate_btn";
            this.addAssociate_btn.Size = new System.Drawing.Size(178, 36);
            this.addAssociate_btn.TabIndex = 13;
            this.addAssociate_btn.Text = "Add Associate";
            this.addAssociate_btn.UseVisualStyleBackColor = true;
            // 
            // learningObjective_textBox
            // 
            this.learningObjective_textBox.Location = new System.Drawing.Point(12, 119);
            this.learningObjective_textBox.Multiline = true;
            this.learningObjective_textBox.Name = "learningObjective_textBox";
            this.learningObjective_textBox.Size = new System.Drawing.Size(875, 78);
            this.learningObjective_textBox.TabIndex = 10;
            this.learningObjective_textBox.Text = "Learning Objective...";
            this.learningObjective_textBox.TextChanged += new System.EventHandler(this.LearningObjective_textBox_TextChanged);
            // 
            // projectID_displayText
            // 
            this.projectID_displayText.AutoSize = true;
            this.projectID_displayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectID_displayText.Location = new System.Drawing.Point(701, 9);
            this.projectID_displayText.Name = "projectID_displayText";
            this.projectID_displayText.Size = new System.Drawing.Size(0, 20);
            this.projectID_displayText.TabIndex = 11;
            this.projectID_displayText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // term_textBox
            // 
            this.term_textBox.Location = new System.Drawing.Point(336, 48);
            this.term_textBox.Name = "term_textBox";
            this.term_textBox.Size = new System.Drawing.Size(79, 26);
            this.term_textBox.TabIndex = 5;
            this.term_textBox.Text = "Term";
            this.term_textBox.TextChanged += new System.EventHandler(this.Term_textBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Controls.Add(this.addDeliverable_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 304);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deliverables";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(493, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 36);
            this.button4.TabIndex = 20;
            this.button4.Text = "Remove Deliverable";
            this.button4.UseVisualStyleBackColor = true;
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
            this.dataGridView3.Size = new System.Drawing.Size(861, 222);
            this.dataGridView3.TabIndex = 18;
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
            // addDeliverable_btn
            // 
            this.addDeliverable_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDeliverable_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeliverable_btn.Location = new System.Drawing.Point(711, 254);
            this.addDeliverable_btn.Name = "addDeliverable_btn";
            this.addDeliverable_btn.Size = new System.Drawing.Size(156, 36);
            this.addDeliverable_btn.TabIndex = 12;
            this.addDeliverable_btn.Text = "Add Deliverable";
            this.addDeliverable_btn.UseVisualStyleBackColor = true;
            this.addDeliverable_btn.Click += new System.EventHandler(this.AddDeliverable_btn_Click);
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
            this.projectStatus_comboBox.Location = new System.Drawing.Point(421, 13);
            this.projectStatus_comboBox.Name = "projectStatus_comboBox";
            this.projectStatus_comboBox.Size = new System.Drawing.Size(273, 28);
            this.projectStatus_comboBox.TabIndex = 6;
            this.projectStatus_comboBox.Text = "Status";
            this.projectStatus_comboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectStatus_comboBox_SelectedIndexChanged);
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
            this.projectType_comboBox.Location = new System.Drawing.Point(12, 82);
            this.projectType_comboBox.Name = "projectType_comboBox";
            this.projectType_comboBox.Size = new System.Drawing.Size(271, 28);
            this.projectType_comboBox.TabIndex = 1;
            this.projectType_comboBox.Text = "Project Type";
            this.projectType_comboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectType_comboBox_SelectedIndexChanged);
            // 
            // department_textBox
            // 
            this.department_textBox.Location = new System.Drawing.Point(12, 48);
            this.department_textBox.Name = "department_textBox";
            this.department_textBox.Size = new System.Drawing.Size(227, 26);
            this.department_textBox.TabIndex = 3;
            this.department_textBox.Text = "Department";
            this.department_textBox.TextChanged += new System.EventHandler(this.Department_textBox_TextChanged);
            // 
            // courseNumber_textBox
            // 
            this.courseNumber_textBox.Location = new System.Drawing.Point(245, 48);
            this.courseNumber_textBox.Name = "courseNumber_textBox";
            this.courseNumber_textBox.Size = new System.Drawing.Size(86, 26);
            this.courseNumber_textBox.TabIndex = 4;
            this.courseNumber_textBox.Text = "Course #";
            this.courseNumber_textBox.TextChanged += new System.EventHandler(this.CourseNumber_textBox_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Controls.Add(this.addLink_btn);
            this.groupBox4.Location = new System.Drawing.Point(11, 761);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(877, 231);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Links";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(494, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Remove Link";
            this.button2.UseVisualStyleBackColor = true;
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
            this.dataGridView2.Size = new System.Drawing.Size(862, 154);
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
            this.addLink_btn.Location = new System.Drawing.Point(712, 185);
            this.addLink_btn.Name = "addLink_btn";
            this.addLink_btn.Size = new System.Drawing.Size(156, 36);
            this.addLink_btn.TabIndex = 11;
            this.addLink_btn.Text = "Add Link";
            this.addLink_btn.UseVisualStyleBackColor = true;
            this.addLink_btn.Click += new System.EventHandler(this.AddLink_btn_Click);
            // 
            // projectPriority_comboBox
            // 
            this.projectPriority_comboBox.FormattingEnabled = true;
            this.projectPriority_comboBox.Items.AddRange(new object[] {
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
            this.projectPriority_comboBox.Location = new System.Drawing.Point(700, 13);
            this.projectPriority_comboBox.Name = "projectPriority_comboBox";
            this.projectPriority_comboBox.Size = new System.Drawing.Size(188, 28);
            this.projectPriority_comboBox.TabIndex = 8;
            this.projectPriority_comboBox.Text = "Priority";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1683, 30);
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(279, 25);
            this.toolStripStatusLabel1.Text = "Start typing to create new project.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Due Date:";
            // 
            // ProjectDueDate
            // 
            this.ProjectDueDate.Location = new System.Drawing.Point(527, 48);
            this.ProjectDueDate.Name = "ProjectDueDate";
            this.ProjectDueDate.Size = new System.Drawing.Size(361, 26);
            this.ProjectDueDate.TabIndex = 2;
            this.ProjectDueDate.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.AddUpdate_btn);
            this.groupBox3.Location = new System.Drawing.Point(10, 1009);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(877, 231);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Updates";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(494, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Remove Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.actionTaken,
            this.details});
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(862, 154);
            this.dataGridView1.TabIndex = 17;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // actionTaken
            // 
            this.actionTaken.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.actionTaken.HeaderText = "Action Taken";
            this.actionTaken.Name = "actionTaken";
            // 
            // details
            // 
            this.details.HeaderText = "More Details";
            this.details.Name = "details";
            // 
            // AddUpdate_btn
            // 
            this.AddUpdate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUpdate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUpdate_btn.Location = new System.Drawing.Point(712, 185);
            this.AddUpdate_btn.Name = "AddUpdate_btn";
            this.AddUpdate_btn.Size = new System.Drawing.Size(156, 36);
            this.AddUpdate_btn.TabIndex = 11;
            this.AddUpdate_btn.Text = "Add Update";
            this.AddUpdate_btn.UseVisualStyleBackColor = true;
            this.AddUpdate_btn.Click += new System.EventHandler(this.AddUpdate_btn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.collectionPath);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.dataGridView5);
            this.groupBox5.Location = new System.Drawing.Point(894, 324);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(781, 916);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Projects";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(7, 870);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 40);
            this.button3.TabIndex = 38;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // collectionPath
            // 
            this.collectionPath.Location = new System.Drawing.Point(91, 875);
            this.collectionPath.Name = "collectionPath";
            this.collectionPath.Size = new System.Drawing.Size(466, 26);
            this.collectionPath.TabIndex = 37;
            this.collectionPath.Text = "Collection Path";
            this.collectionPath.TextChanged += new System.EventHandler(this.CollectionPath_TextChanged);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(563, 870);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(212, 36);
            this.button5.TabIndex = 19;
            this.button5.Text = "Load Project";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department,
            this.courseNumber,
            this.projName,
            this.due,
            this.priority,
            this.load});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView5.Location = new System.Drawing.Point(7, 26);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 28;
            this.dataGridView5.Size = new System.Drawing.Size(768, 838);
            this.dataGridView5.TabIndex = 17;
            // 
            // department
            // 
            this.department.HeaderText = "Dep.";
            this.department.Name = "department";
            this.department.Width = 50;
            // 
            // courseNumber
            // 
            this.courseNumber.HeaderText = "#";
            this.courseNumber.Name = "courseNumber";
            this.courseNumber.Width = 40;
            // 
            // projName
            // 
            this.projName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projName.HeaderText = "Project Name";
            this.projName.Name = "projName";
            // 
            // due
            // 
            this.due.HeaderText = "Due";
            this.due.Name = "due";
            this.due.Width = 60;
            // 
            // priority
            // 
            this.priority.HeaderText = "Priority";
            this.priority.Name = "priority";
            this.priority.Width = 60;
            // 
            // load
            // 
            this.load.HeaderText = "Load";
            this.load.Name = "load";
            this.load.Width = 50;
            // 
            // updateBindingSource
            // 
            this.updateBindingSource.DataSource = typeof(Project_Management_Utility_2._0.Update);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(802, 1339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(262, 65);
            this.button6.TabIndex = 37;
            this.button6.Text = "temp save button";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1683, 1476);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectDueDate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.projectPriority_comboBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.courseNumber_textBox);
            this.Controls.Add(this.department_textBox);
            this.Controls.Add(this.projectID_displayText);
            this.Controls.Add(this.projectType_comboBox);
            this.Controls.Add(this.projectStatus_comboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.term_textBox);
            this.Controls.Add(this.learningObjective_textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.projectDescription_textBox);
            this.Controls.Add(this.projectName_textBox);
            this.Name = "MainForm";
            this.Text = "The Wizard\'s Wizard";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox projectName_textBox;
        private System.Windows.Forms.TextBox projectDescription_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addAssociate_btn;
        private System.Windows.Forms.TextBox learningObjective_textBox;
        private System.Windows.Forms.Label projectID_displayText;
        private System.Windows.Forms.TextBox term_textBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addDeliverable_btn;
        private System.Windows.Forms.ComboBox projectStatus_comboBox;
        private System.Windows.Forms.ComboBox projectType_comboBox;
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
        private System.Windows.Forms.Button addLink_btn;
        private System.Windows.Forms.ComboBox projectPriority_comboBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn associateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn associateEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn associateRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaType;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker ProjectDueDate;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource updateBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.Button AddUpdate_btn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn projName;
        private System.Windows.Forms.DataGridViewTextBoxColumn due;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn load;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox collectionPath;
        private System.Windows.Forms.Button button6;
    }
}

