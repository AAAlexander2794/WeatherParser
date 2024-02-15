using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser.Parsers.RP5
{
    /// <summary>
    /// Момент, на который спрогнозирована погода.
    /// </summary>
    public class Weather
    {
        /// <summary>
        /// Текстовое представление погоды
        /// </summary>
        public WeatherView View { get; set; } = new WeatherView();

        public Weather(WeatherView weatherView) 
        {
            View = weatherView;
        }
    }
}
