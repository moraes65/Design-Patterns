using fabiostefani.io.BookPadroesProjetos.Facade.Interface;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Facade.Classes
{
    public class Amplificador : IAmplificador
    {
        private IDvdPlayer _dvdPlayer;
        public void Off()
        {
            Console.WriteLine("Desligando o amplificador");
        }

        public void On()
        {
            Console.WriteLine("Ligando o amplificador");
        }

        public void SetCd()
        {
            Console.WriteLine("Amplificador deve tocar CD player");
        }

        public void SetDvd(IDvdPlayer dvdPlayer)
        {
            _dvdPlayer = dvdPlayer;
            Console.WriteLine("Amplificador deve tocar DVD player");
        }

        public void SetStereoSound()
        {
            Console.WriteLine("Trocando para modo de som stereo");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Trocando para modo de som Surround");
        }

        public void SetTuner()
        {
            Console.WriteLine("Setando Tuner");
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine($"Ajustando volume para {volume}");
        }
    }
}
