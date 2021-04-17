using System.Collections.Generic;

namespace fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory.Model
{
    public class ChicagoCheesePizza : Pizza
    {
        public ChicagoCheesePizza() : base("Chicago Style Deep Dish Cheese Pizza", "Extra Thick Crust Dough", "Plum Tomato Sauce", new List<string>() { "Shredded Mozzarella Cheese" })
        {

        }
    }
}
