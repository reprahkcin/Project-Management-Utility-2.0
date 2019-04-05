using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management_Utility_2._0
{
    class Link
    {
        private string url;
        private string type;
        private bool isShared;

        public Link(string Url, string Type, bool IsShared)
        {
            this.url = Url;
            this.type = Type;
            this.isShared = IsShared;
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public string Type1
        {
            get { return type; }
            set { type = value; }
        }

        public bool IsShared
        {
            get { return isShared; }
            set { isShared = value; }
        }
    }
}
