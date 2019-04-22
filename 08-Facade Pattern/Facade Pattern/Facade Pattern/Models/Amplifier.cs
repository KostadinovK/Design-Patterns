using System;
using System.Collections.Generic;
using System.Text;
using Facade_Pattern.Contracts;

namespace Facade_Pattern.Models
{
    public class Amplifier : IAmplifier
    {
        public void TurnOn()
        {
            Console.WriteLine("Amplifier is turning On...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Amplifier is turning Off...");
        }

        public void ChangeVolume(int volume)
        {
            Console.WriteLine("Volume changed. Volume: " + volume);
        }
    }
}
