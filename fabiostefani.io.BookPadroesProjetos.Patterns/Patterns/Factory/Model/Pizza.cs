using fabiostefani.io.BookPadroesProjetos.Patterns.Infra;
using System.Collections.Generic;

namespace fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory
{
    public abstract class Pizza
    {
        protected Pizza(string name, string dough, string sauce, List<string> toopings)
        {
            Name = name;
            Dough = dough;
            Sauce = sauce;
            Toopings = toopings;
        }

        string Name { get; set; }
        string Dough { get; set; }
        string Sauce { get; set; }
        List<string> Toopings { get; set; }
        public void Prepare()
        {
            Events.Add($"Preparing {Name}");
            Events.Add("Tossing dough");
            Events.Add("Adding sauce");
            Events.Add("Adding  toppings");
            Toopings.ForEach(x => Events.Add($"    {x}"));
        }

        public void Bake()
        {
            Events.Add("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Events.Add("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Events.Add("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return Name;
        }
    }
}
