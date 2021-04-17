using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Singleton
{
    public class SingletonExample
    {
        private static SingletonExample _uniqueInstance;
        private SingletonExample()
        {

        }

        public static SingletonExample GetInstance()
        {
            if (_uniqueInstance == null)
            {
                Console.WriteLine("Creating unique instance SingletonExample");
                _uniqueInstance = new SingletonExample();
            }
            Console.WriteLine("Returning instance SingletonExample");
            return _uniqueInstance;
        }
    }
}
