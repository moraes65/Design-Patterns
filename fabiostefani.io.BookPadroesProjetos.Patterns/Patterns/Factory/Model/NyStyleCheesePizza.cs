using fabiostefani.io.BookPadroesProjetos.Patterns.Infra;
using System.Collections.Generic;

namespace fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory.Model
{
    public class NyStyleCheesePizza : Pizza
    {

        public NyStyleCheesePizza() : base("NY Style Sauce and Cheese Pizza", "Thin Crust Dough", "Marinara Sauce", new List<string>() { "Grated Reggiano Cheese" })
        {

        }

        public override void Cut()
        {
            Events.Add("Cutting the pizza into square slices");
        }
    }
}
