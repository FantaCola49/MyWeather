using MyWether.Class.Weather_params;
using System.Collections.Generic;

namespace MyWether.Class
{
    /// <summary>
    /// Set definitions for JSON response
    /// </summary>
    class WeatherResponse
    {
        public List<WeatherInfo> Weather { get; set; } // Тут помеха!
        public TemperatureInfo Main { get; set; }
        public WindInfo Wind { get; set; }
        public CloudInfo Clouds { get; set; }
        public RainInfo Rain { get; set; }
        public string Name { get; set; }
        //public string Description { get; set; } // does it work? ru leng  -> "&lang=ru"
        public string TimeZone { get; set; } // Shift is seconds from UTC

    }
}
