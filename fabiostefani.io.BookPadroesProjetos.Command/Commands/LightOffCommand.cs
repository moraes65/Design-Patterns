using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class LightOffCommand : ICommand
    {
        private readonly ILight light;
        public LightOffCommand(ILight light)
        {
            this.light = light;
        }
        public void Execute()
        {
            this.light.Off();
        }

        public void Undo()
        {
            this.light.On();
        }
    }
}
