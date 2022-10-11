using DoctorAppointment.Models;
using DoctorPatientAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DoctorAppointment.Context
{
    public class AppointmentContext: DbContext
    {
        public AppointmentContext(): base("AppointmentDB")
        { }

        public DbSet<PatientApp> PatientApps { get; set; }
        
        public DbSet<DoctorsApp> DoctorsApp { get; set; }

        public System.Data.Entity.DbSet<DoctorAppointment.Models.Appointment> Appointments { get; set; }
    }
}