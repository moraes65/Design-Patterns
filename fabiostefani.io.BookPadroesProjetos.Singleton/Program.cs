using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonExample.GetInstance();
            SingletonExample.GetInstance();
            SingletonExample.GetInstance();
            SingletonExample.GetInstance();

            ChocolateBoiler.GetInstance();
            ChocolateBoiler.GetInstance();
            ChocolateBoiler.GetInstance();
            ChocolateBoiler.GetInstance();

            SingletonExampleChargerFast.GetInstance();
            SingletonExampleChargerFast.GetInstance();
            SingletonExampleChargerFast.GetInstance();
            SingletonExampleChargerFast.GetInstance();

            Console.ReadKey();
        }
    }
}
