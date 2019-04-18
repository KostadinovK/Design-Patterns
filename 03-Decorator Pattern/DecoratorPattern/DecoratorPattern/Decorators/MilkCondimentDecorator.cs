using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Beverages;
using DecoratorPattern.Beverages.Contracts;

namespace DecoratorPattern.Decorators
{
    public class MilkCondimentDecorator : CondimentDecorator
    {
        private const double Price = 0.25;
        private const string Description = "Milk";

        public MilkCondimentDecorator(IBeverage beverage) : base(beverage, Price, Description)
        {
        }
    }
}
