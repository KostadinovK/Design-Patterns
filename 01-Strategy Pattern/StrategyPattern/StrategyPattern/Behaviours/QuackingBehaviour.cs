using System;
using System.Collections.Generic;
using System.Text;
using StrategyPattern.Behaviours.Contracts;

namespace StrategyPattern.Behaviours
{
    public class QuackingBehaviour : IQuackingBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Duck is quaking: Quak...Quak...");
        }
    }
}
