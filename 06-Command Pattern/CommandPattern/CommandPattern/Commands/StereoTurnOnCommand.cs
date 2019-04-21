using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Models.Contracts;

namespace CommandPattern.Commands
{
    public class StereoTurnOnCommand : ICommand
    {
        private IStereo stereo;

        public StereoTurnOnCommand(IStereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.TurnOn();
            stereo.AddCd("Kings of Metal");
            stereo.ChangeVolume(20);
        }

        public void Undo()
        {
            stereo.TurnOff();
        }
    }
}
