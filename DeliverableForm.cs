using System;
using System.Windows.Forms;
using static Project_Management_Utility_2._0.MainForm;

namespace Project_Management_Utility_2._0
{
    public partial class DeliverableForm : Form
    {
        private readonly Deliverable _deliverableToEdit = new Deliverable(tempDeliverableName,tempDeliverableDescription,tempDeliverablePriority,tempDeliverableMediaType,tempDeliverableStatus,tempDeliverableQuantity,tempDeliverableComplexity,tempDeliverableAccessibility,tempDeliverableTeamResponsible,tempDeliverableTimestamps,tempDeliverableLinks);

        public DeliverableForm()
        {
            InitializeComponent();
        }

        public DeliverableForm(Deliverable d)
        {
            InitializeComponent();
            _deliverableToEdit = d;
        }

        public string DeliverableName
        {
            get { return name_textBox.Text; }
        }

        public string Description
        {
            get { return description_textBox.Text; }
        }

        public string Priority
        {
            get { return priority_comboBox.Text; }
        }

        public string MediaType
        {
            get { return mediaType_comboBox.Text; }
        }


        public string Status
        {
            get { return status_comboBox.Text; }
        }
        public string Quantity
        {
            get { return quantity_textBox.Text; }
        }
        public string EstimatedTimePer
        {
            get { return estimatedTimePer_textBox.Text; }
        }
        public string Accessibility
        {
            get { return accessibility_comboBox.Text; }
        }
        public string TeamResponsible
        {
            get { return teamResponsible_comboBox.Text; }
        }

        private void AddLink_btn_Click(object sender, EventArgs e)
        {
            using (var linkForm = new LinkForm())
            {
                if (linkForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Link link = new Link { Url = linkForm.Url, LinkType = linkForm.LinkType, Note = linkForm.Notes };
                    
                }
            }
        }
    }
}
