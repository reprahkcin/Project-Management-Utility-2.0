namespace Project_Management_Utility_2._0
{
    public class Link
    {
        public Link()
        {
        }

        public Link(string url, string linkType, string note)
            : this()
        {
            Url = url;
            LinkType = linkType;
            Note = note;
        }

        public string Url { get; set; }

        public string LinkType { get; set; }

        public string Note { get; set; }
    }
}