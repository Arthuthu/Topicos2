using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Emptyx.Controllers
{
    public class PrincipalController : Controller
    {
        //Listar   - Index
        //Alterar  - Update
        //Inserir  - Create
        //Apagar   - Delete
        //Detalhes - Details

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Sobre()
        {
            return View();
        }
    }
}