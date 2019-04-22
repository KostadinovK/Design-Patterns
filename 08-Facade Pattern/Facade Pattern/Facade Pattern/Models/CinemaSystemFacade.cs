using System;
using System.Collections.Generic;
using System.Text;
using Facade_Pattern.Contracts;

namespace Facade_Pattern.Models
{
    public class CinemaSystemFacade : ICinemaSystemFacade
    {
        public ITelevision Television { get; }
        public IDvd Dvd { get; }
        public IAmplifier Amplifier { get; }
        public IPopcornMachine PopcornMachine { get; }

        public CinemaSystemFacade(ITelevision television, IDvd dvd, IAmplifier amplifier, IPopcornMachine popcornMachine)
        {
            Television = television;
            Dvd = dvd;
            Amplifier = amplifier;
            PopcornMachine = popcornMachine;
        }

        public void StartMovie(string movie)
        {
            Console.WriteLine("Starting movie...");
            PopcornMachine.TurnOn();
            PopcornMachine.MakePopcorn();
            Television.TurnOn();
            Television.ChangeDisplayRatio("Width Screen");
            Dvd.TurnOn();
            Dvd.InsertCd(movie);
            Amplifier.TurnOn();
            Amplifier.ChangeVolume(10);
        }

        public void EndMovie()
        {
            Console.WriteLine("The End");
            PopcornMachine.TurnOff();
            Television.TurnOff();
            Dvd.TurnOff();
            Amplifier.TurnOff();
        }
    }
}
