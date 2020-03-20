using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize]
        public ActionResult Chip()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GtaV()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult mordhau()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult darksouls()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult crusaderkings()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}