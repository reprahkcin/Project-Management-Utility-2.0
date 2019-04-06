using System;

namespace Project_Management_Utility_2._0
{
    public class Timestamp
    {
        public DateTime time;
        public string stampType;


        public Timestamp(string StampType)
        {
            this.time = DateTime.Now;
            this.stampType = StampType;
        }

    }
}
