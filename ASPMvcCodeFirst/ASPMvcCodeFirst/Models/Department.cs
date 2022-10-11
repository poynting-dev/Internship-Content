using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMvcCodeFirst.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public int TotalEmployees { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}