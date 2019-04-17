using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Behaviours.Contracts;

namespace StrategyPattern.Behaviours
{
    public class NoSwimmingBehaviour : ISwimmingBehaviour
    {
        public void Swim()
        {
        }
    }
}
