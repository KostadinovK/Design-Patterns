using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Contracts
{
    public interface IDisplayer
    {
        void Display(double temperature, double humidity, double pressure);
        void Display();
    }
}
