using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Html5;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using HtmlAgilityPack;
using System.Security.Policy;

namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageFromHtml();

            while (true) ;
        }

        private static void ImageFromHtml()
        {
            Uri googleUrl = new Uri("https://www.google.com");

            var client = new HtmlWeb();
            var html = client.LoadFromWebAsync(googleUrl.ToString()).Result;
            var htmlLogoUri = new Uri($"{googleUrl}/{html.GetElementbyId("hplogo").Attributes["src"].Value}");

            using(var webclient = new WebClient())
            {
                webclient.DownloadFile(htmlLogoUri, @"C:\Users\A\Desktop\New folder\img.jpg");
            }
            Console.WriteLine(htmlLogoUri);
        }
    }
}
