using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Command.Interfaces
{
    public interface IGarageDoor
    {
        void Up();
        void Down();
        void Stop();
        void LightOn();
        void LightOff();
    }
}
