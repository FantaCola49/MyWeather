using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWether.Class.Weather_params
{
    class WeatherInfo
    {
        public int id { get; set; }
        public string description { get; set; }
        public string Icon { get; set; } // Icon ID
        public string main { get; set; } // Main description of the weather
    }
}
