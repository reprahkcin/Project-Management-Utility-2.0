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
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.ProjectDescription = new System.Windows.Forms.TextBox();
            this.AssociateEmail = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.ComboBox();
            this.Associate = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(13, 38);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(682, 26);
            this.ProjectName.TabIndex = 0;
            this.ProjectName.Text = "Project Name";
            // 
            // ProjectDescription
            // 
            this.ProjectDescription.Location = new System.Drawing.Point(13, 70);
            this.ProjectDescription.Multiline = true;
            this.ProjectDescription.Name = "ProjectDescription";
            this.ProjectDescription.Size = new System.Drawing.Size(682, 520);
            this.ProjectDescription.TabIndex = 1;
            this.ProjectDescription.Text = "Project Description...";
            // 
            // AssociateEmail
            // 
            this.AssociateEmail.Location = new System.Drawing.Point(6, 57);
            this.AssociateEmail.Name = "AssociateEmail";
            this.AssociateEmail.Size = new System.Drawing.Size(543, 26);
            this.AssociateEmail.TabIndex = 2;
            this.AssociateEmail.Text = "Email Address";
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
            this.Position.Location = new System.Drawing.Point(6, 89);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(543, 28);
            this.Position.TabIndex = 3;
            this.Position.Text = "Role";
            // 
            // Associate
            // 
            this.Associate.Location = new System.Drawing.Point(6, 25);
            this.Associate.Name = "Associate";
            this.Associate.Size = new System.Drawing.Size(543, 26);
            this.Associate.TabIndex = 4;
            this.Associate.Text = "Full Name";
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(555, 25);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(129, 44);
            this.Update.TabIndex = 5;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Associate);
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.AssociateEmail);
            this.groupBox1.Controls.Add(this.Position);
            this.groupBox1.Location = new System.Drawing.Point(13, 843);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Associates";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(690, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Inquiry";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(825, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Initial";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(744, 978);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add Associate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "You have X days left\r\nto work on this";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date Created";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 597);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(682, 70);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Learning Objective...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Project ID: XXX-XXX";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(702, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 26);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "Term";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 25);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(709, 194);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Deliverable Description...";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(721, 59);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(74, 26);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Quantity";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(721, 91);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(233, 26);
            this.textBox5.TabIndex = 15;
            this.textBox5.Text = "Duration";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(721, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Project Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.comboBox8);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox5);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 1065);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 314);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deliverables";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Custom",
            "Web",
            "Audio",
            "Video"});
            this.comboBox2.Location = new System.Drawing.Point(721, 157);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 28);
            this.comboBox2.TabIndex = 18;
            this.comboBox2.Text = "Team Responsible";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Captions",
            "Full WCAG 2.0"});
            this.comboBox3.Location = new System.Drawing.Point(721, 123);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(233, 28);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.Text = "Accessibility";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(744, 1385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(223, 42);
            this.button4.TabIndex = 18;
            this.button4.Text = "Add Deliverable";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 225);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(709, 26);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "Deliverable Resources Link";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 259);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(709, 26);
            this.textBox7.TabIndex = 21;
            this.textBox7.Text = "Deliverable Resources Link";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Final Link",
            "Caption Link",
            "Source FIles",
            "Misc. Resources"});
            this.comboBox5.Location = new System.Drawing.Point(721, 225);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(233, 28);
            this.comboBox5.TabIndex = 23;
            this.comboBox5.Text = "Link Category";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(702, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 520);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timestamps";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date Last Modified";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Approved";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date Started";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date Started";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
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
            "Revisions Pending"});
            this.comboBox6.Location = new System.Drawing.Point(787, 36);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(186, 28);
            this.comboBox6.TabIndex = 20;
            this.comboBox6.Text = "Status";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Course-Related - NEW",
            "Course-Related - REFRESH",
            "Course-Related - Hot Fix",
            "Internal - SHORT TERM",
            "Internal - LONG TERM",
            "Miscellaneous"});
            this.comboBox7.Location = new System.Drawing.Point(13, 4);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(271, 28);
            this.comboBox7.TabIndex = 21;
            this.comboBox7.Text = "Project Type";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 1754);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 43);
            this.button5.TabIndex = 22;
            this.button5.Text = "Generate Folders";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Final Link",
            "Caption Link",
            "Source FIles",
            "Misc. Resources"});
            this.comboBox4.Location = new System.Drawing.Point(721, 259);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(233, 28);
            this.comboBox4.TabIndex = 24;
            this.comboBox4.Text = "Link Category";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(171, 1754);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 43);
            this.button6.TabIndex = 23;
            this.button6.Text = "Generate Reports";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(330, 1754);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(153, 43);
            this.button7.TabIndex = 24;
            this.button7.Text = "Push to MCLL";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
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
            "Revisions Pending"});
            this.comboBox8.Location = new System.Drawing.Point(721, 25);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(233, 28);
            this.comboBox8.TabIndex = 25;
            this.comboBox8.Text = "Status";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(12, 674);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(683, 70);
            this.textBox8.TabIndex = 25;
            this.textBox8.Text = "Next Steps...";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(801, 59);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(153, 26);
            this.textBox9.TabIndex = 26;
            this.textBox9.Text = "Estimated Time Per";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(787, 1754);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(186, 43);
            this.button8.TabIndex = 26;
            this.button8.Text = "Finalize";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(787, 1702);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(186, 46);
            this.button9.TabIndex = 27;
            this.button9.Text = "Roundtrip YouTube";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "Shared",
            "Source Files",
            "Misc. Resources"});
            this.comboBox10.Location = new System.Drawing.Point(701, 748);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(272, 28);
            this.comboBox10.TabIndex = 29;
            this.comboBox10.Text = "Link Category";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(12, 750);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(683, 26);
            this.textBox11.TabIndex = 27;
            this.textBox11.Text = "Project Resources Link";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "Shared",
            "Source Files",
            "Misc. Resources"});
            this.comboBox9.Location = new System.Drawing.Point(701, 780);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(272, 28);
            this.comboBox9.TabIndex = 31;
            this.comboBox9.Text = "Link Category";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(12, 782);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(683, 26);
            this.textBox10.TabIndex = 30;
            this.textBox10.Text = "Project Resources Link";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(787, 1650);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(186, 46);
            this.button10.TabIndex = 32;
            this.button10.Text = "Upload to Kaltura";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(787, 1598);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(186, 46);
            this.button11.TabIndex = 33;
            this.button11.Text = "Deploy";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(985, 1809);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.comboBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ProjectDescription);
            this.Controls.Add(this.ProjectName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.TextBox ProjectDescription;
        private System.Windows.Forms.TextBox AssociateEmail;
        private System.Windows.Forms.ComboBox Position;
        private System.Windows.Forms.TextBox Associate;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
    }
}

