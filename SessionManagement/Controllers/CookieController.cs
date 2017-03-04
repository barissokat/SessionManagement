using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionManagement.Controllers
{
    public class CookieController : Controller
    {
        public ActionResult Create()
        {
            HttpCookie cookieUser = new HttpCookie("user", "baris");
            cookieUser.Expires = DateTime.Now.AddDays(1);
            HttpContext.Response.Cookies.Add(cookieUser);
            ViewBag.User = HttpContext.Request.Cookies["user"].Value;
            return View();
        }

        public ActionResult Delete()
        {
            HttpContext.Request.Cookies.Remove("user");
            return View();
        }

        public ActionResult Control()
        {
            if (HttpContext.Request.Cookies["user"] == null)
                ViewBag.User = "Cookie is null";
            else
                ViewBag.User = "Cookie is " + HttpContext.Request.Cookies["user"].Value;
            return View();
        }
    }
}