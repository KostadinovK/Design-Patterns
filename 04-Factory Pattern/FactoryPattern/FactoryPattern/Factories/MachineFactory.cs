﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using FactoryPattern.Entities.Contracts;
using FactoryPattern.Factories.Contracts;

namespace FactoryPattern.Factories
{
    public class MachineFactory : IMachineFactory
    {
        public IMachine CreateMachine(string type, string name, double attackPoints, double defensePoints)
        {
            var machineType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == type);

            if (machineType == null)
            {
                throw new ArgumentException("Invalid machine type");
            }

            var machine = (IMachine)Activator.CreateInstance(machineType, name, attackPoints, defensePoints);

            return machine;
        }
    }
}
