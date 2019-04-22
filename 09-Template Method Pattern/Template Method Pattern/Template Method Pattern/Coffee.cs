using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_Pattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Brewing coffee...");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding cream and milk...");
        }
    }
}
