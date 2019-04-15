using System.Windows.Forms;

namespace Project_Management_Utility_2._0
{
    public partial class AssociateForm : Form
    {
        public AssociateForm()
        {
            InitializeComponent();
        }
        public string AssociateName
        {
            get { return associateName_textBox.Text; }
        }
        public string Email
        {
            get { return associateEmail_textBox.Text; }
        }
        public string Phone
        {
            get { return associatePhone_textBox.Text; }
        }
        public string Role
        {
            get { return associateRole_comboBox.Text; }
        }
        public string Department
        {
            get { return associateDepartment_textBox.Text; }
        }
        public string Notes
        {
            get { return associateNotes_textBox.Text; }
        }
    }
}
