using System;

namespace Project_Management_Utility_2._0
{
    public class Timestamp
    {
        private DateTime _time;
        private string _stampType;


        public Timestamp(string stampType)
        {
            this.Time = DateTime.Now;
            this.StampType = stampType;
        }

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public string StampType
        {
            get { return _stampType; }
            set { _stampType = value; }
        }
    }
}
