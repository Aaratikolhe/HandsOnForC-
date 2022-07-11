using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProblem1
{
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
            double divison = (double)numberOfEmployee / (double)totalEmployee;
            double percentage =divison*100;
            return percentage;
        }

        public static List<Employee> MyWhere(this List<Employee> list, Func<Employee, bool> myFunction)
        {
            bool flag=false;
            List<Employee> empList = new List<Employee>();
            foreach (Employee emp in list)
            {
                if (myFunction(emp))
                    flag=true;
                return flag;
            }
            return empList;
        }
    }
}
