using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Factory;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Models
{
    public class ClamPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Clam = _pizzaIngredientFactory.CreateClam();
        }
    }
}
