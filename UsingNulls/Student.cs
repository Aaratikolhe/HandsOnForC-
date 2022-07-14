using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingNulls
{
    public class Student
    {
        public int Id { get; set; }
        //public string? FirstName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string? ToUpperName()=> FirstName?.ToUpperInvariant();
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }
    }
}
