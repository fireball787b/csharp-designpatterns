using DesignPatterns.ObserverPattern.Core.Models;

namespace DesignPatterns.ObserverPattern
{
    class WeatherStation
    {
        //from the book
        /*private WeatherData weatherData;
        private CurrentConditionsDisplay currentConditionsDisplay;
        private StatisticsDisplay statisticsDisplay;
        private ForecastDisplay forecastDisplay;

        public WeatherStation()
        {
            weatherData = new WeatherData();
            currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            statisticsDisplay = new StatisticsDisplay(weatherData);
            forecastDisplay = new ForecastDisplay(weatherData);
        }

        public void Test()
        {
            weatherData.SetMeasurements(80, 76, 12.4f);
            weatherData.SetMeasurements(9, 100.9f, 15);
            weatherData.SetMeasurements(23.45f, 70, 14);
        }*/

        //from microsoft documentation
        //https://docs.microsoft.com/en-us/dotnet/api/system.iobservable-1?view=netframework-4.8
        WeatherTracker weatherTracker;
        CurrentConditionsDisplay currentConditionsDisplay;
        StatisticsDisplay statisticsDisplay;
        ForecastDisplay forecastDisplay;
        public WeatherStation()
        {
            weatherTracker = new WeatherTracker();
            statisticsDisplay = new StatisticsDisplay();
            forecastDisplay = new ForecastDisplay();
            currentConditionsDisplay = new CurrentConditionsDisplay();
        }

        public void Test()
        {
            statisticsDisplay.Subscribe(weatherTracker);
            forecastDisplay.Subscribe(weatherTracker);
            currentConditionsDisplay.Subscribe(weatherTracker);

            weatherTracker.TrackWeather(new WeatherData(80, 76, 12.4f));
            statisticsDisplay.Unsubscribe();
            weatherTracker.TrackWeather(new WeatherData(9, 100.9f, 15));
            weatherTracker.TrackWeather(new WeatherData(23.45f, 70, 14));
            weatherTracker.EndTransmission();
        }
        
    }
}
