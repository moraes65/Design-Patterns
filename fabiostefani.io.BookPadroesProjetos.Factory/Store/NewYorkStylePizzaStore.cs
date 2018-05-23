using System;
using System.Collections.Generic;
using System.Text;
using fabiostefani.io.BookPadroesProjetos.Factory.Enums;
using fabiostefani.io.BookPadroesProjetos.Factory.Models;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Store
{
    public class NewYorkStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(EnumTypePizza type)
        {
            switch (type)
            {
                case EnumTypePizza.Cheese:
                    return new NewYorkStyleCheesePizza();                    
                case EnumTypePizza.Greek:
                    return new NewYorkStyleGreekPizza();                    
                case EnumTypePizza.Pepperoni:
                    return new NewYorkStylePepperoniPizza();                    
                case EnumTypePizza.Clam:
                    return new NewYorkStyleClamPizza();                    
                case EnumTypePizza.Veggies:
                    return new NewYorkStyleVeggiesPizza();                    
                default:
                    throw new ApplicationException($"Type {type} not implemented.");
            }
        }
    }
}
