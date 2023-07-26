using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class EmployeeManager
    {
        private List<ICommand> commands;

        public EmployeeManager()
        {
            commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void ProcessCommands()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }

        public void UndoCommands()
        {
            for (int i = commands.Count - 1; i >= 0; i--)
            {
                commands[i].Undo();
            }
        }

    }
}
