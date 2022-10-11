using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DoctorAppointment.Context;
using DoctorPatientAPI.Models;

namespace DoctorAppointment.Controllers
{
    public class PatientAppsController : Controller
    {
        private AppointmentContext db = new AppointmentContext();

        // GET: PatientApps
        public ActionResult Index()
        {
            return View(db.PatientApps.ToList());
        }

        // GET: PatientApps/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientApp patientApp = db.PatientApps.Find(id);
            if (patientApp == null)
            {
                return HttpNotFound();
            }
            return View(patientApp);
        }

        // GET: PatientApps/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientApps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PId,username,password,name,DOB,gender,phone,email")] PatientApp patientApp)
        {
            if (ModelState.IsValid)
            {
                db.PatientApps.Add(patientApp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patientApp);
        }

        // GET: PatientApps/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientApp patientApp = db.PatientApps.Find(id);
            if (patientApp == null)
            {
                return HttpNotFound();
            }
            return View(patientApp);
        }

        // POST: PatientApps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PId,username,password,name,DOB,gender,phone,email")] PatientApp patientApp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patientApp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(patientApp);
        }

        // GET: PatientApps/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientApp patientApp = db.PatientApps.Find(id);
            if (patientApp == null)
            {
                return HttpNotFound();
            }
            return View(patientApp);
        }

        // POST: PatientApps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientApp patientApp = db.PatientApps.Find(id);
            db.PatientApps.Remove(patientApp);
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
