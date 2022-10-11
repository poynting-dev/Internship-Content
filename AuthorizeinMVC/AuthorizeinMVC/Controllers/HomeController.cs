using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthorizeinMVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult NonSecureMethod()
        {
            return View();
        }

        public ActionResult SecureMethod()
        {
            return View();
        }
    }
}