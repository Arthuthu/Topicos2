using PizzariaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emptyx.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Pizzas()
        {
            ViewBag.Pizzas = new GetPizzas().Listar();
            return View();
        }

        public ViewResult PizzaDetalhes(int id)
        {
            var data = new GetPizzas().Buscar(id);
            ViewBag.Pizza = data;
            return View(data);
        }

        public ActionResult CriarPizza()
        {

            return View();
        }
    }
}