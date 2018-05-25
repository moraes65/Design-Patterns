using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Factory;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Models
{
    public class PepperoniPizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Pepperoni = _pizzaIngredientFactory.CreatePepperoni();
        }
    }
}
