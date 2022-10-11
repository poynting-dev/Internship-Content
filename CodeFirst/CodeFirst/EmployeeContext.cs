using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using CodeFirst.Models;

namespace CodeFirst
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(): base("EmployeeDB")
        {

        }

        public DbSet<Employee> Employee { get; set; }
    }
}