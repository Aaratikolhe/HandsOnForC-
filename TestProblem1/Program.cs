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

            Console.WriteLine("***Getting department wise employee names");
            Dictionary<Department, List<string>> departmentWiseEmployeeNames = getDepartmentWiseEmployeeName(employeeList);
            foreach (KeyValuePair<Department, List<string>> entry in departmentWiseEmployeeNames)
            {
                Console.WriteLine(entry.Key + " : ");
                foreach (string names in entry.Value)
                    Console.WriteLine(names);
            }

            Console.WriteLine("***Getting Employee details using name");
            Console.WriteLine("Enter first name of employee to find details");
            string name = Console.ReadLine();
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
            string deleteName = Console.ReadLine();
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
                try
                {
                    Console.WriteLine("Enter Employee Id");
                    int id = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine("Enter Employee Salary");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Employee department Name: *Development *Quality *Purchase *Sales");
                    Department department = new Department();
                    department = (Department)Enum.Parse(typeof(Department), Console.ReadLine());

                    while (!Enum.IsDefined(typeof(Department), department))
                    {
                        Console.WriteLine("Please enter valid department Name");
                        department = (Department)Enum.Parse(typeof(Gender), Console.ReadLine());
                    }
                    employeeList.Add(new Employee(id, firstName, lastName, birthDate, gender, salary, department));
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
