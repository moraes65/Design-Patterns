using fabiostefani.io.BookPadroesProjetos.Factory.Enums;
using fabiostefani.io.BookPadroesProjetos.Factory.Factory;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            new PizzaStore(new SimplePizzaFactory()).OrderPizza(EnumTypePizza.Veggies);

            Console.ReadKey();
        }
    }
}
