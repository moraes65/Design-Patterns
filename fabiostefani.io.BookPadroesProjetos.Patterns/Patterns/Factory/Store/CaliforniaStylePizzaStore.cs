using fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory.Model;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory
{
    public class CaliforniaStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(EnumTypePizza typePizza)
        {
            switch (typePizza)
            {
                case EnumTypePizza.Cheese:
                    return new CaliforniaCheesePizza();
                //case EnumTypePizza.Greek:
                //    return new GreekPizza();
                case EnumTypePizza.Pepperoni:
                    return new CaliforniaPepperoniPizza();
                case EnumTypePizza.Clam:
                    return new CaliforniaClamPizza();
                case EnumTypePizza.Veggie:
                    return new CaliforniaVeggiePizza();
                default:
                    throw new Exception("Type not prepared.");
            }
        }
    }
}
