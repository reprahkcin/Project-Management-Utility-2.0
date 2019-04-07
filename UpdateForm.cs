using System;
using System.Windows.Forms;

namespace Project_Management_Utility_2._0
{
    public partial class UpdateForm : Form
    {

        public UpdateForm()
        {
            InitializeComponent();
        }
        public string note
        {
            get { return note_textBox.Text; }
        }

        public string nextSteps 
        {
            get { return nextSteps_textBox.Text; }
        }


    }
}
