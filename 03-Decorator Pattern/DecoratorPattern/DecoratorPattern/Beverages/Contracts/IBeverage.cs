using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Beverages.Contracts
{
    public interface IBeverage
    {
        double Price { get; }
        string Description { get; }

        double Cost();
        string GetDescription();
    }
}
