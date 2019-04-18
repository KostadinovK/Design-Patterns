using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Entities.Contracts;

namespace FactoryPattern.Factories.Contracts
{
    public interface IMachineFactory
    {
        IMachine CreateMachine(string type, string name, double attackPoints, double defensePoints);
    }
}
