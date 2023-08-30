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

namespace WeatherParser
{
    public class Parser
    {
        public static List<Region> Do()
        {
            var regions = DefaultRegions.CreateRegions();
            foreach (var region in regions)
            {
                //
                foreach (var town in region.Towns)
                {
                    var ws = ParseWeather(town, "atlas");
                    foreach (var w in ws)
                    {
                        town.WeatherList.Add(w);
                    }
                    // test
                    break;
                }
            }
            //
            return regions;
        }

        public static List<Weather> ParseWeather(Town town, string site)
        {
            //
            switch (site)
            {
                case "meteoservice":
                    return Parser_MeteoService.Parse(GetHtml(town.Link_meteoservice));
                case "atlas":
                    return Parser_WeatherAtlas.Parse(GetHtml(town.Link_atlas));
                case "gismeteo":
                    return Parser_Gismeteo.Parse(GetHtml(town.Link_meteoservice));
                default: 
                    return Parser_Gismeteo.Parse(GetHtml(town.Link_meteoservice));
            }  
        }

        private static IHtmlDocument GetHtml(string link)
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

        
    }
}
