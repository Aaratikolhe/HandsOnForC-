using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    public static class Extension
    {
        public static int FindStudentWithMaximumAge(this List<Student> list)
        {
            var maxAge = list.Max(student => student.Age);
            return maxAge;
        }
    }
}
