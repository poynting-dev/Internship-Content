using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable_EquitableInterfaces
{
    public class Student : IEquatable<Student>
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double marks { get; set; }

        public bool Equals(Student stud)
        {
            return ((firstName == stud.firstName) && (lastName == stud.lastName));
        }
    }
    public class SortUsingIEquatable
    {
        List<Student> students = new List<Student>()
        {
            new Student()
            {
                firstName = "Aman",
                lastName =  "Gupta",
                marks = 84
            },
            new Student()
            {
                firstName = "Prateek",
                lastName =  "Babbar",
                marks = 77
            },
            new Student()
            {
                firstName = "Nishant",
                lastName =  "Rathi",
                marks = 86
            },
            new Student()
            {
                firstName = "Pratima",
                lastName =  "Singh",
                marks = 84
            }
        };
        Student stu = new Student()
        {
            firstName = "James",
            lastName = "Moore",
            marks = 84
        }; 
}
}