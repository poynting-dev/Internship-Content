using DoctorPatientAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoctorAppointment.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        public int PId { get; set; }

        public int DId { get; set; }

        public string DName { get; set; }
        public string PName { get; set; }


        [Required(ErrorMessage = "Enter Start Time")]
        [DataType(DataType.Time)]
        [Display(Name = "Start Time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public string startTime { get; set; }

        [Required(ErrorMessage = "Enter End Time")]
        [DataType(DataType.Time)]
        [Display(Name = "End Time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public string endTime { get; set; }

        public string dept { get; set; }

        [DataType(DataType.MultilineText)]
        public string purpose { get; set; }

        public bool isActive { get; set; }
    }
}