using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Target.Contracts
{
    public interface IDuck
    {
        void Quack();
        void Fly();
    }
}
