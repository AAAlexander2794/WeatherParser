using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherParser
{
    public class Region
    {
        public string Name { get; set; } = "";

        public List<Town> Towns { get; set; } = new List<Town>();
    }
}
