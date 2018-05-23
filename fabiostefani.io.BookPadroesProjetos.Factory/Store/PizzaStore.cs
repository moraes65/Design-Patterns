using fabiostefani.io.BookPadroesProjetos.Factory.Enums;
using fabiostefani.io.BookPadroesProjetos.Factory.Factory;
using fabiostefani.io.BookPadroesProjetos.Factory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.BookPadroesProjetos.Factory
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(EnumTypePizza type);

        public Pizza OrderPizza(EnumTypePizza type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
