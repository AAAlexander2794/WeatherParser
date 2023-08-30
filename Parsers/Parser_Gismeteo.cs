using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser.Parsers
{
    public static class Parser_Gismeteo
    {
        public static List<Weather> Parse(IHtmlDocument angle)
        {
            List<Weather> weatherList = new List<Weather>();
            if (angle == null) return weatherList;
            //
            List<string> strings = new List<string>();
            // 
            foreach (IElement row in angle.QuerySelectorAll(".widget-items > div"))
            {
                
                
                //
                strings.Add(row.TextContent);
            }
            //
            return weatherList;
        }

        private static Weather Parse(List<string> strings)
        {
            //
            var weather = new Weather();
            //// Делим
            //var temps = strings[3].Split("°C");
            //// Первый день только минимальная температура ("min."), это надо обработать
            //if (temps.Length > 1)
            //{
            //    weather.TemperatureMin = temps[0].Replace("min.", "");
            //    weather.TemperatureMax = temps[1].Replace("max.", "");
            //}
            ////
            //var date = DateTime.Parse(strings[1].Remove(0, 3));
            //weather.Date = DateOnly.FromDateTime(date);
            //weather.DateDay = date.Day.ToString();
            //weather.DateMonth = date.Month.ToString();
            ////
            //var string7 = strings[7].Split(" ");
            //weather.Wind = string7[1].Replace(@"km/h", "");
            ////
            //weather.Humidity = string7[4].Replace("%UV", "");
            //
            return weather;
        }
    }
}
