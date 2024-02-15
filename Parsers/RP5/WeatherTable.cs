using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser.Parsers.RP5
{
    public class WeatherTable
    {
        /// <summary>
        /// 1. 
        /// </summary>
        public List<string> День_недели { get; set; } = new List<string>();
        /// <summary>
        /// 2. Местное время
        /// </summary>
        public List<string> Местное_время { get; set; } = new List<string>();
        /// <summary>
        /// 3. Облачность
        /// </summary>
        public List<string> Облачность { get; set; } = new List<string>();
        /// <summary>
        /// 4. Осадки
        /// </summary>
        public List<string> Осадки { get; set; } = new List<string>();
        /// <summary>
        /// 5. Туман
        /// </summary>
        public List<string> Туман { get; set; } = new List<string>();
        /// <summary>
        /// 6. Температура
        /// </summary>
        public List<string> Температура { get; set; } = new List<string>();
        /// <summary>
        /// 7.
        /// </summary>
        public List<string> Ощущается_как { get; set; } = new List<string>();
        /// <summary>
        /// 8.
        /// </summary>
        public List<string> Давление { get; set; } = new List<string>();
        /// <summary>
        /// 9.
        /// </summary>
        public List<string> Ветер_Скорость { get; set; } = new List<string>();
        /// <summary>
        /// 10.
        /// </summary>
        public List<string> Ветер_Порывы { get; set; } = new List<string>();
        /// <summary>
        /// 11.
        /// </summary>
        public List<string> Ветер_Направление { get; set; } = new List<string>();
    }
}
