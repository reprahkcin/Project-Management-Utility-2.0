using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Utility_2._0
{
    class Update
    {
        private string note;
        private Timestamp time;
        private string followUp;

        public Update(string Note, Timestamp Time)
        {
            this.note = Note;
            this.time = Time;
            this.followUp = FollowUp;
        }

        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public Timestamp Time
        {
            get { return time; }
            set { time = value; }
        }

        public string FollowUp
        {
            get { return followUp; }
            set { followUp = value; }
        }
    }
}
