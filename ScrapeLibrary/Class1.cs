﻿using System.Net;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            //WebClient client = new WebClient();
            //return client.DownloadString(url);
            ////String reply = client.DownloadString(url);
            ////Console.WriteLine(reply);
            return GetWebPage(url);

        }
        public string ScrapeWebpage(string url, string filepath)
        {
            //WebClient client = new WebClient();
            //string reply = client.DownloadString(url);
            string reply = GetWebPage(url);
            File.WriteAllText(filepath, reply);
            return reply;
        }
        private string GetWebPage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }
    }
}
