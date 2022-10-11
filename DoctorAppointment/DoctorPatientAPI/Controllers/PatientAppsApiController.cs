using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DoctorAppointment.Context;
using DoctorPatientAPI.Models;

namespace DoctorPatientAPI.Controllers
{
    public class PatientAppsApiController : ApiController
    {
        private AppointmentContext db = new AppointmentContext();

        // GET: api/PatientApps
        public IQueryable<PatientApp> GetPatientApps()
        {
            return db.PatientApps;
        }

        // GET: api/PatientApps/5
        [ResponseType(typeof(PatientApp))]
        public IHttpActionResult GetPatientApp(int id)
        {
            PatientApp patientApp = db.PatientApps.Find(id);
            if (patientApp == null)
            {
                return NotFound();
            }

            return Ok(patientApp);
        }

        // PUT: api/PatientApps/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPatientApp(int id, PatientApp patientApp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != patientApp.PId)
            {
                return BadRequest();
            }

            db.Entry(patientApp).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientAppExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PatientApps
        [ResponseType(typeof(PatientApp))]
        public IHttpActionResult PostPatientApp(PatientApp patientApp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PatientApps.Add(patientApp);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = patientApp.PId }, patientApp);
        }

        // DELETE: api/PatientApps/5
        [ResponseType(typeof(PatientApp))]
        public IHttpActionResult DeletePatientApp(int id)
        {
            PatientApp patientApp = db.PatientApps.Find(id);
            if (patientApp == null)
            {
                return NotFound();
            }

            db.PatientApps.Remove(patientApp);
            db.SaveChanges();

            return Ok(patientApp);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PatientAppExists(int id)
        {
            return db.PatientApps.Count(e => e.PId == id) > 0;
        }
    }
}