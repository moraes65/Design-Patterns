using System.Collections.Generic;
using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Interface;
using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Veggies;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Factory
{
    public class NewYorkPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IClam CreateClam()
        {
            return new FreshClams();
        }

        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public IList<IVeggies> CreateVeggies()
        {
            var veggies = new List<IVeggies>
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
            return veggies;
        }
    }
}
