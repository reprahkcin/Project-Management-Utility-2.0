using System;
using System.Windows.Forms;
using static Project_Management_Utility_2._0.MainForm;

namespace Project_Management_Utility_2._0
{
    public partial class LinkForm : Form
    {
        private readonly Link _linkToEdit = new Link(tempURL, tempLinkType, tempNote);


        public LinkForm()
        {
            InitializeComponent();
        }

        public LinkForm(Link l)
        {
            InitializeComponent();
            _linkToEdit = l;
        }

        public string Url => LinkUrl.Text;

        public string LinkType
        {
            get => linkTypeComboBox.Text;

            set => linkTypeComboBox.Text = value;
        }

        public string Notes => linkNotes.Text;

        public void SwapValues()
        {
            LinkUrl.Text = Url;
            linkTypeComboBox.Text = LinkType;
            linkNotes.Text = Notes;
        }

        private void LinkForm_Load(object sender, EventArgs e)
        {
            LinkUrl.Text = _linkToEdit.Url;
            linkTypeComboBox.Text = _linkToEdit.LinkType;
            linkNotes.Text = _linkToEdit.Note;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            tempURL = LinkUrl.Text;
            tempLinkType = linkTypeComboBox.Text;
            tempNote = linkNotes.Text;
        }
    }
}