using System;
using System.Collections.Generic;

namespace Project_Management_Utility_2._0
{
    public class Deliverable
    {
        private string _name;
        private string _description;
        private string _priority;
        private string _mediaType;

        private string _status;
        private string _quantity;
        private string _estimatedTimePer;
        private string _accessibility;
        private string _teamResponsible;

        private List<Timestamp> _timestamps;
        private List<Link> _deliverableLinks;

        public Deliverable()
        {
            Timestamps = new List<Timestamp>();
            DeliverableLinks = new List<Link>();
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

        public string Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        public string MediaType
        {
            get { return _mediaType; }
            set { _mediaType = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string EstimatedTimePer
        {
            get { return _estimatedTimePer; }
            set { _estimatedTimePer = value; }
        }

        public string Accessibility
        {
            get { return _accessibility; }
            set { _accessibility = value; }
        }

        public string TeamResponsible
        {
            get { return _teamResponsible; }
            set { _teamResponsible = value; }
        }

        public List<Timestamp> Timestamps
        {
            get { return _timestamps; }
            set { _timestamps = value; }
        }

        public List<Link> DeliverableLinks
        {
            get { return _deliverableLinks; }
            set { _deliverableLinks = value; }
        }
    }
}
