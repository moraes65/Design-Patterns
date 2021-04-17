
using fabiostefani.io.BookPadroesProjetos.Command.Commands;

namespace fabiostefani.io.BookPadroesProjetos.Command
{
    public class SimpleRemoteControl
    {
        private ICommand command;
        public SimpleRemoteControl()
        {

        }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ButtonWasPressed()
        {
            this.command.Execute();
        }
    }
}
