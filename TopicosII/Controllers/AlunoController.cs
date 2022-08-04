using Business;
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
            var getAlunos = new GetAlunos();

            ViewBag.Message = getAlunos.GetAlunosList();

            return View();
        }
    }
}