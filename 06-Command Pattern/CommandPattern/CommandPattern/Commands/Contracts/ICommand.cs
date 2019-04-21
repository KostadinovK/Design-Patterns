using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
