using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        private readonly IGarageDoor garageDoor;

        public GarageDoorCloseCommand(IGarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            this.garageDoor.Down();
        }

        public void Undo()
        {
            this.garageDoor.Up();
        }
    }
}
