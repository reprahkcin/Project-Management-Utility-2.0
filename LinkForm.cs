using System;
using System.Windows.Forms;
using static Project_Management_Utility_2._0.MainForm;

namespace Project_Management_Utility_2._0 
{
    public partial class LinkForm : Form
    {
        Link linkToEdit = new Link("Enter a URL", "Select a type", "Add details");



        public LinkForm()
        {
            InitializeComponent();

        }

        public LinkForm(Link l)
        {
            InitializeComponent();
            linkToEdit = l;
        }

        public void SwapValues()
        {
            LinkUrl.Text = url;
            linkTypeComboBox.Text = linkType;
            linkNotes.Text = notes;
        }
        public string url
        {
            get { return LinkUrl.Text; }
 
        }

        public string linkType
        {
            get { return linkTypeComboBox.Text; }

            set => linkTypeComboBox.Text = value;
        }

        public string notes
        {
            get { return linkNotes.Text; }
     
        }

        private void LinkForm_Load(object sender, EventArgs e)
        {
            LinkUrl.Text = linkToEdit.url;
            linkTypeComboBox.Text = linkToEdit.linkType;
            linkNotes.Text = linkToEdit.notes;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            TransferURL = LinkUrl.Text;
            TransferType = linkTypeComboBox.Text;
            TransferNote = linkNotes.Text;
        }
    }
}
