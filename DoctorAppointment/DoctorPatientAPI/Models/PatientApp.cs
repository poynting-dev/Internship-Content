using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoctorPatientAPI.Models
{
    public enum Gender
    {
        Male, Female
    }

    public class PatientApp
    {

        [Key]
        public int PId { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        [Required(ErrorMessage = "Enter Patient's Name")]
        [MaxLength(50, ErrorMessage = "Max 25 length is allowed")]
        [Display(Name = " Patient's name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter Patient's Date-of-Birth")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string DOB { get; set; }

        public string gender { get; set; }

        [Required(ErrorMessage = "Enter Phone")]
        [MaxLength(10, ErrorMessage = "Max 10 length is allowed")]
        [Display(Name = "Contact No.")]
        [DataType(DataType.PhoneNumber)]
        public string phone { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [MaxLength(100)]
        [Display(Name = "Email Id")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

    }
}