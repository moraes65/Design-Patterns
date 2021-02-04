using fabiostefani.io.BookPadroesProjetos.Patterns.Infra;
using fabiostefani.io.BookPadroesProjetos.Patterns.Models;
using fabiostefani.io.BookPadroesProjetos.Patterns.Patterns.Factory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace fabiostefani.io.BookPadroesProjetos.Patterns.Controllers
{
    public class FactoryController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public FactoryController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NyPizzaStore()
        {
            return View("NyStylePizzaStore");
        }

        public IActionResult ChicagoPizzaStore()
        {
            return View("ChicagoStylePizzaStore");
        }


        public string CheeseNyStyle()
        {
            Events.Clear();
            var nyStylePizzaStore = new NyStylePizzaStore();
            nyStylePizzaStore.OrderPizza(Patterns.Factory.Model.EnumTypePizza.Cheese);
            return Events.Print();
        }

        public string CheeseChicagoStyle()
        {
            Events.Clear();
            var chicagoStylePizzaStore = new ChicagoStylePizzaStore();
            chicagoStylePizzaStore.OrderPizza(Patterns.Factory.Model.EnumTypePizza.Cheese);
            return Events.Print();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
