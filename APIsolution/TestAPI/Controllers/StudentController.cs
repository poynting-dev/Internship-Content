using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [EnableCors(origins: "https://localhost:44347", headers:"*", methods:"*")]
    public class StudentController : ApiController
    {
        List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Name = "Prateek",
                DOB = DateTime.Now,
                EmailId = "test@test.com"
            },
            new Student()
            {
                Id = 2,
                Name = "Nishant",
                DOB = DateTime.Now,
                EmailId = "nish@dotnet.com"
            }
        };

        public IEnumerable<Student> GetStudents()
        {
            return students;
        }
    }
}
