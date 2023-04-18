using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;


namespace Prototype2
{
    public partial class Homepage : Form
    {
        string APIKey = "6dc5d0ac4ef41fb2f0f0f084e2d58c8b";
        public void getweather()
        {/*
            WebClient client = new WebClient() ;
            string URL = String.Format("https://api.openweathermap.org/data/2.5/weather?q=london&appid={1}&units=metric", (textBox1.Text, APIKey));
            var json = client.DownloadString(URL);
            WeatherInfo.Root = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

            pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + info.weather[0].icon(".png");
            label4 = "Temperature: " + Math.Round(WeatherInfo.main.temp).ToString;
            label6 = "Weather Type: " + info.weather[0].description;
            */
        }


        public Homepage()
        {
            InitializeComponent();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            
            Support frm1 = new Support();
            frm1.Show();
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            
            Forecast frm2 = new Forecast();
            frm2.Show();
        }

        private void btnHealthTracking_Click(object sender, EventArgs e)
        {
            
            HealthTracking frm7 = new HealthTracking();
            frm7.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            
            btnLogout frm3 = new btnLogout();
            frm3.Show();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            
            Options frm6 = new Options();
            frm6.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void btnEHA_Click(object sender, EventArgs e)
        {
            
            EnvironmentalHealthAdvice frm6 = new EnvironmentalHealthAdvice();
            frm6.Show();
        }

        private void btnECAS_Click(object sender, EventArgs e)
        {
            
            EnvironmentalConditionsSupport frm6 = new EnvironmentalConditionsSupport();
            frm6.Show();
        }

        private void btnRisk_Click(object sender, EventArgs e)
        {
            
            RiskAssesments frm6 = new RiskAssesments();
            frm6.Show();
        }

        private void btnAirQuality_Click(object sender, EventArgs e)
        {
            
            AirQuality frm6 = new AirQuality();
            frm6.Show();
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            Temperature frm7 = new Temperature();
            frm7.Show();
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            getweather();
        }
    }
}
