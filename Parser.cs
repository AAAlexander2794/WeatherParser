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
                    return ParseWeather_meteoservice(GetHtml(town.Link_meteoservice));
                case "atlas":
                    return ParseWeather_atlas(GetHtml(town.Link_atlas));
                default: 
                    return ParseWeather_meteoservice(GetHtml(town.Link_meteoservice));
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
                    //weather.Data += div.TextContent + "\n";
                }
                //
                weatherList.Add(weather);
            }            
            //
            return weatherList;
        }

        /// <summary>
        /// Парсинг с сайта (вкладка long_term)
        /// https://www.weather-atlas.com/
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public static List<Weather> ParseWeather_atlas(IHtmlDocument angle)
        {
            
            //
            List<Weather> weatherList = new List<Weather>();
            //
            if (angle == null) return weatherList;
            // Каждый элемент - строка одной даты
            foreach (IElement row in angle.QuerySelectorAll("[itemtype=\"https://schema.org/Table\"] > .row"))
            {
                //
                List<string> strings = new List<string>();
                // Ищем вложенно тексты в дивах
                foreach (var div1 in row.QuerySelectorAll("div > div > div"))
                {
                    strings.Add(div1.TextContent);
                }
                //
                weatherList.Add(ParseWeather_atlas(strings));
            }
            //
            return weatherList;
        }

        private static Weather ParseWeather_atlas(List<string> strings)
        {
            //
            var weather = new Weather();
            // Делим
            var temps = strings[3].Split("°C");
            // Первый день только минимальная температура ("min."), это надо обработать
            if (temps.Length > 1)
            {
                weather.TemperatureMin = temps[0].Replace("min.", "");
                weather.TemperatureMax = temps[1].Replace("max.", "");
            }
            //
            var date = DateTime.Parse(strings[1].Remove(0, 3));
            weather.Date = DateOnly.FromDateTime(date);
            weather.DateDay = date.Day.ToString();
            weather.DateMonth = date.Month.ToString();
            //
            var string7 = strings[7].Split(" ");
            weather.Wind = string7[1].Replace(@"km/h", "");
            //
            weather.Humidity = string7[4].Replace("%UV", "");
            //
            return weather;
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

        
    }
}
