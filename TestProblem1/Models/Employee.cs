
using TestProblem1.EnumClass;

namespace TestProblem1.Models
{
    public class Employee
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime BirthDate { get; }
        public double Age { get; }
        
        public Gender Gender { get; }
        public double Salary { get; }
        public string Department { get; }

        public Employee(
            int Id,
            string firstName,
            string lastName,
            DateTime birthDate,
            double age,
            Gender gender,
            double salary,
            string department)
        {
            this.Id = Id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Age = age;
            Gender = gender;
            Salary = salary;
            Department = department;
        }

        public override string ToString()
        {
            return "Employee Id: " + Id + ", First Name: " + FirstName + ", Last Name: " + LastName + ", Gender: " + Gender +
                ", Age: " + Age + ", Salary: " + Salary + ", Department Name: " + Department;
        }
        public double CalculateAge()
        {
            return BirthDate.Year - DateTime.Today.Year;
        }

    }
}
