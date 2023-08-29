using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser
{
    public static class DefaultRegions
    {
        public static List<Region> CreateRegions()
        {
            //
            List<Region> regions = new List<Region>();

            // ------------ Донецкий регион ------------
            var donetsk = new Region()
            {
                Name = "Донецкий"
            };
            //
            donetsk.Towns.Add(new Town()
            {
                Name = "Донецк",
                Link_meteoservice = "https://www.meteoservice.ru/weather/14days/donetsk-135-ua",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/donetsk-long-term-weather-forecast"
            });

            // ------------ Луганский регион ------------
            var lugansk = new Region()
            {
                Name = "Луганский"
            };
            //
            lugansk.Towns.Add(new Town()
            {
                Name = "Луганск",
                Link_meteoservice = "https://www.meteoservice.ru/weather/14days/lugansk",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/luhansk-long-term-weather-forecast"
            });
            // Добавляем регионы к списку
            regions.Add(donetsk);
            regions.Add(lugansk);
            //
            return regions;
        }
    }
}
