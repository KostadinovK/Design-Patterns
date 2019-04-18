using System;
using System.Linq;
using System.Reflection;
using FactoryPattern.Entities.Contracts;
using FactoryPattern.Factories.Contracts;

namespace FactoryPattern.Factories
{
    public class PilotFactory : IPilotFactory
    {
        public IPilot CreatePilot(string type, string name)
        {
            var pilotType = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == type);

            if (pilotType == null)
            {
                throw new ArgumentException("Invalid pilot type");
            }

            var pilot = (IPilot)Activator.CreateInstance(pilotType, name);

            return pilot;
        }
    }
}
