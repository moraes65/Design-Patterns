using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly IGarageDoor garageDoor;

        public GarageDoorOpenCommand(IGarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            this.garageDoor.Up();
        }

        public void Undo()
        {
            this.garageDoor.Down();
        }
    }
}
