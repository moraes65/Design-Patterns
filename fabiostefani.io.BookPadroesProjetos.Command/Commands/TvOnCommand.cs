using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class TvOnCommand : ICommand
    {
        private readonly ITv tv;
        public TvOnCommand(ITv tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            this.tv.On();
        }

        public void Undo()
        {
            this.tv.Off();
        }
    }
}
