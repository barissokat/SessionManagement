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
            HttpContext.Response.Cookies.Add(cookieUser);
            ViewBag.User = HttpContext.Request.Cookies["user"].Value;
            return View();
        }
    }
}