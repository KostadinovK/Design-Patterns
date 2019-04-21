using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Models.Contracts;

namespace CommandPattern.Commands
{
    public class LightTurnOnCommand : ICommand
    {
        private ILight light;

        public LightTurnOnCommand(ILight light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }

        public void Undo()
        {
            light.TurnOff();
        }
    }
}
