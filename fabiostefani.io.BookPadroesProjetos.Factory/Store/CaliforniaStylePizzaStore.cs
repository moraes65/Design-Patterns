using System;
using System.Collections.Generic;
using System.Text;
using fabiostefani.io.BookPadroesProjetos.Factory.Enums;
using fabiostefani.io.BookPadroesProjetos.Factory.Models;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Store
{
    public class CaliforniaStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(EnumTypePizza type)
        {
            switch (type)
            {
                case EnumTypePizza.Cheese:
                    return new CaliforniaStyleCheesePizza();                    
                case EnumTypePizza.Greek:
                    return new CaliforniaStyleGreekPizza();
                case EnumTypePizza.Pepperoni:
                    return new CaliforniaStylePepperoniPizza();
                case EnumTypePizza.Clam:
                    return new CaliforniaStyleClamPizza();
                case EnumTypePizza.Veggies:
                    return new CaliforniaStyleVeggiesPizza();
                default:
                    throw new ApplicationException($"Type {type} not implemented");
            }
        }
    }
}
