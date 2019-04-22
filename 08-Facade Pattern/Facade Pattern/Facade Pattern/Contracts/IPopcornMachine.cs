using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern.Contracts
{
    public interface IPopcornMachine : ITurnable
    {
        void MakePopcorn();
    }
}
