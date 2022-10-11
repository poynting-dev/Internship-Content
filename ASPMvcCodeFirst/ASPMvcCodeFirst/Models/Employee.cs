using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMvcCodeFirst.Models
{
    public class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }

    }
}