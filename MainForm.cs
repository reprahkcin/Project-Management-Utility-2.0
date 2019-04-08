using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;

namespace Project_Management_Utility_2._0
{
    public partial class MainForm : Form
    {
        public Project CurrentProject; //Create the home for everything currently on-screen, will be overwritten 

        public string SavePath;

        public List<Project> ProjectCollection = new List<Project>();

        public void CreateTimestamp(string type)
        {
            Timestamp t = new Timestamp(type);
            CurrentProject.timestamps.Add(t);
        }

        public MainForm()
        {
            InitializeComponent();
            NewProject();
        }

        public void NewProject()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }

                if (c.GetType() == typeof(ComboBox))
                {
                    (c as ComboBox).SelectedIndex = -1;
                }

                if (c.GetType() == typeof(Panel))
                {
                    c.BackColor = DefaultBackColor;
                }

                collectionPath.Text = File.ReadAllText(Application.StartupPath + @"\SavePath.txt");
                SavePath = File.ReadAllText(Application.StartupPath + @"\SavePath.txt");
                links_dataGridView.Rows.Clear();
                associates_dataGridView.Rows.Clear();
                updates_dataGridView.Rows.Clear();
                deliverables_dataGridView.Rows.Clear();
                
            }
            CurrentProject = new Project {id = GenerateId()};
            Update update = new Update {time = new Timestamp("Project Created")};
            CurrentProject.updates.Add(update);
            CurrentProject.timestamps.Add(new Timestamp("Project Created"));
        }

        public void LoadProject(Project p)
        {
           
            CurrentProject = p;
            projectName_textBox.Text = CurrentProject.name;
            projectStatus_comboBox.Text = CurrentProject.status;
            department_textBox.Text = CurrentProject.department;
            courseNumber_textBox.Text = CurrentProject.courseNumber;
            term_textBox.Text = CurrentProject.term;
            projectPriority_comboBox.Text = CurrentProject.priority;
            projectType_comboBox.Text = CurrentProject.type;

            if (CurrentProject.dueDate.Date.Year > 2018)
            {
                ProjectDueDate.Value = CurrentProject.dueDate.Date;
            }
            
            learningObjective_textBox.Text = CurrentProject.learningObjective;
            projectDescription_textBox.Text = CurrentProject.description;
            AddLinksToGrid();
            AddUpdatesToGrid();
            AddDeliverablesToGrid();
            AddAssociatesToGrid();

        }

        #region Displaying Objects in Grids
        public void AddLinksToGrid()
        {
            links_dataGridView.Rows.Clear();
            foreach (Link link in CurrentProject.links)
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
            foreach (Deliverable deliverable in CurrentProject.deliverables)
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
            foreach (Update update in CurrentProject.updates)
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
            foreach (Associate associate in CurrentProject.associates)
            {
                int n = associates_dataGridView.Rows.Add();
                associates_dataGridView.Rows[n].Cells[0].Value = associate.name;
                associates_dataGridView.Rows[n].Cells[1].Value = associate.email;
                associates_dataGridView.Rows[n].Cells[2].Value = associate.role;
            }
        }

        public void DisplayAllProjects()
        {
            projects_dataGridView.Rows.Clear();
            ProjectCollection.Clear();
            //string[] projectList = new string[Directory.GetFiles(SavePath).Length];
            string[] projectList = new string[100]; // this is hacky, but it breaks if you do it like above.
            projectList = Directory.GetFiles(SavePath);

            foreach (var path in projectList)
            {
                string json = File.ReadAllText(path);
                Project p = JsonConvert.DeserializeObject<Project>(json);
                ProjectCollection.Add(p);
            }

            foreach (Project project in ProjectCollection)
            {
                int n = projects_dataGridView.Rows.Add();
                projects_dataGridView.Rows[n].Cells[0].Value = project.department;
                projects_dataGridView.Columns[0].Width = 50;
                projects_dataGridView.Rows[n].Cells[1].Value = project.courseNumber;
                projects_dataGridView.Columns[1].Width = 30;
                projects_dataGridView.Rows[n].Cells[2].Value = project.name;
                projects_dataGridView.Rows[n].Cells[3].Value = project.status;
                projects_dataGridView.Columns[3].Width = 100;
                projects_dataGridView.Rows[n].Cells[4].Value = project.priority;
                projects_dataGridView.Rows[n].Cells[5].Value = project.term;
                projects_dataGridView.Columns[5].Width = 30;
            }
            



        }
        #endregion

        #region Adding Objects to Project
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }

        private void AddDeliverable_btn_Click(object sender, EventArgs e)
        {
            using (var deliverableForm = new DeliverableForm())
            {
                if (deliverableForm.ShowDialog() == DialogResult.OK)
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
                    };

                    
                    CurrentProject.deliverables.Add(deliverable);
                    CurrentProject.timestamps.Add(new Timestamp("Added Deliverable"));

                    AddDeliverablesToGrid();

                }
            }
        }
        private void AddLink_btn_Click(object sender, EventArgs e)
        {
            using (var linkForm = new LinkForm())
            {
                if (linkForm.ShowDialog() == DialogResult.OK)
                {
                    Link link = new Link { url = linkForm.url, linkType = linkForm.linkType, notes = linkForm.notes };
                    CurrentProject.links.Add(link);
                    CurrentProject.timestamps.Add(new Timestamp("Added Link"));

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
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    Update update = new Update
                    {
                        note = updateForm.note,
                        time = new Timestamp("Update"),
                        nextSteps = updateForm.nextSteps
                    };
                    CurrentProject.updates.Add(update);
                    CurrentProject.timestamps.Add(new Timestamp("Project Update"));

                    AddUpdatesToGrid();
                }
            }
        }
        private void AddAssociate_btn_Click(object sender, EventArgs e)
        {
            using (var associateForm = new AssociateForm())
            {
                if (associateForm.ShowDialog() == DialogResult.OK)
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
                    CurrentProject.associates.Add(associate);
                    CurrentProject.timestamps.Add(new Timestamp("Added Associate"));

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
                   
                    File.WriteAllText(Application.StartupPath + @"\SavePath.txt",fbd.SelectedPath );
                }
            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            string serializedJson = JsonConvert.SerializeObject(CurrentProject);
            File.WriteAllText(SavePath + "\\" + projectName_textBox.Text + ".json", serializedJson);
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        #endregion

        #region Form Field Functions
        private void ProjectStatus_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentProject.status = projectStatus_comboBox.Text;
            switch (projectStatus_comboBox.Text)
            {
                case "Late":
                    status_panel.BackColor = Color.Crimson;
                    break;
                case "On Hold":
                    status_panel.BackColor = Color.Orange;
                    break;
                case "Waiting for Content":
                    status_panel.BackColor = Color.Orange;
                    break;
                case "Under Review":
                    status_panel.BackColor = Color.Orange;
                    break;
                case "Approved":
                    status_panel.BackColor = Color.Green;
                    break;
                case "Discovery":
                    status_panel.BackColor = Color.Blue;
                    break;
                case "Ready for Action":
                    status_panel.BackColor = Color.Aqua;
                    break;
                case "Working":
                    status_panel.BackColor = Color.Green;
                    break;
                case "Cancelled":
                    status_panel.BackColor = Color.DarkGray;
                    break;
                case "Complete":
                    status_panel.BackColor = Color.DarkGreen;
                    break;
                case "Revisions Pending":
                    status_panel.BackColor = Color.Orange;
                    break;
                default:
                    status_panel.BackColor = Color.DarkSeaGreen;
                    break;
            }


        }

        private void ProjectType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentProject.type = projectType_comboBox.Text;
        }

        private void Department_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.department = department_textBox.Text;
        }

        private void CourseNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.courseNumber = courseNumber_textBox.Text;
        }

        private void Term_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.term = term_textBox.Text;
        }

        private void ProjectName_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.name = projectName_textBox.Text;
        }

        private void ProjectDescription_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.description = projectDescription_textBox.Text;
        }

        private void LearningObjective_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.learningObjective = learningObjective_textBox.Text;
        }

        private void CollectionPath_TextChanged(object sender, EventArgs e)
        {
            SavePath = collectionPath.Text;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            var email = new Email();
            email.SendMessage();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DisplayAllProjects();
        }

        private void ProjectPriority_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentProject.priority = projectPriority_comboBox.Text;
        }

        private void ProjectDueDate_ValueChanged(object sender, EventArgs e)
        {
            CurrentProject.dueDate = ProjectDueDate.Value;
            CreateTimestamp("Due Date Changed");
       
        }

        #endregion

        private void Button16_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select Folder..." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    collectionPath.Text = fbd.SelectedPath;

                    File.WriteAllText(Application.StartupPath + @"\SavePath.txt", fbd.SelectedPath);
                }
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string json = File.ReadAllText(SavePath + "\\" + ofd.SafeFileName);
                    Project p = JsonConvert.DeserializeObject<Project>(json);
                    LoadProject(p);
                }
            }
        }
    }
}
