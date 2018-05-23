using System;
using System.Collections.Generic;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Models
{
    public class NewYorkStyleCheesePizza : Pizza
    {
        public NewYorkStyleCheesePizza()
        {
            Name = "New York Style Sauce and Cheese Pizza";
            Dough = "Thin crust dough";
            Sauce = "Marinara Sauce";
            AddTooping("Grated Reggiano Cheese");
        }

    }
}
