using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Utility_2._0
{
    class Deliverable
    {
        private string name;
        private string description;
        private string priority;
        private string mediaType;
        private List<Link> links;
        private string dueDate;
        private string status;
        private string quantity;
        private string estimatedTimePer;
        private string accessibility;
        private string teamResponsible;
        private string finalLink;
        private List<Timestamp> timestamps;

        public Deliverable(string Name, string Description, string Priority, string MediaType, string[] Links, string DueDate,
            string Status, string Quantity, string EstimatedTimePer, string Accessibility, string TeamResponsible,
            string FinalLink)
        {
            name = Name;
            description = Description;
            priority = Priority;
            mediaType = MediaType;
            this.Links = new List<Link>();
            dueDate = DueDate;
            status = Status;
            quantity = Quantity;
            estimatedTimePer = EstimatedTimePer;
            accessibility = Accessibility;
            teamResponsible = TeamResponsible;
            finalLink = FinalLink;
            timestamps = new List<Timestamp>();
           
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string MediaType
        {
            get { return mediaType; }
            set { mediaType = value; }
        }


        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public string EstimatedTimePer
        {
            get { return estimatedTimePer; }
            set { estimatedTimePer = value; }
        }

        public string Accessibility
        {
            get { return accessibility; }
            set { accessibility = value; }
        }

        public string TeamResponsible
        {
            get { return teamResponsible; }
            set { teamResponsible = value; }
        }

        public string FinalLink
        {
            get { return finalLink; }
            set { finalLink = value; }
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

        public List<Link> Links
        {
            get { return links; }
            set { links = value; }
        }
    }
}
