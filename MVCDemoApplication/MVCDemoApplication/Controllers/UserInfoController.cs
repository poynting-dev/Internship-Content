using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoApplication.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        UserInfoContext db = new UserInfoContext();
        public ActionResult Index()
        {
            return View(db.students.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Create(student userInfo)
        {
            if(ModelState.IsValid)
            {
                db.students.Add(userInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userInfo);
        }
    }
}