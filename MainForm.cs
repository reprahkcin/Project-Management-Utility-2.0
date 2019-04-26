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
        public Project CurrentProject; //Create the home for everything currently on-screen, will be overwritten 

        public string SavePath;

        public List<Project> ProjectCollection = new List<Project>();


        // Temporary Link housing
        public static string tempURL = "Enter URL";
        public static string tempLinkType = "Select Type of link";
        public static string tempNote = "Enter any details";
        public static Link TempLink;

        // Temporary Deliverable housing
        public static string tempDeliverableName = "Enter name of media object";
        public static string tempDeliverableDescription = "Enter description and any details";
        public static string tempDeliverablePriority = "Set priority";
        public static string tempDeliverableMediaType = "Media type";
        public static string tempDeliverableStatus = "Set status";
        public static string tempDeliverableQuantity = "1";
        public static string tempDeliverableComplexity = "1";
        public static string tempDeliverableAccessibility = "WCAG 2.0";


        public static string GenerateId()
        {
            return Guid.NewGuid().ToString("N");
        }

        public MainForm()
        {
            InitializeComponent();
            NewProject();
        }

        public void NewProject()
        {
            foreach (Control c in this.Controls)  // Clears text boxes, but leaves save path
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
            CurrentProject = new Project {Id = GenerateId()};
            Update update = new Update {Time = new Timestamp("Project Created")};
            
            CurrentProject.Updates.Add(update);
            CurrentProject.Timestamps.Add(new Timestamp("Project Created"));
            AddUpdatesToGrid();
        }

        public void SaveProject()
        {
            string serializedJson = JsonConvert.SerializeObject(CurrentProject);
            File.WriteAllText(SavePath + "\\" + projectName_textBox.Text + ".json", serializedJson);
        }

        public void BrowseForSavePath()
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select Folder..." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    collectionPath.Text = fbd.SelectedPath;

                    File.WriteAllText(Application.StartupPath + @"\SavePath.txt", fbd.SelectedPath);
                    DisplayAllProjects();
                }
            }
        }

        public void LoadProject(Project p)
        {
           
            CurrentProject = p;
            projectName_textBox.Text = CurrentProject.Name;
            projectStatus_comboBox.Text = CurrentProject.Status;
            department_textBox.Text = CurrentProject.Department;
            courseNumber_textBox.Text = CurrentProject.CourseNumber;
            term_textBox.Text = CurrentProject.Term;
            projectPriority_comboBox.Text = CurrentProject.Priority;
            projectType_comboBox.Text = CurrentProject.Type1;

            if (CurrentProject.DueDate.Date.Year > 2018)
            {
                ProjectDueDate.Value = CurrentProject.DueDate.Date;
            }
            
            learningObjective_textBox.Text = CurrentProject.LearningObjective;
            projectDescription_textBox.Text = CurrentProject.Description;
            AddLinksToGrid();
            AddUpdatesToGrid();
            AddDeliverablesToGrid();
            AddAssociatesToGrid();

        }

        public void CreateTimestamp(string type)
        {
            Timestamp t = new Timestamp(type);
            CurrentProject.Timestamps.Add(t);
        }

        public void AddDeliverable()
        {
            using (var deliverableForm = new DeliverableForm())
            {
                if (deliverableForm.ShowDialog() == DialogResult.OK)
                {
                    Deliverable deliverable = new Deliverable
                    {
                        Name = deliverableForm.DeliverableName,
                        Description = deliverableForm.Description,
                        Priority = deliverableForm.Priority,
                        MediaType = deliverableForm.MediaType,

                        Status = deliverableForm.Status,
                        Quantity = deliverableForm.Quantity,
                        EstimatedTimePer = deliverableForm.EstimatedTimePer,
                        Accessibility = deliverableForm.Accessibility,
                        TeamResponsible = deliverableForm.TeamResponsible,
                    };


                    CurrentProject.Deliverables.Add(deliverable);
                    CurrentProject.Timestamps.Add(new Timestamp("Added Deliverable"));

                    AddDeliverablesToGrid();
                    SaveProject();
                }
            }
        }

        public void AddLink()
        {
            using (var linkForm = new LinkForm())
            {
                if (linkForm.ShowDialog() == DialogResult.OK)
                {
                    Link link = new Link { Url = linkForm.Url, LinkType = linkForm.LinkType, Note = linkForm.Notes };
                    CurrentProject.Links.Add(link);
                    CurrentProject.Timestamps.Add(new Timestamp("Added Link"));

                    int n = links_dataGridView.Rows.Add();
                    links_dataGridView.Rows[n].Cells[0].Value = link.Url;
                    links_dataGridView.Rows[n].Cells[1].Value = link.LinkType;

                    AddLinksToGrid();
                    SaveProject();
                }
            }
            ResetLinkDetails();
        }

        public void AddUpdate()
        {
            using (var updateForm = new UpdateForm())
            {
                if (updateForm.ShowDialog() == DialogResult.OK)
                {
                    Update update = new Update
                    {
                        Note = updateForm.Note,
                        Time = new Timestamp("Update"),
                        NextSteps = updateForm.NextSteps
                    };
                    CurrentProject.Updates.Add(update);
                    CurrentProject.Timestamps.Add(new Timestamp("Project Update"));

                    AddUpdatesToGrid();
                    SaveProject();
                }
            }
        }

        public void AddAssociate()
        {
            using (var associateForm = new AssociateForm())
            {
                if (associateForm.ShowDialog() == DialogResult.OK)
                {
                    Associate associate = new Associate
                    {
                        Name = associateForm.AssociateName,
                        Email = associateForm.Email,
                        Phone = associateForm.Phone,
                        Role = associateForm.Role,
                        Department = associateForm.Department,
                        Notes = associateForm.Notes
                    };
                    CurrentProject.Associates.Add(associate);
                    CurrentProject.Timestamps.Add(new Timestamp("Added Associate"));

                    int n = associates_dataGridView.Rows.Add();
                    associates_dataGridView.Rows[n].Cells[0].Value = associate.Name;
                    associates_dataGridView.Rows[n].Cells[1].Value = associate.Email;
                    associates_dataGridView.Rows[n].Cells[2].Value = associate.Role;

                    AddAssociatesToGrid();
                    SaveProject();
                }
            }
        }


        #region Displaying Objects in Grids
        public void AddLinksToGrid()
        {
            links_dataGridView.Rows.Clear();
            foreach (Link link in CurrentProject.Links)
            {
                int n = links_dataGridView.Rows.Add();
                links_dataGridView.Rows[n].Cells[0].Value = link.Url;
                links_dataGridView.Rows[n].Cells[1].Value = link.LinkType;
                links_dataGridView.Columns[1].Width = 200;
                links_dataGridView.Rows[n].Cells[0].ToolTipText = link.Note;
            }
        }

        public void AddDeliverablesToGrid()
        {
            deliverables_dataGridView.Rows.Clear();
            foreach (Deliverable deliverable in CurrentProject.Deliverables)
            {
                int n = deliverables_dataGridView.Rows.Add();
                deliverables_dataGridView.Rows[n].Cells[0].Value = deliverable.Quantity;
                deliverables_dataGridView.Columns[0].Width = 30;
                deliverables_dataGridView.Rows[n].Cells[1].Value = deliverable.EstimatedTimePer;
                deliverables_dataGridView.Columns[1].Width = deliverable.EstimatedTimePer.Length*8;
                deliverables_dataGridView.Rows[n].Cells[2].Value = deliverable.MediaType;
                deliverables_dataGridView.Columns[2].Width = deliverable.MediaType.Length * 8;
                deliverables_dataGridView.Rows[n].Cells[3].Value = deliverable.Name;
            }
        }

        public void AddUpdatesToGrid()
        {
            updates_dataGridView.Rows.Clear();
            foreach (Update update in CurrentProject.Updates)
            {
                int n = updates_dataGridView.Rows.Add();
                updates_dataGridView.Rows[n].Cells[0].Value = update.Time.Time;
                updates_dataGridView.Rows[n].Cells[1].Value = update.Note;
                updates_dataGridView.Rows[n].Cells[2].Value = update.Time.StampType;
                //updates_dataGridView.Rows[n].Cells[2].Value = ; <-- make this a link to open up the dialog and load self for editing.
            }
        }

        public void AddAssociatesToGrid()
        {
            associates_dataGridView.Rows.Clear();
            foreach (Associate associate in CurrentProject.Associates)
            {
                int n = associates_dataGridView.Rows.Add();
                associates_dataGridView.Rows[n].Cells[0].Value = associate.Name;
                associates_dataGridView.Rows[n].Cells[1].Value = associate.Email;
                associates_dataGridView.Rows[n].Cells[2].Value = associate.Role;
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
                var p = JsonConvert.DeserializeObject<Project>(json);
                ProjectCollection.Add(p);
            }

            foreach (Project project in ProjectCollection)
            {
                int n = projects_dataGridView.Rows.Add();
                projects_dataGridView.Rows[n].Cells[0].Value = project.Department;
                projects_dataGridView.Columns[0].Width = 50;
                projects_dataGridView.Rows[n].Cells[1].Value = project.CourseNumber;
                projects_dataGridView.Columns[1].Width = 30;
                projects_dataGridView.Rows[n].Cells[2].Value = project.Name;
                projects_dataGridView.Rows[n].Cells[3].Value = project.Status;
                projects_dataGridView.Columns[3].Width = 100;
                projects_dataGridView.Rows[n].Cells[4].Value = project.Priority;
                projects_dataGridView.Rows[n].Cells[5].Value = project.Term;
                projects_dataGridView.Columns[5].Width = 30;
            }
            



        }

        public void ChangeStatusColors(string str)
        {
            switch (str)
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
        #endregion

        #region Adding Objects to Project


        private void AddDeliverable_btn_Click(object sender, EventArgs e)
        {
            AddDeliverable();
        }
        private void AddLink_btn_Click(object sender, EventArgs e)
        {
            AddLink();
        }
        private void AddUpdate_btn_Click(object sender, EventArgs e)
        {
            AddUpdate();
        }
        private void AddAssociate_btn_Click(object sender, EventArgs e)
        {
            AddAssociate();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            BrowseForSavePath();
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            SaveProject();
        }
        private void Button8_Click(object sender, EventArgs e)
        {
            NewProject();
        }



        #endregion

        #region Form Field Functions
        private void ProjectStatus_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentProject.Status = projectStatus_comboBox.Text;
            ChangeStatusColors(projectStatus_comboBox.Text);
        }

        private void ProjectType_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentProject.Type1 = projectType_comboBox.Text;
        }

        private void Department_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.Department = department_textBox.Text;
        }

        private void CourseNumber_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.CourseNumber = courseNumber_textBox.Text;
        }

        private void Term_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.Term = term_textBox.Text;
        }

        private void ProjectName_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.Name = projectName_textBox.Text;
        }

        private void ProjectDescription_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.Description = projectDescription_textBox.Text;
        }

        private void LearningObjective_textBox_TextChanged(object sender, EventArgs e)
        {
            CurrentProject.LearningObjective = learningObjective_textBox.Text;
        }

        private void CollectionPath_TextChanged(object sender, EventArgs e)
        {
            SavePath = collectionPath.Text;
        }


        private void Button5_Click(object sender, EventArgs e)
        {
            DisplayAllProjects();
        }

        private void ProjectPriority_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentProject.Priority = projectPriority_comboBox.Text;
        }

        private void ProjectDueDate_ValueChanged(object sender, EventArgs e)
        {
            CurrentProject.DueDate = ProjectDueDate.Value;
            CreateTimestamp("Due Date Changed");
        }

        #endregion

        private void Button16_Click(object sender, EventArgs e) 
        {
            BrowseForSavePath();
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


        private void projects_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.projects_dataGridView.Rows[e.RowIndex];
                string projectName = row.Cells[2].Value.ToString();
                foreach (Project project in ProjectCollection)
                {
                    if (projectName == project.Name)
                    {
                        LoadProject(project);
                    }
                }
            }
        }


        private void Button19_Click(object sender, EventArgs e)
        {
            int index = links_dataGridView.CurrentRow.Index;
            
            var str = links_dataGridView.Rows[index].Cells[0].Value.ToString();

            foreach (DataGridViewRow row in links_dataGridView.SelectedRows)
            {
                if(!row.IsNewRow) links_dataGridView.Rows.Remove(row);
            }

            CurrentProject.RemoveLink(str);
        }





        

        private void Links_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.links_dataGridView.Rows[e.RowIndex];
                string URL = row.Cells[0].Value.ToString();
                foreach (Link link in CurrentProject.Links)
                {
                    if (URL == link.Url)
                    {
                        tempURL = link.Url;
                        tempLinkType = link.LinkType;
                        tempNote = link.Note;
                        TempLink = link;
                        using (var linkForm = new LinkForm())
                        {
                            if (linkForm.ShowDialog() == DialogResult.OK)
                            {
                                //TempLink = new Link(tempURL, tempLinkType, tempNote);
                                

                            }

                            

                        }
                    }
                }
                CurrentProject.SwapLink(TempLink, tempURL, tempLinkType, tempNote);
                AddLinksToGrid();
                ResetLinkDetails();
            }
        }

        public void ResetLinkDetails()
        {
            tempURL = "Enter URL";
            tempLinkType = "Select Type of Link";
            tempNote = "Enter any details";
        }
    }
}
