namespace TestProblem1
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
            double divison = (double)numberOfEmployee / (double)totalEmployee;
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

            //public static bool Func(Employee emp)
            //{
            //    if
            //}
        }
   
}
