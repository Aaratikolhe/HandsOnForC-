using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingNulls
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName;
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }

        public Student(int id, string firstName, string lastName, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

       
    }
}
