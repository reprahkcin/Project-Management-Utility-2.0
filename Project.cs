using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Utility_2._0
{
    class Project
    {
        private string _id;
        public string projectStatus { get; set; }
        public string projectType { get; set; }
        public string department { get; set; }
        public string courseNumber { get; set; }
        public string term { get; set; }
        public string projectName { get; set; }
        public string projectDescription { get; set; }
        public string learningObjective { get; set; }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
