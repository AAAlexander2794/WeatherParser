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
                NameAlt = "Donetsk",
                Link_meteoservice = "https://www.meteoservice.ru/weather/14days/donetsk-135-ua",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/donetsk-long-term-weather-forecast",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=34519&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "https://www.gismeteo.ru/weather-donetsk-5080/10-days/"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Мариуполь",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/mariupol-long-term-weather-forecast",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=34712&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "https://www.gismeteo.ru/weather-mariupol-5104/10-days/"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Ясиноватая",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/yasynuvata-long-term-weather-forecast",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=y8216&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "https://www.gismeteo.ru/weather-yasinovataya-11339/10-days/"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Горловка",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/horlivka-long-term-weather-forecast",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=y8205&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "https://www.gismeteo.ru/weather-gorlovka-5083/10-days/"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Енакиево",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=y8217&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "https://www.gismeteo.ru/weather-yenakiyevo-11346/10-days/"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Харцызск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Шахтёрск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/shakhtarsk-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Снежное",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/snizhne-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Докучаевск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=b4336&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Иловайск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=b4327&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Дебальцево",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=34524&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Торез",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=b4436&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Зугрес",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/zuhres-long-term-weather-forecast",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=b4263&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = ""
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Кировское",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = "https://www.gismeteo.ru/weather-kirovskoye-12386/10-days/"
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
                NameAlt = "",
                Link_meteoservice = "https://www.meteoservice.ru/weather/14days/lugansk",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/luhansk-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Алчевск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Северодонецк",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Лисичанск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Краснодон",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Красный луч",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Стаханов",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Свердловск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Рубежное",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Антрацит",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Ровеньки",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Первомайск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Перевальск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Старобельск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Лутугино",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = ""
            });

            // Добавляем регионы к списку
            regions.Add(donetsk);
            regions.Add(lugansk);
            //
            return regions;
        }
    }
}
