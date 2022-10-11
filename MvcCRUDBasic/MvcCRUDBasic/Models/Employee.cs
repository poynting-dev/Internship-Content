using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcCRUDBasic.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "This field is required")]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string FatherName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Description { get; set; }
    }
}