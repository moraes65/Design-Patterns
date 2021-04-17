using fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory.Model;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory
{
    public class NyStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(EnumTypePizza typePizza)
        {
            switch (typePizza)
            {
                case EnumTypePizza.Cheese:
                    return new NyStyleCheesePizza();
                //case EnumTypePizza.Greek:
                //    return new NyStyleGreekPizza();
                case EnumTypePizza.Pepperoni:
                    return new NyStylePepperoniPizza();
                case EnumTypePizza.Clam:
                    return new NyStyleClamPizza();
                case EnumTypePizza.Veggie:
                    return new NyStyleVeggiePizza();
                default:
                    throw new Exception("Type not prepared.");
            }
        }
    }
}
