using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Core.Models
{
    class WeatherData
    {
        private float temperature;
        private float humidity;
        private float preassure;

        public WeatherData(float temp, float humidity, float preassure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.preassure = preassure;
        }

        public float Temperature { get { return this.temperature; } }
        public float Humidity { get { return this.humidity; } }
        public float Preassure { get { return this.preassure; } }
    }
}
