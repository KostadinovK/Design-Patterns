using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Contracts
{
    public interface ISubject
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
