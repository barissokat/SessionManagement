using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session.Add("Owner", "Baris Sokat");
            Session["Owner2"] = "Baris Sokat";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = Session["Owner"];

            return View();
        }
    }
}