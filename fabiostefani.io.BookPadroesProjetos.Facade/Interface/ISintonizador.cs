using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Facade.Interface
{
    public interface ISintonizador
    {
        void On();
        void Off();
        void SetAm();
        void SetFm();
        void SetFrequency();
    }
}
