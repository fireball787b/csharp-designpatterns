using System;
using System.Collections.Generic;

namespace DesignPatterns.ObserverPattern.Core.Models
{
    class WeatherTracker : IObservable<WeatherData>
    {
        private List<IObserver<WeatherData>> observers;

        public WeatherTracker()
        {
            observers = new List<IObserver<WeatherData>>();
        }

        //The method returns an Unsubscriber object, which is an IDisposable implementation that enables observers to stop receiving notifications. 
        //The LocationTracker class also includes an EndTransmission method. When no further location data is available, the method calls each observer's 
        //OnCompleted method and then clears the internal list of observers.
        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public void TrackWeather(WeatherData weatherInfo)
        {
            foreach (var observer in observers)
            {
                observer.OnNext(weatherInfo);
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in observers.ToArray())
                if (observers.Contains(observer))
                    observer.OnCompleted();

            observers.Clear();
        }
    }
}
