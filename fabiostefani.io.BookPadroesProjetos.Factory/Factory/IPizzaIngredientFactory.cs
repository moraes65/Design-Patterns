using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Factory
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        IList<IVeggies> CreateVeggies();
        IPepperoni CreatePepperoni();
        IClam CreateClam();
    }
}
