using TestProblem1.Models;
using TestProblem1.AppConstant;
namespace TestProblem1.ExtensionMethods
{ 
    public static class ExtensionMethod
    {
        public static double CalculatePercentage(this int numberOfEmployee, int totalEmployee)
        {
            double divison = numberOfEmployee / (double)totalEmployee;
            double percentage = divison * 100;
            return percentage;
        }

        public static List<Employee> MyWhere(this List<Employee> list, Func<Employee, bool> myFunction)
        {
            List<Employee> empList = new List<Employee>();
            foreach (Employee emp in list)
            {
                if (myFunction(emp))
                    empList.Add(emp);
            }
            return empList;

        }

        public static int Age(this DateTime birthDate)
        {
            return  DateTime.Today.Year- birthDate.Year;
        }
    }

}
