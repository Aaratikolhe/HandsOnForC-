using TestProblem1.EnumClass;
using TestProblem1.ExtensionMethods;
using TestProblem1.Models;
using TestProblem1.Repositories;

namespace TestProblem1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employeeList = GetEmployeeDetailsFromUser();
            //List<Employee> employeeList = new List<Employee>()
            //{
            //    new Employee(1,"Arati","Kolhe",new DateTime(1996-07-06),Gender.Female,20000,Department.Development),
            //    new Employee(2,"Yash","Mahajan",new DateTime(1993-14-06),Gender.Male,20000,Department.Purchase),
            //    new Employee(3,"Shubham","Kolhe",new DateTime(1996-20-04),Gender.Male,20000,Department.Development),
            //    new Employee(5,"Nikita","Bhole",new DateTime(1997-08-12),Gender.Female,20000,Department.Quality),
            //    new Employee(4,"Bhuvan","Kolhe",new DateTime(2000-10-26),Gender.Male,20000,Department.Purchase),
            //    new Employee(7,"Dheeraj","Khole",new DateTime(1994-09-18),Gender.Male,20000,Department.Quality),
            //    new Employee(6,"Yogu","Kolhe",new DateTime(1998-08-16),Gender.Female,20000,Department.Sales),
            //};
            Console.WriteLine("***Getting department wise employee names");
            Dictionary<Department, List<string>> departmentWiseEmployeeNames = Employee.getDepartmentWiseEmployeeName(employeeList);
            foreach (KeyValuePair<Department, List<string>> entry in departmentWiseEmployeeNames)
            {
                Console.WriteLine(entry.Key + " : ");
                foreach (string names in entry.Value)
                    Console.WriteLine(names);
            }

            Console.WriteLine("***Getting Employee details using name");
            string name= "No valid input";
            while (name== "No valid input")
            {
                Console.WriteLine("Enter first name of employee to find details");
                name= Console.ReadLine() ?? "No valid input";
            }
            var employeeByName = employeeList.MyWhere(emp => emp.FirstName == name);
            Console.WriteLine(employeeByName.Count);
            if (employeeByName.Any())
            {
                foreach (Employee employee in employeeByName)
                {
                    Console.WriteLine(employee.ToString());
                }
            }
            else
                Console.WriteLine("No employee record found with given name");

            Console.WriteLine("***Getting Employees having age greater than given age");
            Console.WriteLine("Enter age to find employees");
            double age = Convert.ToDouble(Console.ReadLine());
            List<Employee> employeeWithAgeAboveGivenAge = employeeList.MyWhere(emp => emp.Age > age);
            foreach (Employee employee in employeeWithAgeAboveGivenAge)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.WriteLine("***Getting Employees Sorted on basis of names");
            List<Employee> SortedEmployeeListOnBasisOfNames = GetEmployeeOrderedByName(employeeList);
            foreach (Employee employee in SortedEmployeeListOnBasisOfNames)
            {
                Console.WriteLine(employee.ToString());
            }

            EmployeeRepository evaluate = new EmployeeRepository(employeeList);
            evaluate.DisplayEmployeeAvailabilityPercentage();

            Console.WriteLine("***Deleting employee record by name");
            Console.WriteLine("Enter first name of employee to delete record");
            string deleteName = Console.ReadLine() ?? "No valid input";
            int numberOfRecordDeleted = GetEmployeeListByDeletingDesiredRecord(employeeList, deleteName);
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine($"Percentage after deleting {numberOfRecordDeleted} records: ");
            evaluate.DisplayEmployeeAvailabilityPercentage();

        }

        private static int GetEmployeeListByDeletingDesiredRecord(List<Employee> employeeList, string deleteName)
        {
            int NumberOfDeletedRecords = employeeList.RemoveAll(employee => employee.FirstName.ToLower() == deleteName.ToLower());
            return NumberOfDeletedRecords;
        }

        public static List<Employee> GetEmployeeDetailsFromUser()
        {
            List<Employee> employeeList = new List<Employee>();
            Console.WriteLine("Enter Employee details");
            char choice = 'c';
            while (choice == 'c')
            {
                Guid id= Guid.NewGuid();
                try
                {
                    Console.WriteLine("Enter Employee first Name");
                    string firstName = Console.ReadLine()??"Please enter valid firstName";
                    Console.WriteLine("Enter Employee Last Name");
                    string lastName = Console.ReadLine() ?? "Please enter valid firstName";
                    Console.WriteLine("Enter Employee Birth Date in yyyy,mm,dd format");
                    DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                    Gender gender = new Gender();
                    while (gender != Gender.Female && gender != Gender.Male)
                    {
                        try
                        {
                            Console.WriteLine("Enter Employee Gender:Female / Male");
                            string genderType = Console.ReadLine()??"Please enter valid gender";
                            gender = (Gender)Enum.Parse(typeof(Gender), genderType);
                        }
                        catch
                        {
                            Console.WriteLine("Gender can be entered as Male and Female only");
                            continue;
                        }
                    }
                    Console.WriteLine("Enter Employee Salary");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Employee department Name: *Development *Quality *Purchase *Sales");
                    Department department = new Department();
                    while (!Enum.IsDefined(typeof(Department), department))
                        try
                        {
                        
                            department = (Department)Enum.Parse(typeof(Department), Console.ReadLine() ?? "Invalid department name");
                        }
                        catch 
                        {
                            Console.WriteLine("Please enter valid department Name- *Development *Quality *Purchase *Sales");
                        }
                    employeeList.Add(new Employee(id, firstName, lastName, birthDate, gender, salary, department));
                    Console.WriteLine("Press c to continue to add more employee details and q to exit ");
                    choice = Convert.ToChar(Console.ReadLine());
                    if (choice != 'c' & choice != 'q')
                        Console.WriteLine("Invalid Choice");
                }
                catch
                {
                    Console.WriteLine("Enter values in correct format(Id,salary,age-number format & first name,lastname,department name-(Development,Quality,Purchase,Sales)");
                }
            }
            return employeeList;
        }
        public static List<Employee> GetEmployeeWithName(List<Employee> employeeList, string name)
        {
            List<Employee> employeeListWithGivenName = employeeList.Where(employee => employee.FirstName.ToLower() == name.ToLower()).ToList();
            return employeeListWithGivenName;
        }
        public static List<Employee> GetEmployeeByAgeLimit(List<Employee> employeeList, double age)
        {
            List<Employee> employeeWithGivenAgeLimit = employeeList.Where(employee => employee.Age > age).ToList();
            return employeeWithGivenAgeLimit;
        }
        public static List<Employee> GetEmployeeOrderedByName(List<Employee> employeeList)
        {
            List<Employee> employeeListSortedOnNames = employeeList.OrderBy(employee => employee.FirstName).ToList();
            return employeeListSortedOnNames;
        }
        
    }
}
