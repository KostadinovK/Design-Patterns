using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Behaviours.Contracts;

namespace StrategyPattern.Behaviours
{
    public class SwimmingBehaviour : ISwimmingBehaviour
    {
        public void Swim()
        {
            Console.WriteLine("Duck is swimming...");
        }
    }
}
