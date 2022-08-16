using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TopicosII.Controllers
{
    public class BootstrapController : Controller
    {
        // GET: Bootstrap

        // O nome dessa action devera ser igual o nome da view (arquivo .cshtml)
        public ActionResult Index()
        {
            return View();
        }
    }
}