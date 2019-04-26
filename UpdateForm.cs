using System.Windows.Forms;

namespace Project_Management_Utility_2._0
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        public string Note => note_textBox.Text;

        public string NextSteps => nextSteps_textBox.Text;
    }
}