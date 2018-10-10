using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Facade.Interface
{
    public interface IAmplificador
    {
        void On();
        void Off();
        void SetCd();
        void SetDvd(IDvdPlayer dvd);
        void SetStereoSound();
        void SetSurroundSound();
        void SetTuner();
        void SetVolume(int volume);
    }
}
