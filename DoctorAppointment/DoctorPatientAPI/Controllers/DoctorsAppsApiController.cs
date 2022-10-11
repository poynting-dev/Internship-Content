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
    public class DoctorsAppsApiController : ApiController
    {
        private AppointmentContext db = new AppointmentContext();

        // GET: api/DoctorsApps
        public IQueryable<DoctorsApp> GetDoctorsApp()
        {
            return db.DoctorsApp;
        }

        // GET: api/DoctorsApps/5
        [ResponseType(typeof(DoctorsApp))]
        public IHttpActionResult GetDoctorsApp(int id)
        {
            DoctorsApp doctorsApp = db.DoctorsApp.Find(id);
            if (doctorsApp == null)
            {
                return NotFound();
            }

            return Ok(doctorsApp);
        }

        // PUT: api/DoctorsApps/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDoctorsApp(int id, DoctorsApp doctorsApp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != doctorsApp.DId)
            {
                return BadRequest();
            }

            db.Entry(doctorsApp).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoctorsAppExists(id))
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

        // POST: api/DoctorsApps
        [ResponseType(typeof(DoctorsApp))]
        public IHttpActionResult PostDoctorsApp(DoctorsApp doctorsApp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DoctorsApp.Add(doctorsApp);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = doctorsApp.DId }, doctorsApp);
        }

        // DELETE: api/DoctorsApps/5
        [ResponseType(typeof(DoctorsApp))]
        public IHttpActionResult DeleteDoctorsApp(int id)
        {
            DoctorsApp doctorsApp = db.DoctorsApp.Find(id);
            if (doctorsApp == null)
            {
                return NotFound();
            }

            db.DoctorsApp.Remove(doctorsApp);
            db.SaveChanges();

            return Ok(doctorsApp);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DoctorsAppExists(int id)
        {
            return db.DoctorsApp.Count(e => e.DId == id) > 0;
        }
    }
}