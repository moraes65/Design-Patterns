using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class TvOffCommand : ICommand
    {
        private readonly ITv tv;
        public TvOffCommand(ITv tv)
        {
            this.tv = tv;
        }
        public void Execute()
        {
            this.tv.Off();
        }

        public void Undo()
        {
            this.tv.On();
        }
    }
}
