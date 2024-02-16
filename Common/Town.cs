using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherParser.Parsers.WeatherAtlas;

namespace WeatherParser.Common
{
    public class Town
    {
        /// <summary>
        /// Название города
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Дни погоды
        /// </summary>
        public List<Day> Days { get; set; } = new List<Day>();

        public string NameAlt { get; set; } = "";

        #region Ссылки для парсинга

        /// <summary>
        /// Ссылка на страничку для парсинга
        /// </summary>
        public string Link_meteoservice { get; set; } = "";

        public string Link_atlas { get; set; } = "";

        public string Link_weatheronline { get; set; } = "";

        public string Link_gismeteo { get; set; } = "";

        public string Link_RP5 { get; set; } = "";

        #endregion Ссылки для парсинга

        public List<Weather> WeatherList { get; set; } = new List<Weather>();
    }
}
