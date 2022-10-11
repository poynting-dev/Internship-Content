using DoctorAppointment.Context;
using DoctorAppointment.Models;
using DoctorPatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DoctorAppointment.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Patient
        public ActionResult PatientLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PatientLogin(PatientApp model)
        {
            using (var context = new AppointmentContext())
            {
                bool isValid = context.PatientApps.Any(x => x.username == model.username && x.password == model.password);
                if (isValid)
                {
                    PatientApp app = context.PatientApps.FirstOrDefault(i => i.username == model.username && i.password == model.password);
                    FormsAuthentication.SetAuthCookie(app.name, true);
                    return RedirectToAction("Index", "DoctorsApps");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username and Password");
                    return View();
                }
            }
        }

        public ActionResult PatientSignup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PatientSignup(PatientApp model)
        {
            using (var context = new AppointmentContext())
            {
                context.PatientApps.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("PatientLogin");
        }

        ///Doctors Login and Signup

        public ActionResult DoctorLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoctorLogin(DoctorsApp model)
        {
            using (var context = new AppointmentContext())
            {
                bool isValid = context.DoctorsApp.Any(x => x.username == x.username && x.password == model.password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.username, true);
                    return RedirectToAction("Index", "DoctorsApps");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username and Password");
                    return View();
                }
            }
        }

        public ActionResult DoctorSignup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoctorSignup(DoctorsApp model)
        {
            using (var context = new AppointmentContext())
            {
                context.DoctorsApp.Add(model);
                context.SaveChanges();
            }
            return RedirectToAction("DoctorLogin");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("PatientLogin");
        }
    }
}