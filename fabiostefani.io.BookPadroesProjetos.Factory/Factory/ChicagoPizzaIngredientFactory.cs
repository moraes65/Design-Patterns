using System;
using System.Collections.Generic;
using System.Text;
using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Interface;
using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Veggies;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Factory
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IClam CreateClam()
        {
            return new FrozemClams();
        }

        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IList<IVeggies> CreateVeggies()
        {
            return new List<IVeggies>
            {
                new Onion(),
                new RedPepper()                
            };
        }
    }
}
