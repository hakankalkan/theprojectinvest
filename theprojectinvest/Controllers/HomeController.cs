using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace theprojectinvest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult AnaSayfa()
        {
            return View();
        }
        public ActionResult Hizmetlerimiz()
        {
            return View();
            
        }
        public ActionResult Proje()
        {
            return View();
        }
        public ActionResult Yatirim()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult Sektorler()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }
    }
}