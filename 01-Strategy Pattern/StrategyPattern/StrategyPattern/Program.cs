using System;
using System.Collections.Generic;
using StrategyPattern.Behaviours;
using StrategyPattern.Behaviours.Contracts;
using StrategyPattern.Ducks.Contracts;
using StrategyPattern.Ducks.Models;

namespace StrategyPattern
{
    public class Program
    {
        public static void Main()
        {
            
            var flyingBehaviour = new FlyingBehaviour();
            var noFlyingBehaviour = new NoFlyingBehaviour();

            var quackingBehaviour = new QuackingBehaviour();
            var noQuackingBehaviour = new NoQuackingBehaviour();

            var swimmingBehaviour = new SwimmingBehaviour();
            var noSwimmingBehaviour = new NoSwimmingBehaviour();

            var ducks = new List<IDuck>();
            var mallardDuck = new MallardDuck(quackingBehaviour, flyingBehaviour, swimmingBehaviour);
            var rubberDuck = new RubberDuck(quackingBehaviour, noFlyingBehaviour, swimmingBehaviour);
            var paperDuck = new PaperDuck(noQuackingBehaviour, noFlyingBehaviour, noSwimmingBehaviour);

            ducks.Add(mallardDuck);
            ducks.Add(rubberDuck);
            ducks.Add(paperDuck);

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.SwimmingBehaviour.Swim();
                duck.FlyingBehaviour.Fly();
                duck.QuackingBehaviour.Quack();
            }
        }
    }
}
