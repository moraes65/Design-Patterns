using fabiostefani.io.BookPadroesProjetos.Facade.Interface;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Facade.Classes
{
    public class LuzAmbiente : ILuzAmbiente
    {
        public void Dim()
        {
            Console.WriteLine("Ajustando a luz ambiente");
        }

        public void Off()
        {
            Console.WriteLine("Apagando a luz ambiente");
        }

        public void On()
        {
            Console.WriteLine("Acendendo a luz ambiente");
        }
    }
}
