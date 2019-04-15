namespace Project_Management_Utility_2._0
{
    public class Update
    {
        private string _note;
        private Timestamp _time;
        private string _nextSteps;

        public Update()
        {
            Time = new Timestamp("Update");
        }

        public Update(Timestamp t, string type)
        {

        }


        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        public Timestamp Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public string NextSteps
        {
            get { return _nextSteps; }
            set { _nextSteps = value; }
        }
    }
}
