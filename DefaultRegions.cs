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
            donetsk.Towns.Add(new Town()
            {
                Name = "Мариуполь",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/mariupol-long-term-weather-forecast"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Ясиноватая",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/yasynuvata-long-term-weather-forecast"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Горловка",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/horlivka-long-term-weather-forecast"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Енакиево",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Харцызск",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Шахтёрск",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/shakhtarsk-long-term-weather-forecast"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Снежное",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/snizhne-long-term-weather-forecast"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Докучаевск",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Иловайск",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Дебальцево",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Торез",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Зугрес",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/zuhres-long-term-weather-forecast"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Кировское",
                Link_meteoservice = "",
                Link_atlas = ""
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
            lugansk.Towns.Add(new Town()
            {
                Name = "Алчевск",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Северодонецк",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Лисичанск",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Краснодон",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Красный луч",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Стаханов",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Свердловск",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Рубежное",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Антрацит",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Ровеньки",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Первомайск",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Перевальск",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Старобельск",
                Link_meteoservice = "",
                Link_atlas = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Лутугино",
                Link_meteoservice = "",
                Link_atlas = ""
            });

            // Добавляем регионы к списку
            regions.Add(donetsk);
            regions.Add(lugansk);
            //
            return regions;
        }
    }
}
