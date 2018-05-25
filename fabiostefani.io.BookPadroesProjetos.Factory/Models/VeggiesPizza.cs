using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Factory;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Models
{
    public class VeggiesPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public VeggiesPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this._pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Veggies = _pizzaIngredientFactory.CreateVeggies();
        }
    }
}
