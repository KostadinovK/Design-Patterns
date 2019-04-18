using System;
using DecoratorPattern.Beverages;
using DecoratorPattern.Beverages.Contracts;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Beverage N1: ");
            var beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription());
            Console.WriteLine("Cost: " + beverage.Cost());

            Console.WriteLine("Beverage N2: ");
            var secondBeverage = new MilkCondimentDecorator(new Cappuccino());
            Console.WriteLine(secondBeverage.GetDescription());
            Console.WriteLine("Cost: " + secondBeverage.Cost());
        }
    }
}
