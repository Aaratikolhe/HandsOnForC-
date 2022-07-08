namespace TestProblem1
{
    public class Employee
    {
        public int EmployeeId { get; }
        public string EmployeeFirstName { get; }
        public string EmployeeLastName { get; }
        public double EmployeeAge { get; }
        public string Gender { get; }
        public double Salary { get; }
        public string EmployeeDepartment { get; }

        public Employee(int employeeId, string employeeFirstName, string employeeLastName, double employeeAge, string gender, double salary, string employeeDepartment)
        {
            EmployeeId = employeeId;
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            EmployeeAge = employeeAge;
            Gender = gender;
            Salary = salary;
            EmployeeDepartment = employeeDepartment;
        }

        public override string? ToString()
        {
            return "Employee Id: " + EmployeeId + ", First Name: " + EmployeeFirstName + ", Last Name: " + EmployeeLastName +
                ", Age: " + EmployeeAge + ", Salary: " + Salary + ", Department Name: " + EmployeeDepartment;
        }
        
    }
}
