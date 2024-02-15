using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser.Parsers.RP5
{
    public class Town
    {
        public string Name { get; set; } = "";

        public List<Day> Days {  get; set; } = new List<Day>();
    }
}
