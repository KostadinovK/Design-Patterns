using System;
using FactoryPattern.Factories;

namespace FactoryPattern
{
    public class Program
    {
        public static void Main()
        {
            var machineFactory = new MachineFactory();
            var pilotFactory = new PilotFactory();

            var machine = machineFactory.CreateMachine("Tank", "T0-22", 100, 150);
            var pilot = pilotFactory.CreatePilot("Pilot", "Kosta");

            Console.WriteLine(machine.ToString());
            Console.WriteLine(pilot.Name);
        }
    }
}
