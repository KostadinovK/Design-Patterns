using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Beverages;
using DecoratorPattern.Beverages.Contracts;

namespace DecoratorPattern.Decorators
{
    public class WhipCondimentDecorator : CondimentDecorator
    {
        private const double Price = 0.5;
        private const string Description = "Whip";
        public WhipCondimentDecorator(IBeverage beverage) : base(beverage, Price, Description)
        {
        }

    }
}
