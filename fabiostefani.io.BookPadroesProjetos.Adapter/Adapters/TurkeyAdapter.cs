using fabiostefani.io.BookPadroesProjetos.Adapter.Ducks;
using fabiostefani.io.BookPadroesProjetos.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Adapter.Adapters
{
    public class TurkeyAdapter : IDuck
    {
        private readonly ITurkey _turkey;
        public TurkeyAdapter(ITurkey turkey)
        {
            Console.WriteLine("Turkey adapter Says...");
            _turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
            
        }

        public void Quack()
        {
            _turkey.Gobble();
        }
    }
}
