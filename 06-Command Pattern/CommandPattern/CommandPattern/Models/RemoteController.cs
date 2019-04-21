using System;
using System.Collections.Generic;
using System.Text;
using CommandPattern.Commands;
using CommandPattern.Models.Contracts;

namespace CommandPattern.Models
{
    public class RemoteController : IRemoteController
    {
        private readonly List<ICommand> onCommands;
        private readonly List<ICommand> offCommands;
        private ICommand undoCommand;

        public IReadOnlyList<ICommand> OnCommands => onCommands.AsReadOnly();
        public IReadOnlyList<ICommand> OffCommands => offCommands.AsReadOnly();

        public RemoteController()
        {
            onCommands = new List<ICommand>();
            offCommands = new List<ICommand>();
        }

        public void AddCommand(ICommand onCommand, ICommand offCommand)
        {
            onCommands.Add(onCommand);
            offCommands.Add(offCommand);
        }

        public void PressedOnButton(int buttonIndex)
        {
            if (buttonIndex >= 0 && buttonIndex < onCommands.Count)
            {
                onCommands[buttonIndex].Execute();
                undoCommand = onCommands[buttonIndex];
            }
        }

        public void PressedOffButton(int buttonIndex)
        {
            if (buttonIndex >= 0 && buttonIndex < offCommands.Count)
            {
                offCommands[buttonIndex].Execute();
                undoCommand = offCommands[buttonIndex];
            }
        }

        public void PressedUndoButton()
        {
            undoCommand.Undo();
        }
    }
}
