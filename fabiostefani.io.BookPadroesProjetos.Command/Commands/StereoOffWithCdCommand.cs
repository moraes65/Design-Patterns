using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Command.Commands
{
    public class StereoOffWithCdCommand : ICommand
    {
        private readonly IStereo stereo;

        public StereoOffWithCdCommand(IStereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            this.stereo.Off();            
        }

        public void Undo()
        {
            this.stereo.On();
            this.stereo.SetCd();
            this.stereo.SetVolume();
        }
    }
}
