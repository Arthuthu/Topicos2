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

        [HttpPost]
        public ActionResult CriarPizza(Pizzas pizza)
        {
            var banco = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PizzariaData;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            banco.Execute("insert into Pizzas values (@IdTipo, @Nome, @Descricao, @Quantidade, @Valor, @Ativo)", pizza);

            return View(pizza);
        }
    }
}