using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Models.Contracts;

namespace CommandPattern.Models
{
    public class Stereo : IStereo
    {
        public string Cd { get; private set; }
        public int Volume { get; private set; }

        public Stereo()
        {
            Cd = null;
            Volume = 0;
        }

        public void TurnOn()
        {
            Console.WriteLine("Stereo turned on...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Stereo turned off...");

        }

        public void AddCd(string cd)
        {
            Cd = cd;
            Console.WriteLine("Added CD " + cd + ".");
        }

        public void ChangeVolume(int volume)
        {
            Volume = volume;
            Console.WriteLine("Volume: " + Volume);
        }
    }
}
