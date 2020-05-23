using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Web;
using System.Net;
using MyWether.Class.Weather_params;
using System.Windows;

namespace MyWether.Class
{
    class GetData
    { 
        public Dictionary<EWeather, string> WeatherData = new Dictionary<EWeather, string>();
        public Dictionary<EWeather, string> W_Main = new Dictionary<EWeather, string>();
        public Dictionary<EWeather, string> WeatherList = new Dictionary<EWeather, string>();


        /// <summary>
        /// Get data from OpenWeather Map and convert it from JSON
        /// </summary>
        /// <param name="CityName"></param>
        public void Get_n_Convert(string CityName = "Moscow")
        {
           string url = $"http://api.openweathermap.org/data/2.5/weather?q={CityName}&&units=metric&lang=ru&appid=c04fad8e5e16ffab2117b8474d754dc5";
            try
            {
                string response;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    response = streamReader.ReadToEnd();
                }
                WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                DictFill(weatherResponse);
            }
            catch { MessageBox.Show("This city does not exist. Try again"); }
        }
        /// <summary>
        /// Fill all dictionaries
        /// </summary>
        /// <param name="weatherResponse"></param>
        private void DictFill(WeatherResponse weatherResponse)
        {
            WeatherData_REfill(weatherResponse);
            W_Main_REfill(weatherResponse);
            WeatherList_REfill(weatherResponse);
        }

        /// <summary>
        /// Fill WeatherData with TimeZone, City Name, Wind speed
        /// </summary>
        /// <param name="weatherResponse"></param>
        private void WeatherData_REfill(WeatherResponse weatherResponse)
        {
            WeatherData.Clear();
            WeatherData.Add(EWeather.Name, weatherResponse.Name.ToString());
            WeatherData.Add(EWeather.TimeZone, weatherResponse.TimeZone.ToString());
            WeatherData.Add(EWeather.Wind, weatherResponse.Wind.Speed.ToString()); // wind speed
        }
       
        /// <summary>
        /// Fill W_Main dictionary with main info such as Temp, T_max/min, FeelsLike, SeaLevel
        /// </summary>
        /// <param name="weatherResponse"></param>
        private void W_Main_REfill(WeatherResponse weatherResponse)
        {
            W_Main.Clear();
            W_Main.Add(EWeather.Temperature, weatherResponse.Main.Temperature.ToString());
            W_Main.Add(EWeather.Temp_max, weatherResponse.Main.Temp_max.ToString());
            W_Main.Add(EWeather.Temp_min, weatherResponse.Main.Temp_min.ToString());
            W_Main.Add(EWeather.Pressure, weatherResponse.Main.Pressure.ToString());
            W_Main.Add(EWeather.Feels_like, weatherResponse.Main.Feels_like.ToString()); 
            W_Main.Add(EWeather.Humiditi, weatherResponse.Main.Humidity.ToString());
            W_Main.Add(EWeather.Sea_level, weatherResponse.Main.Sea_level.ToString());
            W_Main.Add(EWeather.Grnd_Level, weatherResponse.Main.Grnd_level.ToString());
            W_Main.Add(EWeather.Clouds, weatherResponse.Clouds.All.ToString()); // clouds in %
        }
        
        /// <summary>
        /// Fill WeatherDictionary with Description, mainly weather, Icon id
        /// </summary>
        /// <param name="weatherResponse"></param>
        private void WeatherList_REfill(WeatherResponse weatherResponse)
        {
            WeatherList.Clear();
            foreach (WeatherInfo w in weatherResponse.Weather)
            {
                WeatherList.Add(EWeather.Description, w.description);
                WeatherList.Add(EWeather.Main, w.main);
                WeatherList.Add(EWeather.Icon, w.Icon);
            }
        }
        public enum EWeather
        {
            Name,
            TimeZone,
            Wind,

            Description,
            Main,
            Icon,

            Temperature,
            Temp_max,
            Temp_min,
            Pressure,
            Feels_like,
            Humiditi,
            Sea_level,
            Grnd_Level,
            Clouds
        }
    }
}