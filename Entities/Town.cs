using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherParser.Parsers.WeatherAtlas;
using AngleSharp.Html.Dom;
using AngleSharp.Dom;

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

        /// <summary>
        /// Скачанная html-таблица с данными всех дней (РП5)
        /// </summary>
        public IHtmlDocument? HtmlDocument { get; set; }

        public string Link_RP5 { get; set; } = "";

        #region Ссылки для парсинга старые

        /// <summary>
        /// Ссылка на страничку для парсинга
        /// </summary>
        public string Link_meteoservice { get; set; } = "";

        public string Link_atlas { get; set; } = "";

        public string Link_weatheronline { get; set; } = "";

        public string Link_gismeteo { get; set; } = "";

        public List<Weather> WeatherList { get; set; } = new List<Weather>();

        #endregion Ссылки для парсинга
    }
}
