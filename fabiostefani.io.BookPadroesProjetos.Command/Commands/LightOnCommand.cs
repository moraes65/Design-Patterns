using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class LightOnCommand : ICommand
    {
        private readonly ILight light;
        public LightOnCommand(ILight light)
        {
            this.light = light;
        }
        public void Execute()
        {
            this.light.On();
        }

        public void Undo()
        {
            this.light.Off();
        }
    }
}
