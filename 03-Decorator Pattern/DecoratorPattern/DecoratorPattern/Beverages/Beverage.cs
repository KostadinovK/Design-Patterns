using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Beverages.Contracts;

namespace DecoratorPattern.Beverages
{
    public abstract class Beverage : IBeverage
    {
        public double Price { get; }
        public string Description { get; }

        protected Beverage(string description, double price)
        {
            Description = description;
            Price = price;
        }
        public double Cost()
        {
            return Price;
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}
