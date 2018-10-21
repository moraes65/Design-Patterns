using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Command.Entities
{
    public class Light : ILight
    {
        private readonly string name;

        public Light(string name)
        {
            this.name = name;
        }
        public void Off()
        {
            Console.WriteLine($"{this.name} light is Off");
        }

        public void On()
        {
            Console.WriteLine($"{this.name} light is On");
        }
    }
}
