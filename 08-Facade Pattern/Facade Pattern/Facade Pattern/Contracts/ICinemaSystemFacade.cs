using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern.Contracts
{
    public interface ICinemaSystemFacade
    {
        ITelevision Television { get; }
        IDvd Dvd { get; }
        IAmplifier Amplifier { get; }
        IPopcornMachine PopcornMachine { get; }

        void StartMovie(string movie);
        void EndMovie();
    }
}
