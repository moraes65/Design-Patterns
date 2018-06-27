using fabiostefani.io.BookPadroesProjetos.Adapter.Interfaces;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Adapter.Ducks
{
    public class MallardDuck : IDuck
    {
        public MallardDuck()
        {
            Console.WriteLine("The Duck says");
        }
        public void Fly()
        {
            Console.WriteLine("I'm flying...");
        }

        public void Quack()
        {
            Console.WriteLine("Quack Quack...");
        }
    }
}
