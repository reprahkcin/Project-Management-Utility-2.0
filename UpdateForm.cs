using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_Utility_2._0
{
    public partial class UpdateForm : Form
    {
        public Update currentUpdate;
        private string _note;
        private string _nextSteps;


        public UpdateForm()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            _note = textBox1.Text;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            _nextSteps = textBox2.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            currentUpdate = new Update(_note, _nextSteps);
        }
    }
}
