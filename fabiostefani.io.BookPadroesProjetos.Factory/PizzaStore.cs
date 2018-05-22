using fabiostefani.io.BookPadroesProjetos.Factory.Enums;
using fabiostefani.io.BookPadroesProjetos.Factory.Factory;
using fabiostefani.io.BookPadroesProjetos.Factory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.BookPadroesProjetos.Factory
{
    public class PizzaStore
    {
        private readonly SimplePizzaFactory _factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }
        public Pizza OrderPizza(EnumTypePizza type)
        {
            var pizza = _factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
