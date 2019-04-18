using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class Cappuccino : Beverage
    {
        private const string Description = "This is Cappuccino";
        private const double Price = 3;

        public Cappuccino() : base(Description, Price)
        {
        }
    }
}
