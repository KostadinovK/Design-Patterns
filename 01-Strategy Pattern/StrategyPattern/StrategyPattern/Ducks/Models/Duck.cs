using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Behaviours;
using StrategyPattern.Behaviours.Contracts;
using StrategyPattern.Ducks.Contracts;

namespace StrategyPattern.Ducks.Models
{
    public abstract class Duck : IDuck
    {
        public IQuackingBehaviour QuackingBehaviour { get; set; }
        public IFlyingBehaviour FlyingBehaviour { get; set; }
        public ISwimmingBehaviour SwimmingBehaviour { get; set; }

        protected Duck(IQuackingBehaviour quackingBehaviour, IFlyingBehaviour flyingBehaviour, ISwimmingBehaviour swimmingBehaviour)
        {
            QuackingBehaviour = quackingBehaviour;
            FlyingBehaviour = flyingBehaviour;
            SwimmingBehaviour = swimmingBehaviour;
        }

        public abstract void Display();
    }
}
