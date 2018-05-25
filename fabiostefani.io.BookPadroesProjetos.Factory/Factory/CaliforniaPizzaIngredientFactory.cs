using System;
using System.Collections.Generic;
using System.Text;
using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Interface;
using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Veggies;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Factory
{
    public class CaliforniaPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new GoatCheese();
        }

        public IClam CreateClam()
        {
            return new CamariClams();
        }

        public IDough CreateDough()
        {
            return new VeryThinCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new BruschettaSauce();
        }

        public IList<IVeggies> CreateVeggies()
        {
            return new List<IVeggies>
            {
                new Onion(),
                new RedPepper(),
                new Garlic()
            };
        }
    }
}
