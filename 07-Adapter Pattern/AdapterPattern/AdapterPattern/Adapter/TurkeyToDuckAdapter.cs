using System;
using System.Collections.Generic;
using System.Text;
using AdapterPattern.Adaptee.Contracts;
using AdapterPattern.Target.Contracts;

namespace AdapterPattern.Adapter
{
    public class TurkeyToDuckAdapter : IDuck
    {
        private ITurkey turkey;

        public TurkeyToDuckAdapter(ITurkey turkey)
        {
            this.turkey = turkey;
        }

        public void Quack()
        {
            turkey.Gobble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                turkey.Fly();
            }
        }
    }
}
