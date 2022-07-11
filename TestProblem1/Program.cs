namespace TestProblem1
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
           
            List<Employee> employeeList = GetEmployeeDetailsFromUser();
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.WriteLine("***Getting Employee details using name");
            Console.WriteLine("Enter first name of employee to find details");
            string name = Console.ReadLine();
            List<Employee> employeeByName =GetEmployeeWithName(employeeList,name);
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
            List<Employee> employeeWithAgeAboveGivenAge = GetEmployeeByAgeLimit(employeeList,age);
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
            EvaluationDetails evaluate = new EvaluationDetails(employeeList);
            Console.WriteLine(evaluate.calculateEmployeeAvailabilityPercentage());
            
        }
        public static List<Employee> GetEmployeeDetailsFromUser()
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
                    Console.WriteLine("Enter Employee age");
                    double age = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Employee Gender:Female / Male");
                    string gender = Console.ReadLine();
                    Console.WriteLine("Enter Employee Salary");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Employee department Name");
                    string department = Console.ReadLine();
                    employeeDetailsList.Add(new Employee(employeeId, firstName, lastName, age, gender, salary, department));
                    Console.WriteLine("Press c to continue to add more employee details and q to exit ");
                    choice = Convert.ToChar(Console.ReadLine());
                    if (choice != 'c' & choice != 'q')
                        Console.WriteLine("Invalid Choice");
                }
                catch
                {
                    Console.WriteLine("Enter values in correct format(Id,salary,age-number format & first name,lastname,gender,department name-string format ");
                }
               
            }
            return employeeDetailsList;
        }
        public static List<Employee> GetEmployeeWithName(List<Employee> employeeList,string name)
        {
            List<Employee> employeeListWithGivenName = employeeList.Where(employee => employee.EmployeeFirstName.ToLower() == name.ToLower()).ToList();
            return employeeListWithGivenName;
        }
        public static List<Employee> GetEmployeeByAgeLimit(List<Employee> employeeList,double age)
        {
            List<Employee> employeeWithGivenAgeLimit = employeeList.Where(employee => employee.EmployeeAge > age).ToList();
            return employeeWithGivenAgeLimit;
        }
        public static List<Employee> GetEmployeeOrderedByName(List<Employee> employeeList)
        {
            List<Employee> employeeListSortedOnNames = employeeList.OrderBy(employee=>employee.EmployeeFirstName).ToList();
            return employeeListSortedOnNames;
        }
        
    }
}
