using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DoctorAppointment.Context;
using DoctorAppointment.Models;
using DoctorPatientAPI.Models;

namespace DoctorAppointment.Controllers
{
    [Authorize]
    public class DoctorsAppsController : Controller
    {
        private AppointmentContext db = new AppointmentContext();

        // GET: DoctorsApps
        public ActionResult Index()
        {
            return View(db.DoctorsApp.ToList());
        }

        // GET: DoctorsApps/Details/5
        public ActionResult Book(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorsApp doctorsApp = db.DoctorsApp.Find(id);
            var name = User.Identity.Name;
            PatientApp patientApp = db.PatientApps.FirstOrDefault(i => i.name == name.ToString());
            if (doctorsApp == null)
            {
                return HttpNotFound();
            }
            Appointment newAppointment = new Appointment();
            newAppointment.PId = patientApp.PId;
            newAppointment.DId = doctorsApp.DId;
            newAppointment.DName = doctorsApp.name;
            newAppointment.PName = patientApp.name;
            newAppointment.startTime = doctorsApp.startTime;
            newAppointment.endTime = doctorsApp.endTime;
            newAppointment.dept = doctorsApp.dept;

            return View(newAppointment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Book([Bind(Include = "PId, DId, DName,PName,startTime,endTime,dept,purpose,isActive")] Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                db.Appointments.Add(appointment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }

        // GET: DoctorsApps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorsApps/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DId,username,password,name,dept,startTime,endTime,phone,email,isActive")] DoctorsApp doctorsApp)
        {
            if (ModelState.IsValid)
            {
                db.DoctorsApp.Add(doctorsApp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctorsApp);
        }

        // GET: DoctorsApps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorsApp doctorsApp = db.DoctorsApp.Find(id);
            if (doctorsApp == null)
            {
                return HttpNotFound();
            }
            return View(doctorsApp);
        }

        // POST: DoctorsApps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DId,username,password,name,dept,startTime,endTime,phone,email,isActive")] DoctorsApp doctorsApp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctorsApp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctorsApp);
        }

        // GET: DoctorsApps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DoctorsApp doctorsApp = db.DoctorsApp.Find(id);
            if (doctorsApp == null)
            {
                return HttpNotFound();
            }
            return View(doctorsApp);
        }

        // POST: DoctorsApps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DoctorsApp doctorsApp = db.DoctorsApp.Find(id);
            db.DoctorsApp.Remove(doctorsApp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
