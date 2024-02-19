using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Reflection.PortableExecutable;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Dom;
using WeatherParser.Parsers;
using System.Net.Http;
using WeatherParser.Parsers.RP5;
using WeatherParser.Parsers.WeatherAtlas;
using AngleSharp;

namespace WeatherParser.Common
{
    public static class Parser
    {
        public static IHtmlDocument? GetHtml(string link)
        {
            if (link == "") return null;
            //
            string html = DownloadHtml(link);
            //
            IHtmlDocument angle = new HtmlParser().ParseDocument(html);
            //
            return angle;
        }

        private static string DownloadHtml(string webRequest)
        {
            //HttpClient client = new HttpClient();   // actually only one object should be created by Application
            //string page = await client.GetStringAsync(webRequest);
            //return page;
            //
            string data;
            WebRequest request;
            request = WebRequest.Create(webRequest);
            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    data = reader.ReadToEnd();
                }
            }
            return data;
        }

        private static async Task<IDocument> ReadHtmlAsync(string link)
        {
            var config = Configuration.Default.WithDefaultLoader();
            var address = link;
            var context = BrowsingContext.New(config);
            var document = await context.OpenAsync(address);
            return document;
            var cellSelector = ".forecastTable";
            var cells = document.QuerySelectorAll(cellSelector);
            var titles = cells.Select(m => m.TextContent);
        }
    }
}
