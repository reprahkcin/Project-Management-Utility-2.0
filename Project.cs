using System.Collections.Generic;

namespace Project_Management_Utility_2._0
{
    public class Project
    {
        public string id;
        public string status;
        public string priority;
        public string type;
        public string department;
        public string courseNumber;
        public string term;
        public string name;
        public string description;
        public string learningObjective;
        public List<Associate> associates;
        public List<Deliverable> deliverables;
        public List<Timestamp> timestamps;
        public List<Link> links;
        public List<Update> updates;

        public Project()
        {
            associates = new List<Associate>();
            deliverables = new List<Deliverable>();
            timestamps = new List<Timestamp>();
            links = new List<Link>();
            updates = new List<Update>();
        }

    }
}
