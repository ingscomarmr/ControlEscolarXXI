using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlEscolar.Controllers
{
    public class HomeController : Controller
    {
        //http://localhost:5534/home/index
        //http://localhost:5534/home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AcercaDe()
        {
            return View();
        }
    }
}