using System;
using Parser.ParserRss;

namespace ParserProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = @"https://news.rambler.ru/rss/moscow_city/latest/?limit=100";

            RssChanel rssChanel = new RssChanel();
            RssLoader rssLoader = new RssLoader();
            rssChanel = RssLoader.ParserRss(url);
            Show(rssChanel);
            
            Console.ReadKey(true);
        }

        static void Show(RssChanel rssChanel)
        {
            Console.WriteLine($"\n{rssChanel.Title}" +
                              $"\n{rssChanel.Language}" +
                              $"\n{rssChanel.Link}" +
                              $"\n{rssChanel.Category}" +
                              $"\n{rssChanel.Description}" +
                              $"\n{rssChanel.PubTime}");
            foreach (var item in rssChanel.RssItems)
            {
                Console.WriteLine($"\n\n\n{item.Title}" +
                                  $"\n{item.Author}" +
                                  $"\n{item.Category}" +
                                  $"\n{item.Description}" +
                                  $"\n{item.Link}" +
                                  $"\n{item.PubTime}");
            }
        }
    }
}
