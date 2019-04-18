using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Beverages;
using DecoratorPattern.Beverages.Contracts;
using DecoratorPattern.Decorators.Contracts;

namespace DecoratorPattern.Decorators
{
    public abstract class CondimentDecorator : IBeverage, IDecorator
    {
        
        public IBeverage Beverage { get; }
        public double Price { get; }
        public string Description { get; }


        protected CondimentDecorator(IBeverage beverage, double price, string description)
        {
            Beverage = beverage;
            Price = price;
            Description = description;
        }

       
        public double Cost()
        {
            return Price + Beverage.Cost();
        }

        public string GetDescription()
        {
            return Beverage.GetDescription() + ", " + Description;
        }
    }
}
