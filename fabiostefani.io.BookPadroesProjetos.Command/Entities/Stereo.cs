using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Command.Entities
{
    public class Stereo : IStereo
    {
        private readonly string name;

        public Stereo(string name)
        {
            this.name = name;
        }
        public void Off()
        {
            Console.WriteLine($"{this.name} Stereo off");
        }

        public void On()
        {
            Console.WriteLine($"{this.name} Stereo on");
        }

        public void SetCd()
        {
            Console.WriteLine($"{this.name} Stereo playing CD");
        }

        public void SetDvd()
        {
            Console.WriteLine($"{this.name} Stereo playing DVD");
        }

        public void SetRadio()
        {
            Console.WriteLine($"{this.name} Stereo playing Radio");
        }

        public void SetVolume()
        {
            Console.WriteLine($"{this.name} Stereo set Volume");
        }
    }
}
