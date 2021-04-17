using fabiostefani.io.BookPadroesProjetos.Command.Entities;

namespace fabiostefani.io.BookPadroesProjetos.Command.Interfaces
{
    public interface ICeilingFan
    {
        void On();
        void Off();
        void High();

        void Medium();

        void Low();

        EnumSpeedCeilingFan GetSpeed();
    }
}
