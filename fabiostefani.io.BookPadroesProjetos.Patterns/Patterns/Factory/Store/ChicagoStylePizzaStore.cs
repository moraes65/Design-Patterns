using fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory.Model;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(EnumTypePizza typePizza)
        {
            switch (typePizza)
            {
                case EnumTypePizza.Cheese:
                    return new ChicagoCheesePizza();
                //case EnumTypePizza.Greek:
                //    return new GreekPizza();
                case EnumTypePizza.Pepperoni:
                    return new ChicagoPepperoniPizza();
                case EnumTypePizza.Clam:
                    return new ChicagoClamPizza();
                case EnumTypePizza.Veggie:
                    return new ChicagoVeggiePizza();
                default:
                    throw new Exception("Type not prepared.");
            }
        }
    }
}
