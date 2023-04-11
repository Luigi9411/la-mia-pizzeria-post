using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        
        public IActionResult Index()
        {
            using var ctx = new PizzaContext();

            var pizzas = ctx.Pizzas.ToArray();

            return View(pizzas);
        }

        public IActionResult Detail(int id)
        {

            using var ctx = new PizzaContext();

            var pizza = ctx.Pizzas.Find(id);

            if (pizza is null)
            {
                return NotFound($"L'id {id} della pizza non è stato trovato");
            }

            return View(pizza);
        }

    }
}
