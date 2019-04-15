using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Utility_2._0
{
    class ProjectCollection
    {
        private List<Project> _projects;

        public List<Project> Projects
        {
            get { return _projects; }
            set { _projects = value; }
        }
    }
}
