using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project_Management_Utility_2._0
{
    public class Project
    {
        private string _id;
        private string _status;
        private string _priority;
        private DateTime _dueDate;
        private string _type;
        private string _department;
        private string _courseNumber;
        private string _term;
        private string _name;
        private string _description;
        private string _learningObjective;
        private List<Associate> _associates;
        private List<Deliverable> _deliverables;
        private List<Timestamp> _timestamps;
        private List<Link> _links;
        private List<Update> _updates;

        public Project()
        {
            Associates = new List<Associate>();
            Deliverables = new List<Deliverable>();
            Timestamps = new List<Timestamp>();
            Links = new List<Link>();
            Updates = new List<Update>();
        }

        public void RemoveLink(string link)
        {
            for (int i = 0; i < _links.Count; i++)
            {
                if (_links[i].Url == link)
                {
                    _links.RemoveAt(i);
                }
            }
        }

        public void SwapLink(Link oldLink, string newUrl, string newLinkType, string newNote)
        {
            Links[Links.FindIndex(ind=>ind.Equals(oldLink))] = new Link(newUrl, newLinkType, newNote);
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        public DateTime DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        public string Type1
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public string CourseNumber
        {
            get { return _courseNumber; }
            set { _courseNumber = value; }
        }

        public string Term
        {
            get { return _term; }
            set { _term = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string LearningObjective
        {
            get { return _learningObjective; }
            set { _learningObjective = value; }
        }

        public List<Associate> Associates
        {
            get { return _associates; }
            set { _associates = value; }
        }

        public List<Deliverable> Deliverables
        {
            get { return _deliverables; }
            set { _deliverables = value; }
        }

        public List<Timestamp> Timestamps
        {
            get { return _timestamps; }
            set { _timestamps = value; }
        }

        public List<Link> Links
        {
            get { return _links; }
            set { _links = value; }
        }

        public List<Update> Updates
        {
            get { return _updates; }
            set { _updates = value; }
        }
    }
}
