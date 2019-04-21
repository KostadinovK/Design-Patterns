using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Models.Contracts;

namespace CommandPattern.Commands
{
    public class StereoTurnOffCommand : ICommand
    {
        private IStereo stereo;

        public StereoTurnOffCommand(IStereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.TurnOff();
        }

        public void Undo()
        {
            stereo.TurnOn();
        }
    }
}
