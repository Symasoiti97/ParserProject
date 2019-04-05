using System;
using System.Collections.Generic;
using System.Text;

namespace Parser.ParserRss
{
    class RssItem
    {
        public string Author { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public DateTime PubTime { get; set; }
    }
}
