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
    public partial class MainForm : Form
    {
        private static string id = generateID();
        
        public MainForm()
        {
            InitializeComponent();
        }

        public static string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
