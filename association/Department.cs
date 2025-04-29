using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    internal class Department
    {
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();

    }
}
