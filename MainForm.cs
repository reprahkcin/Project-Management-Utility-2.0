using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Project_Management_Utility_2._0
{
    public partial class MainForm : Form
    {
        public Project currentProject = new Project(); //Create the home for everything currently on-screen, will be overwritten 
        //private static string id = generateID();
        //public string savePath;

        public Timestamp updateTimestamp;
       
        public Update currentUpdate;

        List<string> listFiles = new List<string>();

        private string _savePath;

        public MainForm()
        {
            InitializeComponent();
        }


        public static string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        private void ProjectType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProject.type = projectType_comboBox.SelectedText;
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Department_textBox_TextChanged(object sender, EventArgs e)
        {
            currentProject.department = department_textBox.Text;
        }

        private void CourseNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            currentProject.courseNumber = courseNumber_textBox.Text;
        }

        private void Term_textBox_TextChanged(object sender, EventArgs e)
        {
            currentProject.term = term_textBox.Text;
        }

        private void ProjectStatus_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProject.status = projectStatus_comboBox.SelectedText;
        }

        private void ProjectName_textBox_TextChanged(object sender, EventArgs e)
        {
            currentProject.name = projectName_textBox.Text;
        }

        private void ProjectDescription_textBox_TextChanged(object sender, EventArgs e)
        {
            currentProject.description = projectDescription_textBox.Text;
        }

        private void LearningObjective_textBox_TextChanged(object sender, EventArgs e)
        {
            currentProject.learningObjective = learningObjective_textBox.Text;
        }

        private void AddDeliverable_btn_Click(object sender, EventArgs e)
        {
            var deliverableForm = new DeliverableForm();
            deliverableForm.Show();
        }



        private void AddLink_btn_Click(object sender, EventArgs e)
        {
            Link link = new Link();
            var linkForm = new LinkForm();
            linkForm.ShowDialog();
            link.url = linkForm.url;
            link.linkType = linkForm.linkType;
            link.notes = linkForm.notes;
            currentProject.links.Add(link);
        }

        private void AddUpdate_btn_Click(object sender, EventArgs e)
        {
            var updateForm = new UpdateForm();
            updateForm.Show();
            currentProject.updates.Add(updateForm.currentUpdate);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select folder." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    collectionPath.Text = fbd.SelectedPath;
                    
                }
            }
        }

        private void CollectionPath_TextChanged(object sender, EventArgs e)
        {
            _savePath = collectionPath.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string serializedJson = JsonConvert.SerializeObject(currentProject);
            File.WriteAllText(_savePath + "\\" + projectName_textBox.Text + ".json", serializedJson);
        }
    }
}
