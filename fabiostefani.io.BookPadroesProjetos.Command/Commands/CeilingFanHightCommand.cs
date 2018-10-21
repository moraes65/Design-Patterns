using fabiostefani.io.BookPadroesProjetos.Command.Entities;
using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class CeilingFanHightCommand : ICommand
    {
        private readonly ICeilingFan ceilingFan;
        private EnumSpeedCeilingFan prevSpeed;
        public CeilingFanHightCommand(ICeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            this.prevSpeed = this.ceilingFan.GetSpeed();
            this.ceilingFan.High();
        }

        public void Undo()
        {
            switch (prevSpeed)
            {
                case EnumSpeedCeilingFan.Off:
                    this.ceilingFan.Off();
                    break;
                case EnumSpeedCeilingFan.Low:
                    this.ceilingFan.Low();
                    break;
                case EnumSpeedCeilingFan.Medium:
                    this.ceilingFan.Medium();
                    break;
                case EnumSpeedCeilingFan.High:
                    this.ceilingFan.High();
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
