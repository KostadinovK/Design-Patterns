using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Contracts;

namespace ObserverPattern.Displays
{
    public class CurrentConditionsDisplay : IDisplayer, IObserver
    {
        public void Display()
        {

        }
        public void Display(double temperature, double humidity, double pressure)
        {
            Console.WriteLine($"Temperature: {temperature:f2}");
            Console.WriteLine($"Humidity: {humidity:f2}");
            Console.WriteLine($"Pressure: {pressure:f2}");
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            Display(temperature, humidity, pressure);
        }
    }
}
