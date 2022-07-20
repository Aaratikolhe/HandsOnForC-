using TestProblem1.EnumClass;
using TestProblem1.ExtensionMethods;

namespace TestProblem1.Models
{
    public class Employee
    {
        public Guid id;
        public Guid Id
        {
            get
            {               
                return Guid.NewGuid();
            }
        }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime BirthDate { get; }
        public double age;
        public double Age
        {
            get
            {
                return BirthDate.Age();
            }
        }

        public Gender Gender { get; }
        public double Salary { get; }
        public Department Department { get; }

        public Employee(
            string firstName,
            string lastName,
            DateTime birthDate,
            Gender gender,
            double salary,
            Department department
            )
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            Salary = salary;
            Department = department;
        }

        public override string ToString()
        {
            return "Employee Id: " + Id + ", First Name: " + FirstName + ", Last Name: " + LastName + ", Gender: " + Gender +
                ", Age: " + Age + ", Salary: " + Salary;
        }
        public static Dictionary<Department, List<string>> getDepartmentWiseEmployeeName(List<Employee> employeeList)
        {
            Dictionary<Department, List<string>> result = new Dictionary<Department, List<string>>();
            List<string> employeeNameList;
            foreach (Employee employee in employeeList)
            {
                if (result.ContainsKey(employee.Department))
                {
                    result[employee.Department].Add(employee.FirstName);
                }
                else
                {
                    employeeNameList = new List<string>();
                    employeeNameList.Add(employee.FirstName);
                    result.Add(employee.Department, employeeNameList);
                }
            }
            return result;
        }
    }
}
