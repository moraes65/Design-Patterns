using System;
using System.Collections.Generic;
using System.Text;
using fabiostefani.io.BookPadroesProjetos.Factory.Enums;
using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Factory;
using fabiostefani.io.BookPadroesProjetos.Factory.Models;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Store
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(EnumTypePizza type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
            switch (type)
            {
                case EnumTypePizza.Cheese:
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = nameof(CheesePizza);
                    break;
                case EnumTypePizza.Greek:
                    pizza = new GreekPizza(ingredientFactory);
                    pizza.Name = nameof(GreekPizza);
                    break;
                case EnumTypePizza.Pepperoni:
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = nameof(PepperoniPizza);
                    break;
                case EnumTypePizza.Clam:
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = nameof(ClamPizza);
                    break;
                case EnumTypePizza.Veggies:
                    pizza = new VeggiesPizza(ingredientFactory);
                    pizza.Name = nameof(VeggiesPizza);
                    break;
                default:
                    throw new ApplicationException($"Type {type} not implemented.");
            }
            return pizza;
        }
    }
}
