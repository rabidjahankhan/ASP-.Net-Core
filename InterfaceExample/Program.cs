using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.RegNo = "12345";
            student.Name = "John Doe";

            string info = student.GetBasicInformation();

            Department department = new Department();
            department.Code = "CS101";
            department.Name = "Computer Science";

            string departmentInfo = department.GetBasicInformation();

            Course course = new Course();
            course.Code = "CS101";
            course.Name = "Introduction to Programming";
            course.Credits = 3;

            string courseInfo = course.GetBasicInformation();
        }
    }
}
