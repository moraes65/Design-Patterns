using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Command.Entities
{
    public class Hottub : IHottub
    {
        private readonly string name;

        
        public void Off()
        {
            Console.WriteLine($"Hottub off");
        }

        public void On()
        {
            Console.WriteLine($"Hottub on");
        }
    }
}
