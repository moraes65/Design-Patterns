using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Factory;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Models
{
    public class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }
        //public CheesePizza()
        //{
        //    Console.WriteLine("Cheese Pizza");
        //}
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Dough = _pizzaIngredientFactory.CreateDough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Cheese = _pizzaIngredientFactory.CreateCheese();
        }
    }
}
