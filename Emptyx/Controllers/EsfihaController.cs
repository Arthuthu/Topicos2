﻿using PizzariaLibrary;
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
        public ActionResult Esfihas()
        {
            ViewBag.Esfihas = new GetEsfihas().Listar();
            return View();
        }

        public ViewResult EsfihaDetalhes(int id)
        {
            var data = new GetEsfihas().Buscar(id);
            ViewBag.Esfiha = data;
            return View(data);
        }
    }
}