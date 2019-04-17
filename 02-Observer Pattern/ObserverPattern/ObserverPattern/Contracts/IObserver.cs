using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Contracts
{
    public interface IObserver
    {
        void Update(double temperature, double humidity, double pressure);
    }
}
