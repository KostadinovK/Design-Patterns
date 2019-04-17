using System;
using ObserverPattern.Contracts;
using ObserverPattern.Displays;
using ObserverPattern.Models;

namespace ObserverPattern
{
    public class Program
    {
        public static void Main()
        {
            var weatherData = new WeatherData();
            var currentConditionsDisplay = new CurrentConditionsDisplay();
            var statisticsDisplay = new StatisticsDisplay();

            weatherData.AddObserver(currentConditionsDisplay);
            weatherData.AddObserver(statisticsDisplay);

            weatherData.ChangeMeasurements(20, 1, 1);
            weatherData.ChangeMeasurements(34, 0, 2);
            weatherData.ChangeMeasurements(8, 10, 10);
        }
    }
}
