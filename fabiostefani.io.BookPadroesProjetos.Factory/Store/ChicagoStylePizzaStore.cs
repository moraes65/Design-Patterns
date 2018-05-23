using System;
using System.Collections.Generic;
using System.Text;
using fabiostefani.io.BookPadroesProjetos.Factory.Enums;
using fabiostefani.io.BookPadroesProjetos.Factory.Models;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Store
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(EnumTypePizza type)
        {
            switch (type)
            {
                case EnumTypePizza.Cheese:
                    return new ChicagoStyleCheesePizza();                    
                case EnumTypePizza.Greek:
                    return new ChicagoStyleGreekPizza();
                case EnumTypePizza.Pepperoni:
                    return new ChicagoStylePepperoniPizza();
                case EnumTypePizza.Clam:
                    return new ChicagoStyleClamPizza();
                case EnumTypePizza.Veggies:
                    return new ChicagoStyleVeggiesPizza();
                default:
                    throw new ApplicationException($"Type {type} not implemented");
            }
        }
    }
}
