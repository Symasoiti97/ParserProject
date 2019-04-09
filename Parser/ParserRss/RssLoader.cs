using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Text;
using System.Xml;

namespace Parser.ParserRss
{
    public class RssLoader
    {
        public static RssChanel ParserRss(string url)
        {
            RssChanel rssChanel = new RssChanel();
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed rss = SyndicationFeed.Load(reader);
            
            reader.Close();

            rssChanel.Title = rss.Title.Text;
            rssChanel.Description = rss.Description.Text;
            rssChanel.Category = rss.Categories.ToString();
            rssChanel.Language = rss.Language;
            rssChanel.Link = rss.Links.ToString();
            rssChanel.RssItems = new List<RssItem>();

            foreach (var item in rss.Items)
            {
                rssChanel.RssItems.Add(new RssItem()
                {
                    Author = item.Title.Text,
                    Category = item.Categories.ToString(),
                    Description = item.Summary.Text,
                    Link = item.Links.ToString(),
                    PubTime = item.PublishDate.UtcDateTime,
                    Title = item.Title.Text
                });
            }

            return rssChanel;
        }
    }
}
