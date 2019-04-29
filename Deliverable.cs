using System.Collections.Generic;

namespace Project_Management_Utility_2._0
{
    public class Deliverable
    {
        public Deliverable()
        {
            Timestamps = new List<Timestamp>();
            DeliverableLinks = new List<Link>();
        }

        public Deliverable(string name, string description, string priority, string mediaType, string status, string quantity, string complexity, string accessibility, string teamResponsible, List<Timestamp> timestamps, List<Link> links)
        {
            Name = name;
            Description = description;
            Priority = Priority;
            MediaType = mediaType;
            Status = status;
            Quantity = quantity;
            Complexity = complexity;
            Accessibility = accessibility;
            TeamResponsible = teamResponsible;
            Timestamps = new List<Timestamp>();
            foreach (Timestamp timestamp in timestamps)
            {
                Timestamps.Add(timestamp);
            }
            DeliverableLinks = new List<Link>();
            foreach (Link link in links)
            {
                DeliverableLinks.Add(link);
            }
            
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Priority { get; set; }

        public string MediaType { get; set; }

        public string Status { get; set; }

        public string Quantity { get; set; }

        public string Complexity { get; set; }

        public string Accessibility { get; set; }

        public string TeamResponsible { get; set; }

        public List<Timestamp> Timestamps { get; set; }

        public List<Link> DeliverableLinks { get; set; }
    }
}