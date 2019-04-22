using System;
using System.Collections.Generic;
using System.Text;
using Facade_Pattern.Contracts;

namespace Facade_Pattern.Models
{
    public class Dvd : IDvd
    {
        public string Movie { get; private set; }

        public void TurnOn()
        {
            Console.WriteLine("DVD is turning On...");
        }

        public void TurnOff()
        {
            Console.WriteLine("DVD is turning Off...");
        }

        
        public void InsertCd(string cd)
        {
            Movie = cd;
            Console.WriteLine("Movie: " + cd);
        }
    }
}
