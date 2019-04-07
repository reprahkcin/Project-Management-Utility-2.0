using System.Windows.Forms;

namespace Project_Management_Utility_2._0
{
    public partial class AssociateForm : Form
    {
        public AssociateForm()
        {
            InitializeComponent();
        }
        public string name
        {
            get { return associateName_textBox.Text; }
        }
        public string email
        {
            get { return associateEmail_textBox.Text; }
        }
        public string phone
        {
            get { return associatePhone_textBox.Text; }
        }
        public string role
        {
            get { return associateRole_comboBox.Text; }
        }
        public string department
        {
            get { return associateDepartment_textBox.Text; }
        }
        public string notes
        {
            get { return associateNotes_textBox.Text; }
        }
    }
}
