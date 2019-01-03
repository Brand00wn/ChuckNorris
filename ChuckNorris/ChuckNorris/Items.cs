using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorris
{
    class Items
    {
        public string category { get { return this.category; } set { if (String.IsNullOrEmpty(value)) { this.category = "other"; } } }

        public string icon_url { get; set; }

        public string id { get; set; }

        public string url { get; set; }

        public string value { get; set; }
    }
}
