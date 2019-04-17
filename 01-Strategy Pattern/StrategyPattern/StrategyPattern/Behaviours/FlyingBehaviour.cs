using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Behaviours
{
    public class FlyingBehaviour : IFlyingBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying...");
        }
    }
}
