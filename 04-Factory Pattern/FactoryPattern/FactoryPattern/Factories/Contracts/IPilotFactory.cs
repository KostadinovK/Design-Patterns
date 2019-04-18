using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Entities.Contracts;

namespace FactoryPattern.Factories.Contracts
{
    public interface IPilotFactory
    {
        IPilot CreatePilot(string type, string name);
    }
}
