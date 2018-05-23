using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Models
{
    public class PizzaTopping
    {
        public PizzaTopping(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }

    }
}
