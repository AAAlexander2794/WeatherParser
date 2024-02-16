using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser.Common
{
    public class Day
    {
        public string День_недели { get; set; } = "";

        /// <summary>
        /// Список моментов дня, на которые спрогнозирована погода. РП5
        /// </summary>
        public List<Parsers.RP5.Weather> Weathers_RP5 { get; set; } = new List<Parsers.RP5.Weather>();

    }
}
