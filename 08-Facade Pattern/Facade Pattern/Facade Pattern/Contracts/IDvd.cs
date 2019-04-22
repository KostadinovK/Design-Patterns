using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern.Contracts
{
    public interface IDvd : ITurnable
    {
        string Movie { get; }
       
        void InsertCd(string cd);
    }
}
