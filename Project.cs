using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Project_Management_Utility_2._0
{
    class Project
    {
        private string _id;
        private string status;
        private string priority;
        private string type;
        private string department;
        private string courseNumber;
        private string term;
        private string name;
        private string description;
        private string learningObjective;
        private List<Associate> associates;
        private List<Deliverable> deliverables;
        private List<Timestamp> timestamps;
        private List<Link> links;
        private List<Update> updates;

        public Project(string id)
        {
            _id = id;
            associates = new List<Associate>();
            deliverables = new List<Deliverable>();
            timestamps = new List<Timestamp>();
            links = new List<Link>();
        }

        public Project(string id, string Status, string Priority, string Type, string Department, string CourseNumber, string Term,
            string Name, string Description, string LearningObjective)
            : this(id)
        {
            _id = id;
            status = Status;
            priority = Priority;
            type = Type;
            department = Department;
            courseNumber = CourseNumber;
            term = Term;
            name = Name;
            description = Description;
            learningObjective = LearningObjective;


        }





        public string ProjectStatus
        {
            get { return status; }
            set { status = value; }
        }

        public string ProjectType
        {
            get { return type; }
            set { type = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string CourseNumber
        {
            get { return courseNumber; }
            set { courseNumber = value; }
        }

        public string Term
        {
            get { return term; }
            set { term = value; }
        }

        public string ProjectName
        {
            get { return name; }
            set { name = value; }
        }

        public string ProjectDescription
        {
            get { return description; }
            set { description = value; }
        }

        public string LearningObjective
        {
            get { return learningObjective; }
            set { learningObjective = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public List<Timestamp> Timestamps
        {
            get { return timestamps; }
            set { timestamps = value; }
        }

        public List<Deliverable> Deliverables
        {
            get { return deliverables; }
            set { deliverables = value; }
        }

        public List<Associate> Associates
        {
            get { return associates; }
            set { associates = value; }
        }

        public List<Link> Links
        {
            get { return links; }
            set { links = value; }
        }

        public List<Update> Updates
        {
            get { return updates; }
            set { updates = value; }
        }
    }
}
