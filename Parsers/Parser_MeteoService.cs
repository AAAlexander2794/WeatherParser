using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherParser.Parsers.WeatherAtlas;

namespace WeatherParser.Parsers
{
    public static class Parser_MeteoService
    {
        /// <summary>
        /// Парсинг с сайта 
        /// https://www.meteoservice.ru
        /// (14 дней)
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public static List<Weather> Parse(IHtmlDocument angle)
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
    }
}
