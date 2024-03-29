﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser.Parsers.WeatherAtlas
{
    public class Weather
    {
        /// <summary>
        /// Дата прогноза (день)
        /// </summary>
        public string DateDay { get; set; } = "";

        /// <summary>
        /// Дата прогноза (месяц)
        /// </summary>
        public string DateMonth { get; set; } = "";

        /// <summary>
        /// Дата
        /// </summary>
        public DateOnly Date { get; set; } = new DateOnly();

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

        public override string ToString()
        {
            return $"Дата: {DateDay}.{DateMonth}\n" +
                $"Температура: {TemperatureMin}|{TemperatureMax}\n" +
                $"Влажность: {Humidity}\n" +
                $"Ветер: {Wind}";
        }
    }
}
