using DesignPatterns.ObserverPattern.Book.Interface;
using System;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Book.Models
{
    class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float preassure;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Forecast display: temperature: " + this.temperature + ", humidity: " + this.humidity + " ,preassure: " + this.preassure);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.preassure = pressure;
            Display();
        }
    }
}
