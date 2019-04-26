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