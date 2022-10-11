using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCodeFirstApproach.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Ename { get; set; }
        public int Address { get; set; }
        public int Phone { get; set; }  
        public virtual Department Department { get; set; }
    }
}