using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Contracts;

namespace ObserverPattern.Displays
{
    public class StatisticsDisplay : IDisplayer, IObserver
    {
        public double MinTemperature { get; private set; }
        public double MaxTemperature { get; private set; }
        public double AverageTemperature => (MaxTemperature + MinTemperature) / 2;

        public StatisticsDisplay()
        {
            MinTemperature = int.MaxValue;
            MaxTemperature = int.MinValue;
        }

        public void Display(double temperature, double humidity, double pressure)
        {
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Min Temperature: {MinTemperature:f2}");
            Console.WriteLine($"Max Temperature: {MaxTemperature:f2}");
            Console.WriteLine($"Average Temperature: {AverageTemperature:f2}");
            Console.WriteLine("And so on...");
        }

        public void Update(double temperature, double humidity, double pressure)
        {
            if (temperature < MinTemperature)
            {
                MinTemperature = temperature;
            }
            if (temperature > MaxTemperature)
            {
                MaxTemperature = temperature;
            }

            Display();
        }
    }
}
