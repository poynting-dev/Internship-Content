using ExceptionFilterInMVC.Models;
using MVCFiltersDemo.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFiltersDemo.Controllers
{

    [HandleError(ExceptionType = typeof(DivideByZeroException), View = "DivideByZero")]
    [HandleError(ExceptionType = typeof(NullReferenceException), View = "NullReference")]
    [LogCustomExceptionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        //[OutputCache (Duration = 15)]
        //public string Index()
        //{
        //    return "This is a Demo MVC Filter";
        //}
        [OutputCache(Duration = 2)]
        public string GetCurrentTime()
        {
            return DateTime.Now.ToString("T");
        }
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Index()
        {
            throw new Exception("Something went wrong");
        }
        public ActionResult About()
        {
            throw new NullReferenceException();
        }
        public ActionResult Contact()
        {
            throw new DivideByZeroException();
        }
    }
}