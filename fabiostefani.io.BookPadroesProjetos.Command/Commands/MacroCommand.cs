using System.Collections.Generic;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly List<ICommand> commands;

        public MacroCommand(List<ICommand> commands)
        {
            this.commands = commands;
        }

        public void Execute()
        {
            foreach (var item in this.commands)
            {
                item.Execute();
            }
        }

        public void Undo()
        {
            foreach (var item in this.commands)
            {
                item.Undo();
            }
        }
    }
}
