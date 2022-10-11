using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorPatientAPI.Models
{
    public class DoctorsApp
    {
        [Key]
        public int DId { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        [Required(ErrorMessage = "Enter your Name")]
        [MaxLength(25, ErrorMessage = "Max 25 length is allowed")]
        [Display(Name = " Doctor name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter Department")]
        [Display(Name = "Department")]
        public string dept { get; set; }

        [Required(ErrorMessage = "Enter Start Time")]
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public string startTime { get; set; }

        [Required(ErrorMessage = "Enter End Time")]
        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public string endTime { get; set; }


        [Required(ErrorMessage = "Enter Phone")]
        [MaxLength(10, ErrorMessage = "Max 10 length is allowed")]
        [Display(Name = "Contact No.")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [MaxLength(100)]
        [Display(Name = "Email Id")]
        public string email { get; set; }

        public bool isActive { get; set; }
    }
}