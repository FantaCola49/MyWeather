using System.Windows;
using System.Windows.Controls;
using MyWether.Class;

namespace MyWeatherWPF.Resources.Pages
{
    /// <summary>
    /// Логика взаимодействия для StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
            ContentDispose();
        }
        GetData getData = new GetData();
        

        /// <summary>
        /// Update info when click button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateData(object sender, RoutedEventArgs e)
        {
            if (CityID.Text.Length > 0)
                getData.Get_n_Convert(CityID.Text);
            else
                getData.Get_n_Convert();

                Set_JData();
        }

        /// <summary>
        /// Fill the gaps on StartPage
        /// </summary>
        public void Set_JData()
        {
            try
            {
                City_Name.Content = getData.WeatherData[GetData.EWeather.Name];
                MainTemp.Content = $" {getData.W_Main[GetData.EWeather.Temperature]}";
                FeelsLikeLab.Content = $"Ощущается как {getData.W_Main[GetData.EWeather.Feels_like]}";
                Descript.Content = getData.WeatherList[GetData.EWeather.Description];
                MaxTemp.Content = $"Max {getData.W_Main[GetData.EWeather.Temp_max]}";
                MinTemp.Content = $"Min {getData.W_Main[GetData.EWeather.Temp_min]}";
            }
            catch
            {
                MessageBox.Show("Set_JData ERROR");
            }
        }

        /// <summary>
        /// Search city using its name
        /// </summary>
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            getData.Get_n_Convert(SearchCity.Text);
            Set_JData();
        }

        private void SearchCity_GotFocus(object sender, RoutedEventArgs e)
        {
            SearchCity.Text = null;
        }
        private void ContentDispose()
        {
            City_Name.Content = null;
            MainTemp.Content = null;
            FeelsLikeLab.Content = null;
            Descript.Content = null;
            MaxTemp.Content = null;
            MinTemp.Content = null;
        }
    }
}
