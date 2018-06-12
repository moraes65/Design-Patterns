using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Singleton
{
    public class SingletonExampleChargerFast
    {
        private static SingletonExampleChargerFast _uniqueInstance = new SingletonExampleChargerFast();
        private SingletonExampleChargerFast()
        {

        }

        public static SingletonExampleChargerFast GetInstance()
        {
            Console.WriteLine("Returning instance SingletonExampleChargerFast");
            return _uniqueInstance;
        }
    }
}
