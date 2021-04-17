using fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory.Model;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory
{
    public abstract class FactoryPizza
    {
        public static Pizza CreatePizza(EnumTypePizza typePizza)
        {
            switch (typePizza)
            {
                case EnumTypePizza.Cheese:
                    return new CheesePizza();
                case EnumTypePizza.Greek:
                    return new GreekPizza();
                case EnumTypePizza.Pepperoni:
                    return new PepperoniPizza();
                case EnumTypePizza.Clam:
                    return new ClamPizza();
                case EnumTypePizza.Veggie:
                    return new VeggiePizza();
                default:
                    throw new Exception("Type not prepared.");
            }
        }
    }
}
