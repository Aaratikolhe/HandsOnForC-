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
        //public string? FirstName { get; set; }
        public string FirstName { get; set; }
        private string lastName;

        //[DisallowNull]
        //public string? LastName 
        //{ 
        //    get=>lastName;
        //    set=>lastName=value??throw new ArgumentNullException(nameof(value)); }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string? ToUpperName()=> FirstName?.ToUpperInvariant();
        //public Student(string firstName, string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;

        //}
    }
}
