using fabiostefani.io.BookPadroesProjetos.Facade.Interface;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Facade.Classes
{
    public class Tela : ITela
    {
        public void Down()
        {
            Console.WriteLine("Diminuindo a tela");
        }

        public void Up()
        {
            Console.WriteLine("Aumentando a tela");
        }
    }
}
