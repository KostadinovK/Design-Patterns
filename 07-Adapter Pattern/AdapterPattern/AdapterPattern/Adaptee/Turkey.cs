using System;
using AdapterPattern.Adaptee.Contracts;

namespace AdapterPattern.Adaptee
{
    public class Turkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble...");
        }

        public void Fly()
        {
            Console.WriteLine("I am a short-distance flying turkey...");
        }
    }
}
