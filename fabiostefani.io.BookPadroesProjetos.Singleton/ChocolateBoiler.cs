using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Singleton
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler _chocolateBoiler;

        private bool Empty;
        private bool Boiled;
        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if (_chocolateBoiler == null)
            {
                Console.WriteLine("Creating ChocolateBoiler");
                _chocolateBoiler = new ChocolateBoiler();
            }
            Console.WriteLine("Returning ChocolateBoiler");
            return _chocolateBoiler;
        }

        private bool IsEmpty()
        {
            return Empty;
        }

        private bool IsBoiled()
        {
            return Boiled;
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                Empty = false;
                Boiled = false;
            }
        }

        public void Drain()
        {
            if (!IsEmpty() && IsBoiled())
            {
                Empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                Boiled = true;
            }
        }
    }
}
