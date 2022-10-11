using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMvcCodeFirst.Models
{
    public class Program
    {
        static void main(string[] args)
        {
            using(DepartmentContext context = new DepartmentContext())
            {
                Department employee1 = new Department()
                {
                    DeptId = 1,
                    DeptName ="CSE",
                    TotalEmployees=100
                };
                context.Departments.Add( employee1 );
                context.SaveChanges();
            }
        }
    }
}