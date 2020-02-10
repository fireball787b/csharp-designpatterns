using DesignPatterns.ObserverPattern.Book.Interface;
using System;
using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern.Book.Models
{
    class WeatherData : Subject
    {
        private List<Observer> observers;
        private float humidity;
        private float temperature;
        private float preassure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        public void RegisterObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (Observer obsever in observers)
                obsever.Update(temperature, humidity, preassure);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float humidity, float preassure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.preassure = preassure;
            MeasurementsChanged();
        }
    }
}
