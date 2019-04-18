using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Beverages;
using DecoratorPattern.Beverages.Contracts;

namespace DecoratorPattern.Decorators.Contracts
{
    public interface IDecorator
    {
        
        IBeverage Beverage { get; }

    }
}
