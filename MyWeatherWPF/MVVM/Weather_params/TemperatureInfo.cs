using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWether.Class
{
    class TemperatureInfo
    {
        public float Temperature { get; set; }
        public float Feels_like { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
        public float Temp_min { get; set; }
        public float Temp_max { get; set; }
        public float Sea_level { get; set; } // Atmospheric pressure on the sea level, hPa
        public float Grnd_level { get; set; } // Atmospheric pressure on the ground level, hPa
    }
}
