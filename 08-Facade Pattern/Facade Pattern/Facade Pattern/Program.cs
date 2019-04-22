using System;
using Facade_Pattern.Models;

namespace Facade_Pattern
{
    public class Program
    {
        public static void Main()
        {
            var tv = new Television();
            var dvd = new Dvd();
            var popcornMachine = new PopcornMachine();
            var amplifier = new Amplifier();

            var cinemaSystem = new CinemaSystemFacade(tv, dvd, amplifier, popcornMachine);

            cinemaSystem.StartMovie("The Shawshenk Redemption");
            cinemaSystem.EndMovie();
        }
    }
}
