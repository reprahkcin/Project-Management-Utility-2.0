namespace Project_Management_Utility_2._0
{
    public class Update
    {
        public Update()
        {
            Time = new Timestamp("Update");
        }

        public Update(Timestamp t, string type)
        {
        }


        public string Note { get; set; }

        public Timestamp Time { get; set; }

        public string NextSteps { get; set; }
    }
}