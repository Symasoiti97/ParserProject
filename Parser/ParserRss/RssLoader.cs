using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;

namespace Parser.ParserRss
{
    class RssLoader
    {
        public static SyndicationFeed ParserRss(string url)
        {
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed rssChanel = SyndicationFeed.Load(reader);
            reader.Close();

            return rssChanel;
        }
    }
}
