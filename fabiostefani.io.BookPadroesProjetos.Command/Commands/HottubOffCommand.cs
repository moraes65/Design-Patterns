using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class HottubOffCommand : ICommand
    {
        private readonly IHottub hottub;
        public HottubOffCommand(IHottub hottub)
        {
            this.hottub = hottub;
        }
        public void Execute()
        {
            this.hottub.Off();
        }

        public void Undo()
        {
            this.hottub.On();
        }
    }
}
