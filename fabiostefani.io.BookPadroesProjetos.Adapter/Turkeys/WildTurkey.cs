using fabiostefani.io.BookPadroesProjetos.Adapter.Ducks;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Adapter.Turkeys
{
    public class WildTurkey : ITurkey
    {
        public WildTurkey()
        {
            Console.WriteLine("The turkey says");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying  short distance...");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }
    }
}
