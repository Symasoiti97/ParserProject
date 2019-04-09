using System;
using System.Collections.Generic;
using System.Text;

namespace Parser.ParserRss
{
    public class RssChanel
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string Link { get; set; }
        public List<RssItem> RssItems { get; set; }
        public DateTime PubTime { get; set; }
    }
}
