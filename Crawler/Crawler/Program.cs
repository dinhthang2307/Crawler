using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            startCrawlerAsync();
            Console.ReadLine();
        }

        private static async Task startCrawlerAsync()
        {
            var url = "https://tedu.com.vn/";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();

            htmlDocument.LoadHtml(html);
            Console.Write(html);
        }
    }
}
