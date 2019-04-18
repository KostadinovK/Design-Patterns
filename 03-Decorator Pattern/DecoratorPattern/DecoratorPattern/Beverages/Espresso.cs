using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class Espresso : Beverage
    {
        private const string Description = "This is Espresso";
        private const double Price = 2;

        public Espresso() : base(Description, Price)
        {
        }
    }
}
