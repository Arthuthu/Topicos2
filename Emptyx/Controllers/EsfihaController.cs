using PizzariaLibrary;
using PizzariaLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emptyx.Controllers
{
    public class EsfihaController : Controller
    {
        // GET: Esfiha
        public ActionResult Esfihas(int ordem = 0)
        {
            var lista = new EsfihaDAO().Listar();

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

            ViewBag.Esfihas = lista;

            return View();
        }

        public ViewResult EsfihaDetalhes(int id)
        {
            var data = new EsfihaDAO().Buscar(id);
            ViewBag.Esfiha = data;
            return View(data);
        }

        public ActionResult CriarEsfiha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CriarEsfiha(Esfihas esfiha)
        {
            //Se todos os campos estiverem certo, a data sera passada em diante.
            if (ModelState.IsValid)
            {
                //Chama o método Criar na Classe GetPizzas e passa o objeto preenchido com a data da form da view.
                new EsfihaDAO().Criar(esfiha);

                return RedirectToAction("Esfihas");
            }

            return View();
        }

        public ActionResult AtualizarEsfiha(int id)
        {
            var obj = new EsfihaDAO().Buscar(id);

            if (obj != null)
            {
                Esfihas esfiha = new Esfihas();

                esfiha.IdTipo = obj.IdTipo;
                esfiha.Nome = obj.Nome;
                esfiha.Descricao = obj.Descricao;
                esfiha.Valor = obj.Valor;
                esfiha.Ativo = obj.Ativo;

                return View(esfiha);
            }

            return View();
        }

        [HttpPost]
        public ActionResult AtualizarEsfiha(Esfihas esfiha)
        {
            new EsfihaDAO().Atualizar(esfiha);

            return RedirectToAction("Esfihas");

        }

        public ActionResult DeletarEsfiha(int id)
        {
            var obj = new EsfihaDAO().Buscar(id);

            if (obj != null)
            {
                Esfihas esfiha = new Esfihas();

                esfiha.TipoNome = obj.TipoNome;
                esfiha.Nome = obj.Nome;
                esfiha.Descricao = obj.Descricao;
                esfiha.Valor = obj.Valor;
                esfiha.Ativo = obj.Ativo;

                return View(esfiha);
            }

            return RedirectToAction("Esfihas");
        }

        [HttpPost]
        public ActionResult DeletarEsfiha(Esfihas esfiha)
        {
            new EsfihaDAO().Deletar(esfiha.Id);

            return RedirectToAction("Esfihas");
        }
    }
}