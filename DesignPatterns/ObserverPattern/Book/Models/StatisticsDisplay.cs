using DesignPatterns.ObserverPattern.Book.Interface;
using System;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Book.Models
{
    class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public StatisticsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Statistics display: temperature: " + this.temperature + ", humidity: " + this.humidity);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
    }
}
