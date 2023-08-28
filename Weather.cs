using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser
{
    public class Weather
    {
        

        /// <summary>
        /// Дата прогноза
        /// </summary>
        public string Data { get; set; } = "";

        /// <summary>
        /// Температура, градусы Цельсия
        /// </summary>
        public string Temperature { get; set; } = "";

        public string TemperatureMax { get; set; } = "";

        public string TemperatureMin { get; set; } = "";

        /// <summary>
        /// Влажность, %
        /// </summary>
        public string Humidity { get; set; } = "";

        /// <summary>
        /// Скорость ветра, км/ч
        /// </summary>
        public string Wind { get; set; } = "";
    }
}
