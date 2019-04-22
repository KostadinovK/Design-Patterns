using System;
using AdapterPattern.Adaptee;
using AdapterPattern.Adapter;
using AdapterPattern.Target;

namespace AdapterPattern
{
    public class Program
    {
        public static void Main()
        {
            var duck = new Duck();
            var turkey = new Turkey();

            duck.Fly();
            duck.Quack();

            turkey.Gobble();
            turkey.Fly();

            var turkeyDuck = new TurkeyToDuckAdapter(turkey);

            turkeyDuck.Quack();
            turkeyDuck.Fly();
        }
    }
}
