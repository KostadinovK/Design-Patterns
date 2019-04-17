using System;
using StrategyPattern.Behaviours;
using StrategyPattern.Behaviours.Contracts;

namespace StrategyPattern.Ducks.Models
{
    public class PaperDuck : Duck
    {
        public PaperDuck(IQuackingBehaviour quackingBehaviour, IFlyingBehaviour flyingBehaviour, ISwimmingBehaviour swimmingBehaviour) : base(quackingBehaviour, flyingBehaviour, swimmingBehaviour)
        {
        }

        public override void Display()
        {
            Console.WriteLine("This is a paper duck");
        }
    }
}
