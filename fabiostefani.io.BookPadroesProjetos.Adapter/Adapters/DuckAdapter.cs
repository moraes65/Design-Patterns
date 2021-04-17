using fabiostefani.io.BookPadroesProjetos.Adapter.Ducks;
using fabiostefani.io.BookPadroesProjetos.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Adapter.Adapters
{
    public class DuckAdapter : ITurkey
    {
        private readonly IDuck _duck;
        public DuckAdapter(IDuck duck)
        {
            Console.WriteLine("Duck adapter Says...");
            _duck = duck;
        }

        public void Fly()
        {
            var rand = new Random();
            if (rand.Next(5) == 0)
            {
                _duck.Fly();
            }            
        }

        public void Gobble()
        {
            _duck.Quack();
        }
    }
}
