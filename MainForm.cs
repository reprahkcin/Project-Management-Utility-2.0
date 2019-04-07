using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Project_Management_Utility_2._0
{
    public partial class MainForm : Form
    {
        public Project currentProject; //Create the home for everything currently on-screen, will be overwritten 
        
        List<string> listFiles = new List<string>(); // helps browser display home directory choices
        private string _savePath;

        public MainForm()
        {
            InitializeComponent();
            NewProject();
        }

        public void NewProject()
        {
            currentProject = new Project();
            currentProject.id = generateID();
            Update update = new Update();
            update.time = new Timestamp("Project Created");
            currentProject.updates.Add(update);
            currentProject.timestamps.Add(new Timestamp("Project Created"));
        }

        public static string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        private void ProjectType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentProject.type = projectType_comboBox.SelectedText;
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
            using (var deliverableForm = new DeliverableForm())
            {
                if (deliverableForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Deliverable deliverable = new Deliverable();
                    deliverable.name = deliverableForm.name;
                    deliverable.description = deliverableForm.description;
                    deliverable.priority = deliverableForm.priority;
                    deliverable.mediaType = deliverableForm.mediaType;
                    deliverable.dueDate = deliverableForm.dueDate;
                    deliverable.status = deliverableForm.status;
                    deliverable.quantity = deliverableForm.quantity;
                    deliverable.estimatedTimePer = deliverableForm.estimatedTimePer;
                    deliverable.accessibility = deliverableForm.accessibility;
                    deliverable.teamResponsible = deliverableForm.teamResponsible;
                    deliverable.finalLink = deliverableForm.finalLink;
                    currentProject.deliverables.Add(deliverable);
                    currentProject.timestamps.Add(new Timestamp("Added Deliverable"));
                   
                }
            }
        }

        private void AddLink_btn_Click(object sender, EventArgs e)
        {
            using (var linkForm = new LinkForm())
            {
                if (linkForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Link link = new Link();
                    link.url = linkForm.url;
                    link.linkType = linkForm.linkType;
                    link.notes = linkForm.notes;
                    currentProject.links.Add(link);
                    currentProject.timestamps.Add(new Timestamp("Added Link"));
                }
            }
 
        }

        private void AddUpdate_btn_Click(object sender, EventArgs e)
        {
            using (var updateForm = new UpdateForm())
            {
                if (updateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Update update = new Update();
                    update.note = updateForm.note;
                    update.time = new Timestamp("Update");
                    update.nextSteps = updateForm.nextSteps;
                    currentProject.updates.Add(update);
                    currentProject.timestamps.Add(new Timestamp("Project Update"));
                }
            }
        }
        private void AddAssociate_btn_Click(object sender, EventArgs e)
        {
            using (var associateForm = new AssociateForm())
            {
                if (associateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Associate associate = new Associate();
                    associate.name = associateForm.name;
                    associate.email = associateForm.email;
                    associate.phone = associateForm.phone;
                    associate.role = associateForm.role;
                    associate.department = associateForm.department;
                    associate.notes = associateForm.notes;
                    currentProject.associates.Add(associate);
                    currentProject.timestamps.Add(new Timestamp("Added Associate"));
                }
            }
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

        private void Button8_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
