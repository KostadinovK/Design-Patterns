using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Behaviours;
using StrategyPattern.Behaviours.Contracts;

namespace StrategyPattern.Ducks.Models
{
    public class RubberDuck : Duck
    {
        public RubberDuck(IQuackingBehaviour quackingBehaviour, IFlyingBehaviour flyingBehaviour, ISwimmingBehaviour swimmingBehaviour) : base(quackingBehaviour, flyingBehaviour, swimmingBehaviour)
        {
        }

        public override void Display()
        {
            Console.WriteLine("This is a RubberDuck");
        }
    }
}
