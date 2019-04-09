using System;
using System.Windows.Forms;

namespace Project_Management_Utility_2._0
{
    public partial class LinkForm : Form
    {
        Link linkToEdit;
        public LinkForm()
        {
            InitializeComponent();

        }

        public LinkForm(Link l)
        {
            linkToEdit = new Link();
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
    }
}
