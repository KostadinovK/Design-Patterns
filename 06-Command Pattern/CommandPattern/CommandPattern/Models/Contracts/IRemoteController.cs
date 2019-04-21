using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Commands;

namespace CommandPattern.Models.Contracts
{
    public interface IRemoteController
    {
        IReadOnlyList<ICommand> OnCommands { get; }
        IReadOnlyList<ICommand> OffCommands { get; }

        void AddCommand(ICommand onCommand, ICommand offCommand);
        void PressedOnButton(int buttonIndex);
        void PressedOffButton(int buttonIndex);
        void PressedUndoButton();
    }
}
