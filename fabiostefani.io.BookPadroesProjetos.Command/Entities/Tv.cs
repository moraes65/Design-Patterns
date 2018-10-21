using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Command.Entities
{
    public class Tv : ITv
    {
        private readonly string name;

        public Tv(string name)
        {
            this.name = name;
        }
        public void Off()
        {
            Console.WriteLine($"{this.name} TV off");
        }

        public void On()
        {
            Console.WriteLine($"{this.name} TV on");
        }
    }
}
