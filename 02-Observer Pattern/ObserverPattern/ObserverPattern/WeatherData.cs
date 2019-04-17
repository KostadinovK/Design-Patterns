using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using ObserverPattern.Contracts;

namespace ObserverPattern.Models
{
    public class WeatherData : IWeatherData, ISubject
    {
        private List<IObserver> observers;
        public double Temperature { get; private set; }
        public double Humidity { get; private set; }
        public double Pressure { get; private set; }

        public WeatherData()
        {
            Temperature = 0;
            Humidity = 0;
            Pressure = 0;
            observers = new List<IObserver>();
        }

        public void ChangeMeasurements(double temperature, double humidity, double pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            NotifyObservers();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }
    }
}
