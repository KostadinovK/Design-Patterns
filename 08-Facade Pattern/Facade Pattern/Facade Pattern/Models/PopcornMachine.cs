using System;
using System.Collections.Generic;
using System.Text;
using Facade_Pattern.Contracts;

namespace Facade_Pattern.Models
{
    public class PopcornMachine : IPopcornMachine
    {
        public void TurnOn()
        {
            Console.WriteLine("Popcorn Machine is turning On...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Popcorn Machine is turning Off...");
        }

        public void MakePopcorn()
        {
            Console.WriteLine("Making popcorn...");
        }
    }
}
