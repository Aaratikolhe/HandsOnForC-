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
        public Marks Marks { get;  }

        public Student(int id, string name, Marks marks)
        {
            Id = id;
            Name = name;
            Marks = marks;
        }
    }
}
