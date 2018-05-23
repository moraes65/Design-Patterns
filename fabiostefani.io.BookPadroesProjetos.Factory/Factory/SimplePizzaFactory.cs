using fabiostefani.io.BookPadroesProjetos.Factory.Enums;
using fabiostefani.io.BookPadroesProjetos.Factory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Factory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(EnumTypePizza type)
        {
            Pizza pizza;
            switch (type)
            {
                case EnumTypePizza.Cheese:
                    pizza = new CheesePizza();
                    break;
                //case EnumTypePizza.Greek:
                //    pizza = new GreekPizza();
                //    break;
                case EnumTypePizza.Pepperoni:
                    pizza = new NewYorkStylePepperoniPizza();
                    break;
                case EnumTypePizza.Clam:
                    pizza = new NewYorkStyleClamPizza();
                    break;
                case EnumTypePizza.Veggies:
                    pizza = new NewYorkStyleVeggiesPizza();
                    break;
                default:
                    throw new ApplicationException($"Tipo {type} não preparado.");
            }
            return pizza;
        }
    }
}
