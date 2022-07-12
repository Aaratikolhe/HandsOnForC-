using TestProblem1.Models;
using TestProblem1.AppConstant;
namespace TestProblem1.ExtensionMethods
{
    //public delegate TResult Func<in T, out TResult>(T arg);
    public static class ExtensionMethod
    {
        //public static double CalculatePercentage(this int total,double mathMarks,double scienceMarks,double englishMarks)
        //{
        //    double percentage = ((mathMarks + scienceMarks + englishMarks) / total) * 100;
        //    return percentage;
        //}
        //public static double CalculatePercentage(this int total, double femalePercentage,double malePercentage)
        //{
        //    double percentage =  femalePercentage+malePercentage;
        //    return percentage;
        //}
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

        public static double CalculateAreaOfCircle(this Circle circle)
        {
            return Constant.pie * circle.Radius * circle.Radius;
        }
        public static int Age(this DateTime birthDate)
        {
            return  DateTime.Today.Year- birthDate.Year;
        }
    }

}
