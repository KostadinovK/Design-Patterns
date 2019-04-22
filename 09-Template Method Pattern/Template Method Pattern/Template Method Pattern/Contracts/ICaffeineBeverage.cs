using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_Pattern
{
    public interface ICaffeineBeverage
    {
        void MakeBeverage();
        void Boil();
        void Brew();
        void PourInCup();
        void AddCondiments();
    }
}
