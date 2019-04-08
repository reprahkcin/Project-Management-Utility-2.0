﻿using System;
using System.Collections.Generic;

namespace Project_Management_Utility_2._0
{
    public class Deliverable
    {
        public string name;
        public string description;
        public string priority;
        public string mediaType;
        public DateTime dueDate;
        public string status;
        public string quantity;
        public string estimatedTimePer;
        public string accessibility;
        public string teamResponsible;

        public List<Timestamp> timestamps;
        public List<Link> deliverableLinks;

        public Deliverable()
        {
            timestamps = new List<Timestamp>();
            deliverableLinks = new List<Link>();
        }

    }
}
