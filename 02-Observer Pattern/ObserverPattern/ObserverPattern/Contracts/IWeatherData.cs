using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Contracts
{
    public interface IWeatherData
    {
        double Temperature { get; }
        double Humidity { get; }
        double Pressure { get; }

        void ChangeMeasurements(double temperature, double humidity, double pressure);
    }
}
