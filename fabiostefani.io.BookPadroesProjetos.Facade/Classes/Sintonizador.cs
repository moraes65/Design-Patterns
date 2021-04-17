using fabiostefani.io.BookPadroesProjetos.Facade.Interface;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Facade.Classes
{
    public class Sintonizador : ISintonizador
    {
        public void Off()
        {
            Console.WriteLine("Desligando o sintonizador");
        }

        public void On()
        {
            Console.WriteLine("Ligando o sintonizador");
        }

        public void SetAm()
        {
            Console.WriteLine("Setando A.M.");
        }

        public void SetFm()
        {
            Console.WriteLine("Setando F.M.");
        }

        public void SetFrequency()
        {
            Console.WriteLine("Setando a frequência");
        }        
    }
}
