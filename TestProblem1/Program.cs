
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
            Circle circle = new Circle(4);
            Console.WriteLine("Perimeter of circle : " + circle.CalculatePerimeterOfCircle());
            Console.WriteLine("Area of circle : " + circle.CalculateAreaOfCircle());
            
            Dictionary<Department, List<Employee>> employeeList = GetEmployeeDetailsFromUser();
            foreach (KeyValuePair<Department, List<Employee>> entry in employeeList)
            {
                Console.WriteLine(entry.Key + " : ");
                foreach (Employee employee in entry.Value)
                    Console.WriteLine(employee.ToString()); 
            }
        }
        //    Console.WriteLine("***Getting Employee details using name");
        //    Console.WriteLine("Enter first name of employee to find details");
        //    string name = Console.ReadLine();
        //    var employeeByName = employeeList.MyWhere(emp => emp.FirstName == name);

        //    Console.WriteLine(employeeByName.Count);
        //    //List<Employee> employeeByName =GetEmployeeWithName(employeeList,name);
        //    if (employeeByName.Any())
        //    {
        //        foreach (Employee employee in employeeByName)
        //        {
        //            Console.WriteLine(employee.ToString());
        //        }
        //    }
        //    else
        //        Console.WriteLine("No employee record found with given name");

        //    Console.WriteLine("***Getting Employees having age greater than given age");
        //    Console.WriteLine("Enter age to find employees");
        //    double age = Convert.ToDouble(Console.ReadLine());
        //    //List<Employee> employeeWithAgeAboveGivenAge = GetEmployeeByAgeLimit(employeeList, age);
        //    List<Employee> employeeWithAgeAboveGivenAge = employeeList.MyWhere(emp => emp.Age > age);
        //    foreach (Employee employee in employeeWithAgeAboveGivenAge)
        //    {
        //        Console.WriteLine(employee.ToString());
        //    }

        //    Console.WriteLine("***Getting Employees Sorted on basis of names");
        //    List<Employee> SortedEmployeeListOnBasisOfNames = GetEmployeeOrderedByName(employeeList);
        //    foreach (Employee employee in SortedEmployeeListOnBasisOfNames)
        //    {
        //        Console.WriteLine(employee.ToString());
        //    }

        //    EmployeeRepository evaluate = new EmployeeRepository(employeeList);
        //    evaluate.DisplayEmployeeAvailabilityPercentage();


        //    Console.WriteLine("***Deleting employee record by name");
        //    Console.WriteLine("Enter first name of employee to delete record");
        //    string deleteName = Console.ReadLine();
        //    int numberOfRecordDeleted = GetEmployeeListByDeletingDesiredRecord(employeeList, deleteName);
        //    foreach (Employee employee in employeeList)
        //    {
        //        Console.WriteLine(employee.ToString());
        //    }
        //    Console.WriteLine($"Percentage after deleting {numberOfRecordDeleted} records: ");
        //    evaluate.DisplayEmployeeAvailabilityPercentage();
        //}

        //private static int GetEmployeeListByDeletingDesiredRecord(List<Employee> employeeList, string deleteName)
        //{
        //    int NumberOfDeletedRecords = employeeList.RemoveAll(employee => employee.FirstName.ToLower() == deleteName.ToLower());
        //    return NumberOfDeletedRecords;
        //}

        public static Dictionary<Department,List<Employee>> GetEmployeeDetailsFromUser()
        {
            Dictionary<Department,List<Employee>> result = new Dictionary<Department,List<Employee>>();
            List<Employee> employeeDetailsList ;
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
                    //double age = birthDate.Age();
                    Console.WriteLine("Enter Employee Salary");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Employee department Name: *Development *Quality *Purchase *Sales");
                    Department department = new Department();
                    department = (Department)Enum.Parse(typeof(Department), Console.ReadLine()) ;
                    
                    while (!Enum.IsDefined(typeof(Department), department))
                    {
                        Console.WriteLine("Please enter valid department Name");
                        department =(Department)Enum.Parse(typeof(Gender), Console.ReadLine());
                    }
                    
                    if (result.ContainsKey(department))
                    {
                        
                        result[department].Add(new Employee(employeeId, firstName, lastName, birthDate, gender, salary));
                        //result[department] = employeeDetailsList;
                    }
                    else
                    {
                        employeeDetailsList = new List<Employee>();
                        employeeDetailsList.Add(new Employee(employeeId, firstName, lastName, birthDate, gender, salary));
                        result.Add(department, employeeDetailsList);
                    }
                    
                    
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
            return result;
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
