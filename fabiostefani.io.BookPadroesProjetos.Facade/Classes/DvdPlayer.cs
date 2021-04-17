using fabiostefani.io.BookPadroesProjetos.Facade.Interface;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Facade.Classes
{
    public class DvdPlayer : IDvdPlayer
    {
        public void Eject()
        {
            Console.WriteLine("Ejetando o disco do DVD player");
        }

        public void Off()
        {
            Console.WriteLine("Desligando o DVD player");
        }

        public void On()
        {
            Console.WriteLine("Ligando o DVD player");
        }

        public void Pause()
        {
            Console.WriteLine("Pausando o filme do DVD player");
        }

        public void Play(string filme)
        {
            Console.WriteLine($"Tocando o filme {filme} do DVD player");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Setando o DVD player para Surround");
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine("Setando o DVD player para dois canais.");
        }

        public void Stop()
        {
            Console.WriteLine("Parando o filme do DVD player");
        }        
    }
}
