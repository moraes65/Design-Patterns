using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Command.Interfaces
{
    public interface IStereo
    {
        void On();
        void Off();
        void SetCd();
        void SetDvd();
        void SetRadio();
        void SetVolume();
    }
}
