using fabiostefani.io.BookPadroesProjetos.Facade.Interface;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Facade.Classes
{
    public class MaquinaPipoca : IMaquinaPipoca
    {
        
        public void Fazer()
        {
            Console.WriteLine("Fazendo pipoca");
        }

        public void Off()
        {
            Console.WriteLine("Desligando a popoqueira");
        }

        public void On()
        {
            Console.WriteLine("Ligando a popoqueira");
        }
    }
}
