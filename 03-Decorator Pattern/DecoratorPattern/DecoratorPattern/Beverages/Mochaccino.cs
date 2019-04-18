using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages
{
    public class Mochaccino : Beverage
    {
        private const string Description = "This is Mochaccino";
        private const double Price = 2.5;


        public Mochaccino() : base(Description, Price)
        {
        }
    }
}
