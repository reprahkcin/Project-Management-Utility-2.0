namespace Project_Management_Utility_2._0
{
    public class Link
    {
        private string _url;
        private string _linkType;
        private string _note;
        

        public Link()
        {

        }

        public Link(string url, string linkType, string note)
            :this()
        {
            Url = url;
            LinkType = linkType;
            Note = note;
        }

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }

        public string LinkType
        {
            get { return _linkType; }
            set { _linkType = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }
    }
}
