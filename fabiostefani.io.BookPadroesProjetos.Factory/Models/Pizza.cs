using System;
using System.Collections.Generic;
using System.Text;

namespace fabiostefani.io.BookPadroesProjetos.Factory.Models
{
    public abstract class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing");
        }

        public void Bake()
        {
            Console.WriteLine("Baking");
        }

        public void Cut()
        {
            Console.WriteLine("Cuting");
        }

        public void Box()
        {
            Console.WriteLine("Boxing");
        }
    }
}
