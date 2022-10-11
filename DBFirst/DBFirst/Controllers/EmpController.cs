using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBFirst.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            OfficeEntities officeEntities = new OfficeEntities();
            List<Employee> employees = officeEntities.Employees.ToList();

            return View(employees);

            return View();
        }
    }
}