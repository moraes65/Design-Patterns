using System;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Models
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust dough";
            Sauce = "Plum tomato Sauce";
            AddTooping("Shredded Mozzarella Cheese");            
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices.");
        }

    }
}
