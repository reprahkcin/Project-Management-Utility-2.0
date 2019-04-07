using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Project_Management_Utility_2._0
{
    public partial class MainForm : Form
    {
        public Project currentProject; //Create the home for everything currently on-screen, will be overwritten 

        public string savePath;

        public MainForm()
        {
            InitializeComponent();
            NewProject();
        }

        public void NewProject()
        {
            currentProject = new Project {id = generateID()};
            Update update = new Update {time = new Timestamp("Project Created")};
            currentProject.updates.Add(update);
            currentProject.timestamps.Add(new Timestamp("Project Created"));
        }

        #region Displaying Objects in Grids
        public void AddLinksToGrid()
        {
            links_dataGridView.Rows.Clear();
            foreach (Link link in currentProject.links)
            {
                int n = links_dataGridView.Rows.Add();
                links_dataGridView.Rows[n].Cells[0].Value = link.url;
                links_dataGridView.Rows[n].Cells[1].Value = link.linkType;
                links_dataGridView.Columns[1].Width = 200;
                links_dataGridView.Rows[n].Cells[0].ToolTipText = link.notes;
            }
        }

        public void AddDeliverablesToGrid()
        {
            deliverables_dataGridView.Rows.Clear();
            foreach (Deliverable deliverable in currentProject.deliverables)
            {
                int n = deliverables_dataGridView.Rows.Add();
                deliverables_dataGridView.Rows[n].Cells[0].Value = deliverable.quantity;
                deliverables_dataGridView.Columns[0].Width = 30;
                deliverables_dataGridView.Rows[n].Cells[1].Value = deliverable.estimatedTimePer;
                deliverables_dataGridView.Columns[1].Width = deliverable.estimatedTimePer.Length*8;
                deliverables_dataGridView.Rows[n].Cells[2].Value = deliverable.mediaType;
                deliverables_dataGridView.Columns[2].Width = deliverable.mediaType.Length * 8;
                deliverables_dataGridView.Rows[n].Cells[3].Value = deliverable.name;
            }
        }


        public void AddUpdatesToGrid()
        {
            updates_dataGridView.Rows.Clear();
            foreach (Update update in currentProject.updates)
            {
                int n = updates_dataGridView.Rows.Add();
                updates_dataGridView.Rows[n].Cells[0].Value = update.time.time;
                updates_dataGridView.Rows[n].Cells[1].Value = update.note;
                updates_dataGridView.Rows[n].Cells[2].Value = update.time.stampType;
                //updates_dataGridView.Rows[n].Cells[2].Value = ; <-- make this a link to open up the dialog and load self for editing.
            }
        }

        public void AddAssociatesToGrid()
        {
            associates_dataGridView.Rows.Clear();
            foreach (Associate associate in currentProject.associates)
            {
                int n = associates_dataGridView.Rows.Add();
                associates_dataGridView.Rows[n].Cells[0].Value = associate.name;
                associates_dataGridView.Rows[n].Cells[1].Value = associate.email;
                associates_dataGridView.Rows[n].Cells[2].Value = associate.role;
            }
        }

        public void DisplayAllProjects()
        {
            //projects_dataGridView.Rows.Clear();

            //List<Project> projectCollection = new List<Project>();
            //projectCollection.Add();
        }
#endregion

        #region Adding Objects to Project
        public static string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        private void AddDeliverable_btn_Click(object sender, EventArgs e)
        {
            using (var deliverableForm = new DeliverableForm())
            {
                if (deliverableForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Deliverable deliverable = new Deliverable
                    {
                        name = deliverableForm.name,
                        description = deliverableForm.description,
                        priority = deliverableForm.priority,
                        mediaType = deliverableForm.mediaType,
                        dueDate = deliverableForm.dueDate,
                        status = deliverableForm.status,
                        quantity = deliverableForm.quantity,
                        estimatedTimePer = deliverableForm.estimatedTimePer,
                        accessibility = deliverableForm.accessibility,
                        teamResponsible = deliverableForm.teamResponsible,
                        finalLink = deliverableForm.finalLink,
                        finalDuration = deliverableForm.finalDuration
                    };
                    currentProject.deliverables.Add(deliverable);
                    currentProject.timestamps.Add(new Timestamp("Added Deliverable"));

                    AddDeliverablesToGrid();

                }
            }
        }
        private void AddLink_btn_Click(object sender, EventArgs e)
        {
            using (var linkForm = new LinkForm())
            {
                if (linkForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Link link = new Link { url = linkForm.url, linkType = linkForm.linkType, notes = linkForm.notes };
                    currentProject.links.Add(link);
                    currentProject.timestamps.Add(new Timestamp("Added Link"));

                    int n = links_dataGridView.Rows.Add();
                    links_dataGridView.Rows[n].Cells[0].Value = link.url;
                    links_dataGridView.Rows[n].Cells[1].Value = link.linkType;

                    AddLinksToGrid();
                }
            }

        }
        private void AddUpdate_btn_Click(object sender, EventArgs e)
        {
            using (var updateForm = new UpdateForm())
            {
                if (updateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Update update = new Update
                    {
                        note = updateForm.note,
                        time = new Timestamp("Update"),
                        nextSteps = updateForm.nextSteps
                    };
                    currentProject.updates.Add(update);
                    currentProject.timestamps.Add(new Timestamp("Project Update"));

                    AddUpdatesToGrid();
                }
            }
        }
        private void AddAssociate_btn_Click(object sender, EventArgs e)
        {
            using (var associateForm = new AssociateForm())
            {
                if (associateForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Associate associate = new Associate
                    {
                        name = associateForm.name,
                        email = associateForm.email,
                        phone = associateForm.phone,
                        role = associateForm.role,
                        department = associateForm.department,
                        notes = associateForm.notes
                    };
                    currentProject.associates.Add(associate);
                    currentProject.timestamps.Add(new Timestamp("Added Associate"));

                    int n = associates_dataGridView.Rows.Add();
                    associates_dataGridView.Rows[n].Cells[0].Value = associate.name;
                    associates_dataGridView.Rows[n].Cells[1].Value = associate.email;
                    associates_dataGridView.Rows[n].Cells[2].Value = associate.role;

                    AddAssociatesToGrid();
                }
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select Folder." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    collectionPath.Text = fbd.SelectedPath;

                }
            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            string serializedJson = JsonConvert.SerializeObject(currentProject);
            File.WriteAllText(savePath + "\\" + projectName_textBox.Text + ".json", serializedJson);
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        #endregion

        #region Form Field Functions
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
            switch (projectStatus_comboBox.Text)
            {
                case "Late":
                    status_panel.BackColor = Color.Crimson;
                    break;
                case "On Hold":
                    status_panel.BackColor = Color.Goldenrod;
                    break;
                case "Waiting for Content":
                    status_panel.BackColor = Color.Goldenrod;
                    break;
                default:
                    status_panel.BackColor = Color.DarkSeaGreen;
                    break;
            }

            
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

        private void CollectionPath_TextChanged(object sender, EventArgs e)
        {
            savePath = collectionPath.Text;
        }

        #endregion

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            var email = new Email();
            email.SendMessage();
        }
    }
}
