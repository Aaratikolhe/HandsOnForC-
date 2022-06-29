using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class Student
    {
        public int Id { get;  }
        public string Name { get;  }
        public int Age { get; }
        public Marks Marks { get;  }

        public Student()
        { }
        public Student(int id, string name, Marks marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }
        public Student(int id, string name,int age, Marks marks)
        {
            Id = id;
            Name = name;
            Age= age;
            Marks = marks;
        }
    }
}
