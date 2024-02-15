using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser.Parsers.RP5
{
    public class WeatherView
    {
        /// <summary>
        /// 1. 
        /// </summary>
        public string День_недели { get; set; } = "";
        /// <summary>
        /// 2. Местное время
        /// </summary>
        public string Местное_время { get; set; } = "";
        /// <summary>
        /// 3. Облачность
        /// </summary>
        public string Облачность { get; set; } = "";
        /// <summary>
        /// 4. Осадки
        /// </summary>
        public string Осадки { get; set; } = "";
        /// <summary>
        /// 5. Туман
        /// </summary>
        public string Туман { get; set; } = "";
        /// <summary>
        /// 6. Температура
        /// </summary>
        public string Температура { get; set; } = "";
        /// <summary>
        /// 7.
        /// </summary>
        public string Ощущается_как { get; set; } = "";
        /// <summary>
        /// 8.
        /// </summary>
        public string Давление { get; set; } = "";
        /// <summary>
        /// 9.
        /// </summary>
        public string Ветер_Скорость { get; set; } = "";
        /// <summary>
        /// 10.
        /// </summary>
        public string Ветер_Порывы { get; set; } = "";
        /// <summary>
        /// 11.
        /// </summary>
        public string Ветер_Направление { get; set; } = "";
    }
}
