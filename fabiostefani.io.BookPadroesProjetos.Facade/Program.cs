using fabiostefani.io.BookPadroesProjetos.Facade.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var home = new HomeTheaterFacade(new MaquinaPipoca(),
                                  new Tela(),
                                  new LuzAmbiente(),
                                  new Projetor(),
                                  new Amplificador(),
                                  new DvdPlayer());
            home.VerFilme("O ATIRADOR");
            Console.WriteLine("..");
            Thread.Sleep(200);
            Console.WriteLine("....");
            Thread.Sleep(200);
            Console.WriteLine("......");
            Thread.Sleep(200);
            Console.WriteLine("........");
            Thread.Sleep(200);
            Console.WriteLine("..........");
            Thread.Sleep(200);
            Console.WriteLine("............");
            Thread.Sleep(200);
            Console.WriteLine("...............");
            home.FinalizarFilme();
            Console.ReadKey();
        }
    }
}
