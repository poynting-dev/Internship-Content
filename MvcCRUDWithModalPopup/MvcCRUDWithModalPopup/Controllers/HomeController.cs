using MvcCRUDWithModalPopup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCRUDWithModalPopup.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployees()
        {
            using(EmployeeEntities dc = new EmployeeEntities())
            { 
                var employees = dc.tblStudents.OrderBy(a => a.Id).ToList();
                return Json(new {data=employees}, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]

        public ActionResult Save(int Id)
        {
            using (EmployeeEntities dc = new EmployeeEntities())
            {
                var v = dc.tblStudents.Where(a => a.Id==Id).FirstOrDefault();
                return View(v);
            }
        }

        [HttpPost]

        public ActionResult Save(tblStudent emp)
        {
            bool status = false;
            if(ModelState.IsValid)
            {
                using (EmployeeEntities dc = new EmployeeEntities())
                {
                    if(emp.Id>0)
                    {
                        //Edit
                        var v = dc.tblStudents.Where(a => a.Id==emp.Id).FirstOrDefault();
                        if(v!=null)
                        {
                            v.Id = emp.Id;
                            v.Name = emp.Name;
                            v.FatherName = emp.FatherName;
                            v.Email = emp.Email;
                            v.Mobile = emp.Mobile;
                            v.Description = emp.Description;
                        }
                    }
                    else
                    {
                        //Save
                        dc.tblStudents.Add(emp);
                    }
                    dc.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult { Data = new { status=status} };
        }


        [HttpGet]

        public ActionResult Delete(int Id)
        {
            using (EmployeeEntities dc = new EmployeeEntities())
            {
                var v = dc.tblStudents.Where(a => a.Id == Id).FirstOrDefault();
                if(v!= null)
                {
                    return View(v);
                }
                else
                {
                     return HttpNotFound();
                }
            }
        }



        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteEmployee(int Id)
        {
            bool status = false;
            using (EmployeeEntities dc = new EmployeeEntities())
            {
                //Edit
                var v = dc.tblStudents.Where(a => a.Id == Id).FirstOrDefault();
                if (v != null)
                {
                    dc.tblStudents.Remove(v);
                    dc.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult { Data = new { status = status } };
        }
    }
}