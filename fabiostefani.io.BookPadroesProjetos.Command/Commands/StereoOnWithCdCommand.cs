using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class StereoOnWithCdCommand : ICommand
    {
        private readonly IStereo stereo;

        public StereoOnWithCdCommand(IStereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            this.stereo.On();
            this.stereo.SetCd();
            this.stereo.SetVolume();
        }

        public void Undo()
        {
            this.stereo.Off();
        }
    }
}
