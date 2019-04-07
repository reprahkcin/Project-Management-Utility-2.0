using System;
using System.Windows.Forms;

namespace Project_Management_Utility_2._0
{
    public partial class LinkForm : Form
    {
        public LinkForm()
        {
            InitializeComponent();
        }

        public string url
        {
            get { return LinkUrl.Text; }
        }
        public string linkType
        {
            get { return linkTypeComboBox.Text; }
        }

        public string notes
        {
            get { return linkNotes.Text; }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
