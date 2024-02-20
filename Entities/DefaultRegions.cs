using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser.Common
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
                Link_gismeteo = "https://www.gismeteo.ru/weather-donetsk-5080/10-days/",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%94%D0%BE%D0%BD%D0%B5%D1%86%D0%BA%D0%B5,_%D0%94%D0%BE%D0%BD%D0%B5%D1%86%D0%BA%D0%B0%D1%8F_%D0%9D%D0%B0%D1%80%D0%BE%D0%B4%D0%BD%D0%B0%D1%8F_%D0%A0%D0%B5%D1%81%D0%BF%D1%83%D0%B1%D0%BB%D0%B8%D0%BA%D0%B0"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Мариуполь",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/mariupol-long-term-weather-forecast",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=34712&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "https://www.gismeteo.ru/weather-mariupol-5104/10-days/",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9C%D0%B0%D1%80%D0%B8%D1%83%D0%BF%D0%BE%D0%BB%D0%B5,_%D0%94%D0%BE%D0%BD%D0%B5%D1%86%D0%BA%D0%B0%D1%8F_%D0%9D%D0%B0%D1%80%D0%BE%D0%B4%D0%BD%D0%B0%D1%8F_%D0%A0%D0%B5%D1%81%D0%BF%D1%83%D0%B1%D0%BB%D0%B8%D0%BA%D0%B0"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Ясиноватая",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/yasynuvata-long-term-weather-forecast",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=y8216&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "https://www.gismeteo.ru/weather-yasinovataya-11339/10-days/",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%AF%D1%81%D0%B8%D0%BD%D0%BE%D0%B2%D0%B0%D1%82%D0%BE%D0%B9"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Горловка",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/horlivka-long-term-weather-forecast",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=y8205&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "https://www.gismeteo.ru/weather-gorlovka-5083/10-days/",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%93%D0%BE%D1%80%D0%BB%D0%BE%D0%B2%D0%BA%D0%B5,_%D0%94%D0%BE%D0%BD%D0%B5%D1%86%D0%BA%D0%B0%D1%8F_%D0%9D%D0%B0%D1%80%D0%BE%D0%B4%D0%BD%D0%B0%D1%8F_%D0%A0%D0%B5%D1%81%D0%BF%D1%83%D0%B1%D0%BB%D0%B8%D0%BA%D0%B0"
            }); ;
            donetsk.Towns.Add(new Town()
            {
                Name = "Енакиево",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=y8217&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "https://www.gismeteo.ru/weather-yenakiyevo-11346/10-days/",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%95%D0%BD%D0%B0%D0%BA%D0%B8%D0%B5%D0%B2%D0%BE"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Харцызск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A5%D0%B0%D1%80%D1%86%D1%8B%D0%B7%D1%81%D0%BA%D0%B5"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Шахтёрск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/shakhtarsk-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A8%D0%B0%D1%85%D1%82%D0%B5%D1%80%D1%81%D0%BA%D0%B5,_%D0%94%D0%BE%D0%BD%D0%B5%D1%86%D0%BA%D0%B0%D1%8F_%D0%9D%D0%B0%D1%80%D0%BE%D0%B4%D0%BD%D0%B0%D1%8F_%D0%A0%D0%B5%D1%81%D0%BF%D1%83%D0%B1%D0%BB%D0%B8%D0%BA%D0%B0"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Снежное",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/snizhne-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D0%BD%D0%B5%D0%B6%D0%BD%D0%BE%D0%BC,_%D0%94%D0%BE%D0%BD%D0%B5%D1%86%D0%BA%D0%B0%D1%8F_%D0%9D%D0%B0%D1%80%D0%BE%D0%B4%D0%BD%D0%B0%D1%8F_%D0%A0%D0%B5%D1%81%D0%BF%D1%83%D0%B1%D0%BB%D0%B8%D0%BA%D0%B0"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Докучаевск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=b4336&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%94%D0%BE%D0%BA%D1%83%D1%87%D0%B0%D0%B5%D0%B2%D1%81%D0%BA%D0%B5"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Иловайск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=b4327&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%98%D0%BB%D0%BE%D0%B2%D0%B0%D0%B9%D1%81%D0%BA%D0%B5"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Дебальцево",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=34524&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%94%D0%B5%D0%B1%D0%B0%D0%BB%D1%8C%D1%86%D0%B5%D0%B2%D0%BE,_%D0%A0%D0%BE%D1%81%D1%81%D0%B8%D1%8F"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Торез",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=b4436&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A2%D0%BE%D1%80%D0%B5%D0%B7%D0%B5"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Зугрэс",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/zuhres-long-term-weather-forecast",
                Link_weatheronline = "https://www.weatheronline.co.uk/weather/maps/city?LANG=en&CEL=C&SI=mph&CONT=euro&LAND=UR&REGION=0006&WMO=b4263&LEVEL=52&R=0&NOREGION=1",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%97%D1%83%D0%B3%D1%80%D1%8D%D1%81%D0%B5"
            });
            donetsk.Towns.Add(new Town()
            {
                Name = "Кировское",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/kirovsk-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = "https://www.gismeteo.ru/weather-kirovskoye-12386/10-days/",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D0%B8%D1%80%D0%BE%D0%B2%D1%81%D0%BA%D0%BE%D0%BC,_%D0%94%D0%BE%D0%BD%D0%B5%D1%86%D0%BA%D0%B0%D1%8F_%D0%9D%D0%B0%D1%80%D0%BE%D0%B4%D0%BD%D0%B0%D1%8F_%D0%A0%D0%B5%D1%81%D0%BF%D1%83%D0%B1%D0%BB%D0%B8%D0%BA%D0%B0"
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
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9B%D1%83%D0%B3%D0%B0%D0%BD%D1%81%D0%BA%D0%B5,_%D0%9B%D1%83%D0%B3%D0%B0%D0%BD%D1%81%D0%BA%D0%B0%D1%8F_%D0%9D%D0%B0%D1%80%D0%BE%D0%B4%D0%BD%D0%B0%D1%8F_%D0%A0%D0%B5%D1%81%D0%BF%D1%83%D0%B1%D0%BB%D0%B8%D0%BA%D0%B0"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Алчевск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/alchevsk-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D0%BB%D1%87%D0%B5%D0%B2%D1%81%D0%BA%D0%B5"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Северодонецк",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/severodonetsk-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D0%B5%D0%B2%D0%B5%D1%80%D0%BE%D0%B4%D0%BE%D0%BD%D0%B5%D1%86%D0%BA%D0%B5"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Лисичанск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9B%D0%B8%D1%81%D0%B8%D1%87%D0%B0%D0%BD%D1%81%D0%BA%D0%B5"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Краснодон",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/krasnodon-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D1%80%D0%B0%D1%81%D0%BD%D0%BE%D0%B4%D0%BE%D0%BD%D0%B5_(%D0%B3.)"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Красный луч",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/krasnyi-luch-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9A%D1%80%D0%B0%D1%81%D0%BD%D0%BE%D0%BC_%D0%9B%D1%83%D1%87%D0%B5,_%D0%9A%D1%80%D0%B0%D1%81%D0%BD%D1%8B%D0%B9_%D0%9B%D1%83%D1%87"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Стаханов",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D1%82%D0%B0%D1%85%D0%B0%D0%BD%D0%BE%D0%B2%D0%B5"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Свердловск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D0%B2%D0%B5%D1%80%D0%B4%D0%BB%D0%BE%D0%B2%D1%81%D0%BA%D0%B5"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Рубежное",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/rubizhne-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A0%D1%83%D0%B1%D0%B5%D0%B6%D0%BD%D0%BE%D0%BC,_%D0%9B%D1%83%D0%B3%D0%B0%D0%BD%D1%81%D0%BA%D0%B0%D1%8F_%D0%9D%D0%B0%D1%80%D0%BE%D0%B4%D0%BD%D0%B0%D1%8F_%D0%A0%D0%B5%D1%81%D0%BF%D1%83%D0%B1%D0%BB%D0%B8%D0%BA%D0%B0"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Антрацит",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/antratsyt-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%90%D0%BD%D1%82%D1%80%D0%B0%D1%86%D0%B8%D1%82%D0%B5"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Ровеньки",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A0%D0%BE%D0%B2%D0%B5%D0%BD%D1%8C%D0%BA%D0%B0%D1%85,_%D0%9B%D1%83%D0%B3%D0%B0%D0%BD%D1%81%D0%BA%D0%B0%D1%8F_%D0%9D%D0%B0%D1%80%D0%BE%D0%B4%D0%BD%D0%B0%D1%8F_%D0%A0%D0%B5%D1%81%D0%BF%D1%83%D0%B1%D0%BB%D0%B8%D0%BA%D0%B0"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Первомайск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9F%D0%B5%D1%80%D0%B2%D0%BE%D0%BC%D0%B0%D0%B9%D1%81%D0%BA%D0%B5,_%D0%9F%D0%B5%D1%80%D0%B2%D0%BE%D0%BC%D0%B0%D0%B9%D1%81%D0%BA"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Перевальск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9F%D0%B5%D1%80%D0%B5%D0%B2%D0%B0%D0%BB%D1%8C%D1%81%D0%BA%D0%B5"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Старобельск",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%A1%D1%82%D0%B0%D1%80%D0%BE%D0%B1%D0%B5%D0%BB%D1%8C%D1%81%D0%BA%D0%B5"
            });
            lugansk.Towns.Add(new Town()
            {
                Name = "Лутугино",
                NameAlt = "",
                Link_meteoservice = "",
                Link_atlas = "https://www.weather-atlas.com/en/ukraine/lutuhyne-long-term-weather-forecast",
                Link_weatheronline = "",
                Link_gismeteo = "",
                Link_RP5 = "https://rp5.ru/%D0%9F%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0_%D0%B2_%D0%9B%D1%83%D1%82%D1%83%D0%B3%D0%B8%D0%BD%D0%BE"
            });

            // Добавляем регионы к списку
            regions.Add(donetsk);
            regions.Add(lugansk);
            //
            return regions;
        }
    }
}
