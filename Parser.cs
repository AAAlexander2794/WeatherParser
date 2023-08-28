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

namespace WeatherParser
{
    public class Parser
    {
        public static List<Town> Do()
        {
            var towns = CreateTowns();
            //
            foreach (var town in towns)
            {
                var ws = ParseWeather(town, "atlas");
                foreach (var w in ws)
                {
                    town.WeatherList.Add(w);
                }
            }
            //
            return towns;
        }

        public static List<Weather> ParseWeather(Town town, string site)
        {
            //
            switch (site)
            {
                case "meteoservice":
                    return ParseWeather_meteoservice(GetHtml(town.Link_meteoservice));
                case "atlas":
                    return ParseWeather_atlas(GetHtml(town.Link_atlas));
                default: 
                    return ParseWeather_meteoservice(GetHtml(town.Link_meteoservice));
            }  
        }

        private static IHtmlDocument GetHtml(string link)
        {
            //
            string html = DownloadHtml(link);
            //
            IHtmlDocument angle = new HtmlParser().ParseDocument(html);
            //
            return angle;
        }

        /// <summary>
        /// Парсинг с сайта 
        /// https://www.meteoservice.ru
        /// (14 дней)
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public static List<Weather> ParseWeather_meteoservice(IHtmlDocument angle)
        {
            //
            List<Weather> weatherList = new List<Weather>();
            // Каждый элемент - строка одной даты
            foreach (IElement element in angle.QuerySelectorAll(".callout > .row"))
            {
                //
                var weather = new Weather();
                //
                List<string> strings = new List<string>();
                foreach (var div in element.QuerySelectorAll("div"))
                {
                    strings.Add(div.TextContent);
                    weather.Data += div.TextContent + "\n";
                }
                //
                weatherList.Add(weather);
            }            
            //
            return weatherList;
        }

        public static List<Weather> ParseWeather_atlas(IHtmlDocument angle)
        {
            //
            List<Weather> weatherList = new List<Weather>();
            // Каждый элемент - строка одной даты
            foreach (IElement row in angle.QuerySelectorAll("[itemtype=\"https://schema.org/Table\"] > .row"))
            {
                //
                var weather = new Weather();
                //
                List<string> strings = new List<string>();
                // Ищем вложенно тексты в дивах
                foreach (var div1 in row.QuerySelectorAll("div > div > div"))
                {
                    strings.Add(div1.TextContent);
                    //foreach (var div2 in row.QuerySelectorAll("div"))
                    //{
                    //    foreach (var div3 in row.QuerySelectorAll("div"))
                    //    {

                    //    }
                    //}
                }
                // За
                foreach (var str in strings)
                {
                    weather.Data += str + "\n";
                }
                //
                weatherList.Add(weather);
            }
            //
            return weatherList;
        }

        private static string DownloadHtml(string webRequest)
        {
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

        public static List<Town> CreateTowns()
        {
            var townList = new List<Town>();
            //
            townList.Add(new Town()
            {
                Name = "Донецк",
                Link_meteoservice = "https://www.meteoservice.ru/weather/14days/donetsk-135-ua",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/donetsk-long-term-weather-forecast"
            });
            //
            return townList;
        }
    }
}
