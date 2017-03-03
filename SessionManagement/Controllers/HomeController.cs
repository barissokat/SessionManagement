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
            //Session.Add("Owner", "Baris Sokat");
            //Session["Owner2"] = "Baris Sokat";

            //Application Objects
            HttpContext.Application.Add("Owner", "Baris Sokat");
            HttpContext.Application["Owner2"] = "Baris Sokat";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //Sessions
            //Session.Remove("Owner");

            //Application Objects
            HttpContext.Application.Remove("Owner");

            return View();
        }

        public ActionResult Contact()
        {
            //Sessions
            //if (Session["Owner"] == null)
            //    ViewBag.Message = "Session is null";
            //else
            //    ViewBag.Message = "Session is " + Session["Owner"];
            //return View();

            //Application Objects
            if (HttpContext.Application["Owner"] == null)
                ViewBag.Message = "Application is null";
            else
                ViewBag.Message = "Application is " + HttpContext.Application["Owner"];
            return View();
        }

        public ActionResult DisplayOnlineUserCount()
        {
            ViewBag.OnlineUserCount = HttpContext.Application["OnlineUserCount"];
            return View();
        }
    }
}