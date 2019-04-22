using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_Pattern
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steep tea in water...");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding honey and lemon...");
        }
    }
}
