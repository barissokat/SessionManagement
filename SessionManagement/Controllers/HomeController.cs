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
            //Sessions
            Session.Add("Owner", "Baris Sokat");
            Session["Owner2"] = "Baris Sokat";

            //Application Objects
            HttpContext.Application.Add("Owner", "Baris Sokat");
            HttpContext.Application["Owner2"] = "Baris Sokat";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            Session.Remove("Owner");

            return View();
        }

        public ActionResult Contact()
        {
            if (Session["Owner"] == null)
                ViewBag.Message = "Session is null";
            else
                ViewBag.Message = "Session is " + Session["Owner"];
            return View();
        }

        public ActionResult DisplayOnlineUserCount()
        {
            ViewBag.OnlineUserCount = HttpContext.Application["OnlineUserCount"];
            return View();
        }
    }
}