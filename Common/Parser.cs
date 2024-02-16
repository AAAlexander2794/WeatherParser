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

namespace WeatherParser.Common
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
                     ParseWeather(town, "rp5");
                    //foreach (var w in ws)
                    //{
                    //    town.WeatherList.Add(w);
                    //}
                    //// test
                    //break;
                }
            }
            //
            return regions;
        }

        public static void ParseWeather(Town town, string site)
        {
            //
            switch (site)
            {
                case "meteoservice":
                     Parser_MeteoService.Parse(GetHtml(town.Link_meteoservice));
                    break;
                case "atlas":
                     Parser_WeatherAtlas.Parse(GetHtml(town.Link_atlas));
                    break;
                case "gismeteo":
                     Parser_Gismeteo.Parse(GetHtml(town.Link_meteoservice));
                    break;
                case "rp5":
                     Parser_RP5.Parse(GetHtml(town.Link_RP5), town);
                    break;
                default:
                     Parser_Gismeteo.Parse(GetHtml(town.Link_meteoservice));
                    break;
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
