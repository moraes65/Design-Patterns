using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class CeilingFanOnCommand : ICommand
    {
        private readonly ICeilingFan ceilingFan;
        public CeilingFanOnCommand(ICeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            this.ceilingFan.On();
        }

        public void Undo()
        {
            this.ceilingFan.Off();
        }
    }
}
