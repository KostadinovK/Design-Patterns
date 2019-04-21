using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Models.Contracts;

namespace CommandPattern.Commands
{
    public class LightTurnOffCommand : ICommand
    {
        private ILight light;

        public LightTurnOffCommand(ILight light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }

        public void Undo()
        {
            light.TurnOn();
        }
    }
}
