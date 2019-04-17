using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Behaviours;
using StrategyPattern.Behaviours.Contracts;

namespace StrategyPattern.Ducks.Contracts
{
    public interface IDuck
    {
        IQuackingBehaviour QuackingBehaviour { get; set; }
        IFlyingBehaviour FlyingBehaviour { get; set; }
        ISwimmingBehaviour SwimmingBehaviour { get; set; }
        void Display();
    }
}
