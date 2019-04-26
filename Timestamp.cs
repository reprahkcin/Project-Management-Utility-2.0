using System;

namespace Project_Management_Utility_2._0
{
    public class Timestamp
    {
        public Timestamp(string stampType)
        {
            Time = DateTime.Now;
            StampType = stampType;
        }

        public DateTime Time { get; set; }

        public string StampType { get; set; }
    }
}