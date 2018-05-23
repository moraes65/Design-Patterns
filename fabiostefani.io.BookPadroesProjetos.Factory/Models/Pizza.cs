using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Models
{
    public abstract class Pizza
    {        
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<PizzaTopping> Toppings { get; private set; }


        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (var item in Toppings)
            {
                Console.WriteLine("    " + item.Name);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350º");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string GetName()
        {
            return Name;
        }

        public void AddTooping(string name)
        {
            Toppings = Toppings ?? new List<PizzaTopping>();

            Toppings.Add(new PizzaTopping(name));
        }
    }
}
