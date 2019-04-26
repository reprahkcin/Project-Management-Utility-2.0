using System;
using System.Collections.Generic;

namespace Project_Management_Utility_2._0
{
    public class Project
    {
        public Project()
        {
            Associates = new List<Associate>();
            Deliverables = new List<Deliverable>();
            Timestamps = new List<Timestamp>();
            Links = new List<Link>();
            Updates = new List<Update>();
        }

        public string Status { get; set; }

        public string Id { get; set; }

        public string Priority { get; set; }

        public DateTime DueDate { get; set; }

        public string Type1 { get; set; }

        public string Department { get; set; }

        public string CourseNumber { get; set; }

        public string Term { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string LearningObjective { get; set; }

        public List<Associate> Associates { get; set; }

        public List<Deliverable> Deliverables { get; set; }

        public List<Timestamp> Timestamps { get; set; }

        public List<Link> Links { get; set; }

        public List<Update> Updates { get; set; }

        public void RemoveLink(string link)
        {
            for (var i = 0; i < Links.Count; i++)
                if (Links[i].Url == link)
                    Links.RemoveAt(i);
        }

        public void SwapLink(Link oldLink, string newUrl, string newLinkType, string newNote)
        {
            Links[Links.FindIndex(ind => ind.Equals(oldLink))] = new Link(newUrl, newLinkType, newNote);
        }
        // You need to figure out the constructor function in deliverable class
        //public void SwapDeliverable(Deliverable oldDeliverable, string)
    }
}