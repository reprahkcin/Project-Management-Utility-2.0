using System;
using System.Windows.Forms;

namespace Project_Management_Utility_2._0
{
    public partial class DeliverableForm : Form
    {
        public DeliverableForm()
        {
            InitializeComponent();
        }

        public string name
        {
            get { return name_textBox.Text; }
        }

        public string description
        {
            get { return description_textBox.Text; }
        }

        public string priority
        {
            get { return priority_comboBox.Text; }
        }

        public string mediaType
        {
            get { return mediaType_comboBox.Text; }
        }


        public string status
        {
            get { return status_comboBox.Text; }
        }
        public string quantity
        {
            get { return quantity_textBox.Text; }
        }
        public string estimatedTimePer
        {
            get { return estimatedTimePer_textBox.Text; }
        }
        public string accessibility
        {
            get { return accessibility_comboBox.Text; }
        }
        public string teamResponsible
        {
            get { return teamResponsible_comboBox.Text; }
        }

        private void AddLink_btn_Click(object sender, EventArgs e)
        {
            using (var linkForm = new LinkForm())
            {
                if (linkForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Link link = new Link { url = linkForm.url, linkType = linkForm.linkType, notes = linkForm.notes };
                    
                }
            }
        }
    }
}
