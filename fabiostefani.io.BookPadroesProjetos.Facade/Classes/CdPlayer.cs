using fabiostefani.io.BookPadroesProjetos.Facade.Interface;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Facade.Classes
{
    public class CdPlayer : ICdPlayer
    {
        public void Eject()
        {
            Console.WriteLine("Ejetando o disco do CD player");
        }

        public void Off()
        {
            Console.WriteLine("Desligando o CD player");
        }

        public void On()
        {
            Console.WriteLine("Ligando o CD player");
        }

        public void Pause()
        {
            Console.WriteLine("Pausando as músicas do CD player");
        }

        public void Play()
        {
            Console.WriteLine("Tocando as músicas do CD player");
        }

        public void Stop()
        {
            Console.WriteLine("Parando as músicas do CD player");
        }        
    }
}
