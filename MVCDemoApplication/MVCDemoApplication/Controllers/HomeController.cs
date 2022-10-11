using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoApplication.Controllers
{
    public class HomeController : Controller
    {
        [Route("mvctest/{id}")]
        public ActionResult Index(int id)
        {
            ViewData["viewdata1"] = DateTime.Now.ToString();
            ViewBag.viewbag1 = id.ToString();
            return View();
        }


        [Route("mvctest/abt", Name ="abt")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}