using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using xf.simp2019.rssnews.Models;

namespace xf.simp2019.rssnews.Services
{
    public class NCFService
    {
        private readonly Uri URL_RSS;
        private readonly WebClient webClient;
        public event EventHandler<GenericEventArgs<List<Article>>> GetArticles_Completed;

        public NCFService()
        {
            URL_RSS = new Uri("https://www.espn.com/espn/rss/ncf/news");
            webClient = new WebClient();
        }

        public void GetArticles()
        {
            try
            {
                webClient.DownloadStringCompleted += (sender, e) =>
                {
                    var resultString = e.Result;
                    var xdocument = XDocument.Parse(resultString);

                    var listOfNews = (from news in xdocument.Descendants("channel").Elements("item")
                                      select new Article
                                      {
                                          Title = news.Element("title").Value,
                                          Description = news.Element("description").Value,
                                          UrlImage = news.Element("image").Value,
                                          Link = news.Element("link").Value
                                      }).ToList();

                    GetArticles_Completed?.Invoke(this, new GenericEventArgs<List<Article>>(listOfNews));
                };
                webClient.DownloadStringAsync(URL_RSS);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
