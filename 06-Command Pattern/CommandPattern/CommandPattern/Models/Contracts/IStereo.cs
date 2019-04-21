using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Models.Contracts
{
    public interface IStereo
    {
        string Cd { get; }
        int Volume { get; }

        void TurnOn();
        void TurnOff();
        void AddCd(string cd);
        void ChangeVolume(int volume);
    }
}
