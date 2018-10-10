using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Facade.Interface
{
    public interface ICdPlayer
    {
        void On();
        void Off();
        void Eject();
        void Pause();
        void Play();        
        void Stop();
    }
}
