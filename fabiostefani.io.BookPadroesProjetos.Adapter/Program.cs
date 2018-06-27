using fabiostefani.io.BookPadroesProjetos.Adapter.Adapters;
using fabiostefani.io.BookPadroesProjetos.Adapter.Ducks;
using fabiostefani.io.BookPadroesProjetos.Adapter.Interfaces;
using fabiostefani.io.BookPadroesProjetos.Adapter.Turkeys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck duck = new MallardDuck();
            duck.Fly();
            duck.Quack();
            Console.WriteLine();

            ITurkey turkey = new WildTurkey();
            turkey.Fly();
            turkey.Gobble();
            Console.WriteLine();

            IDuck adapterDuck = new TurkeyAdapter(turkey);
            adapterDuck.Fly();
            adapterDuck.Quack();
            Console.WriteLine();

            ITurkey adapterTurkey = new DuckAdapter(duck);
            adapterTurkey.Fly();
            adapterTurkey.Gobble();

            Console.ReadKey();
        }
    }
}
