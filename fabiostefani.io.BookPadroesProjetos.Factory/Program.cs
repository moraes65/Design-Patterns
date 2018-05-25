using fabiostefani.io.BookPadroesProjetos.Factory.Enums;
using fabiostefani.io.BookPadroesProjetos.Factory.Store;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Factory
{
    class Program
    {
        static void Main()
        {
            new ChicagoStylePizzaStore().OrderPizza(EnumTypePizza.Cheese);
            new NewYorkStylePizzaStore().OrderPizza(EnumTypePizza.Cheese);
            //new CaliforniaStylePizzaStore().OrderPizza(EnumTypePizza.Pepperoni);
            //Console.WriteLine("tste");
            Console.ReadKey();
        }
    }
}
