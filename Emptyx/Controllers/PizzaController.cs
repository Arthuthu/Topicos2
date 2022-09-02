using PizzariaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dapper;
using static Dapper.SqlMapper;
using PizzariaLibrary.Models;
using System.Data.SqlClient;

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

        //Action para chamar a View do CriarPizza.
        public ActionResult CriarPizza()
        {
            return View();
        }

        //Action que vai ser chamada quanto o botão Create for clicado.
        [HttpPost]
        public ActionResult CriarPizza(Pizzas pizza)
        {
            //Se todos os campos estiverem certo, a data sera passada em diante.
            if (ModelState.IsValid)
            {
                //Chama o método Criar na Classe GetPizzas e passa o objeto preenchido com a data da form da view.
                var data = new GetPizzas().Criar(pizza);

                return RedirectToAction("Pizzas");
            }

            return View();
        }
    }
}