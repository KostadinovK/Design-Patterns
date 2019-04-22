using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Method_Pattern
{
    public abstract class CaffeineBeverage  :ICaffeineBeverage
    {
        public void MakeBeverage()
        {
            Boil();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public virtual void Boil()
        {
            Console.WriteLine($"Bouling water for {GetType().Name}...");
        }

        public abstract void Brew();

        public virtual void PourInCup()
        {
            Console.WriteLine($"Pouring {GetType().Name} in cup...");
        }

        public abstract void AddCondiments();

    }
}
