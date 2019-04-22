using System;
using System.Collections.Generic;
using System.Text;
using AdapterPattern.Target.Contracts;

namespace AdapterPattern.Target
{
    public class Duck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack quack...");
        }

        public void Fly()
        {
            Console.WriteLine("I am a flying duck...");
        }
    }
}
