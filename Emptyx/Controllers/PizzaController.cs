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
        public ActionResult Pizzas(int ordem = 0)
        {
            var lista = new PizzaDAO().Listar();

            switch (ordem)
            {
                //Ordem alfabética
                case 0:
                    lista = lista.OrderBy(o => o.Nome).ToList();
                    break;
                //Ordem por Tipo
                case 1:
                    lista = lista.OrderBy(o => o.TipoNome).ToList();
                    break;
                //Ordem por Valor
                case 2:
                    lista = lista.OrderBy(o => o.Valor).ToList();
                    break;
            }

            ViewBag.Pizzas = lista;

            return View();
        }

        public ViewResult PizzaDetalhes(int id)
        {
            var data = new PizzaDAO().Buscar(id);
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
                new PizzaDAO().Criar(pizza);

                return RedirectToAction("Pizzas");
            }

            return View();
        }

        public ActionResult AtualizarPizza(int id)
        {
            var obj = new PizzaDAO().Buscar(id);

            if (obj != null)
            {
                Pizzas pizza = new Pizzas();

                pizza.IdTipo = obj.IdTipo;
                pizza.Nome = obj.Nome;
                pizza.Descricao = obj.Descricao;
                pizza.Valor = obj.Valor;
                pizza.Ativo = obj.Ativo;

                return View(pizza);
            }

            return View();
        }

        [HttpPost]
        public ActionResult AtualizarPizza(Pizzas pizza)
        {
            new PizzaDAO().Atualizar(pizza);

            return RedirectToAction("Pizzas");

        }

        public ActionResult DeletarPizza()
        {
            return View();
        }

        //[HttpDelete] não funciona mas [HttpPost] sim ?
        [HttpPost]
        public ActionResult DeletarPizza(int id)
        {
            new PizzaDAO().Deletar(id);
            return RedirectToAction("Pizzas");
        }
    }
}