
using TestProblem1.EnumClass;
using TestProblem1.ExtensionMethods;

namespace TestProblem1.Models
{
    public class Employee:IEmployee
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
        public List<Employee> GetEmployeeDetailsFromUser()
        {
            List<Employee> employeeDetailsList = new List<Employee>();
            Console.WriteLine("Enter Employee details");
            char choice = 'c';

            while (choice == 'c')
            {
                try
                {
                    Console.WriteLine("Enter Employee Id");
                    int employeeId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Employee first Name");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter Employee Last Name");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter Employee Birth Date in yyyy,mm,dd format");
                    DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                    Gender gender = new Gender();
                    while (gender != Gender.Female && gender != Gender.Male)
                    {
                        try
                        {
                            Console.WriteLine("Enter Employee Gender:Female / Male");
                            string genderType = Console.ReadLine();

                            gender = (Gender)Enum.Parse(typeof(Gender), genderType);
                        }
                        catch
                        {
                            Console.WriteLine("Gender can be entered as Male and Female only");
                            continue;
                        }
                    }
                    double age = birthDate.Age();
                    Console.WriteLine("Enter Employee Salary");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Employee department Name");
                    string department = Console.ReadLine();
                    employeeDetailsList.Add(new Employee(employeeId, firstName, lastName, birthDate, age, gender, salary, department));
                    Console.WriteLine("Press c to continue to add more employee details and q to exit ");
                    choice = Convert.ToChar(Console.ReadLine());
                    if (choice != 'c' & choice != 'q')
                        Console.WriteLine("Invalid Choice");
                }
                catch
                {
                    Console.WriteLine("Enter values in correct format(Id,salary,age-number format & first name,lastname,department name-string format");
                }

            }
            return employeeDetailsList;
        }


    }
}
