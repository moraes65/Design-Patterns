using fabiostefani.io.BookPadroesProjetos.Factory.Ingredients.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Models
{
    public abstract class Pizza
    {        
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public IList<IVeggies> Veggies { get; set; }
        public ICheese Cheese { get; set; }
        public IPepperoni Pepperoni { get; set; }
        public IClam Clam { get; set; }


        public abstract void Prepare();
        

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

        //public void AddTooping(IVeggies name)
        //{
        //    Toppings = Toppings ?? new List<IVeggies>();

        //    Toppings.Add(name);
        //}
    }
}
