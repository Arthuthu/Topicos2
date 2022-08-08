using Business.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TopicosII.Controllers
{
    public class AlunoController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Alunos = new GetAlunos().Listar();

            return View();
        }
    }
}