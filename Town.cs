using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser
{
    public class Town
    {
        /// <summary>
        /// Название города
        /// </summary>
        public string Name { get; set; } = "";

        public string NameAlt { get; set; } = "";

        /// <summary>
        /// Ссылка на страничку для парсинга
        /// </summary>
        public string Link_meteoservice { get; set; } = "";

        public string Link_atlas { get; set; } = "";

        public string Link_weatheronline { get; set; } = "";

        public string Link_gismeteo { get; set; } = "";

        public List<Weather> WeatherList { get; set; } = new List<Weather>();
    }
}
