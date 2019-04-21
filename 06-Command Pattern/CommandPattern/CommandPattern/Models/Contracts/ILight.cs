using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models.Contracts
{
    public interface ILight
    {
        void TurnOn();
        void TurnOff();
    }
}
