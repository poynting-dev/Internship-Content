using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormAuthenticationDemo.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            HttpCookie httpCookie = new HttpCookie("TestCookie");
            httpCookie.Value = "Priyanshu";
            this.ControllerContext.HttpContext.Response.Cookies.Add(httpCookie);
            ViewBag.CookieMessage = httpCookie.Value;

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("TestCookie"))
            {
                HttpCookie cookie = this.ControllerContext.HttpContext.Request.Cookies["TestCookie"];

                ViewBag.CookieMessage = cookie.Value;
            }


            return View();
        }

        public ActionResult Contact()
        {
            if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("TestCookie"))
            {
                HttpCookie cookie = this.ControllerContext.HttpContext.Request.Cookies["TestCookie"];

                ViewBag.CookieMessage = cookie.Value;
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}