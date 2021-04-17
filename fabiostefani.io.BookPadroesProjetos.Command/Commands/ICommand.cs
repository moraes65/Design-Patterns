namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
