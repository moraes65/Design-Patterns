using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Command.Entities
{
    public class GarageDoor : IGarageDoor
    {
        public void Down()
        {
            Console.WriteLine("Garage Door Down...");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage Door Light off");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage Door Light on");
        }

        public void Stop()
        {
            Console.WriteLine("Garage Door stop");
        }

        public void Up()
        {
            Console.WriteLine("Garage Door up");
        }
    }
}
