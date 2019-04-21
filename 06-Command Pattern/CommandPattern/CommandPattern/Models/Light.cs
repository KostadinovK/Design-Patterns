using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Models.Contracts;

namespace CommandPattern.Models
{
    public class Light : ILight
    {
        public void TurnOn()
        {
            Console.WriteLine("Lights turned on...");
        }

        public void TurnOff()
        {
            Console.WriteLine("Lights turned off...");
        }
    }
}
