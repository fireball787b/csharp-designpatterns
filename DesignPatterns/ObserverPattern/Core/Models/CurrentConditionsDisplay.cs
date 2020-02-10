using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.Core.Models
{
    class CurrentConditionsDisplay : IObserver<WeatherData>
    {
        private IDisposable unsubscriber;
        private string instName;

        public CurrentConditionsDisplay()
        {
            this.instName = "Current conditions display";
        }

        public void Subscribe(IObservable<WeatherData> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public string Name
        { get { return this.instName; } }

        public void OnCompleted()
        {
            Console.WriteLine("The Weather Tracker has completed transmitting data to {0}.", this.Name);
            this.Unsubscribe();
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("{0}: The weather cannot be determined.", this.Name);
        }

        public void OnNext(WeatherData weatherInfo)
        {
            Console.WriteLine(this.Name + ": temperature: " + weatherInfo.Temperature + ", humidity: " + weatherInfo.Humidity + ", preassure: " + weatherInfo.Preassure);
        }

        public void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
