using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Utility_2._0
{
    public class Associate
    {
        private string name;
        private string email;
        private string phone;
        private string role;
        private string department;
        private string notes;

        public Associate(string Name, string Email, string Role, string Phone, string Department, string Notes)
        {
            name = Name;
            email = Email;
            role = Role;
            notes = Notes;
            phone = Phone;
            department = Department;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
    }
}
