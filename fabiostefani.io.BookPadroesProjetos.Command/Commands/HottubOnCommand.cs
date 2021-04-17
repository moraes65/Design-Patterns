using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class HottubOnCommand : ICommand
    {
        private readonly IHottub hottub;
        public HottubOnCommand(IHottub hottub)
        {
            this.hottub = hottub;
        }
        public void Execute()
        {
            this.hottub.On();
        }

        public void Undo()
        {
            this.hottub.Off();
        }
    }
}
