using System;
using System.Collections.Generic;
using System.Text;
using Facade_Pattern.Contracts;

namespace Facade_Pattern.Models
{
    public class Television : ITelevision
    {
        public void TurnOn()
        {
            Console.WriteLine("TV is turning On...");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV is turning Off...");

        }

        public void ChangeDisplayRatio(string displayRatio)
        {
            Console.WriteLine("Display Ratio Changed. Ratio: " + displayRatio);
        }
    }
}
