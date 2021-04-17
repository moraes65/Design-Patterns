using fabiostefani.io.BookPadroesProjetos.Facade.Interface;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Facade.Classes
{
    public class Projetor : IProjetor
    {
        public void Off()
        {
            Console.WriteLine("Desligando o projetor");
        }

        public void On()
        {
            Console.WriteLine("Ligando o projetor");
        }

        public void TvMode()
        {
            Console.WriteLine("Setando o projetor para TV Mode.");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Setando o projetor WideScreen");
        }
    }
}
