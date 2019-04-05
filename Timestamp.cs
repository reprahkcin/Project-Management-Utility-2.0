using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Utility_2._0
{
    class Timestamp
    {
        private string time;
        private string type;

        public Timestamp(string Time, string Type)
        {
            this.time = Time;
            this.type = Type;
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Type1
        {
            get { return type; }
            set { type = value; }
        }
    }
}
