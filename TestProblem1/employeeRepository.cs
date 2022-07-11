namespace TestProblem1
{
    public class EmployeeRepository
    {
        List<Employee> employeesList;

        private int totalEmployee;

        public int TotalEmployee
        {
            get { return employeesList.Count; }
        }

        private double femaleEmployeePercentage;

        public double FemaleEmployeePercentage
        {
            get 
            {
                int femaleEmployee = employeesList.Where(employee => employee.Gender == Gender.Female).Count();
                femaleEmployeePercentage = femaleEmployee.CalculatePercentage(TotalEmployee);
                return femaleEmployeePercentage;
            }
        }
        private double maleEmployeePercentage;

        public double MaleEmployeePercentage
        {
            get 
            {
                int maleEmployee = employeesList.Where(employee => employee.Gender == Gender.Male).Count();
                maleEmployeePercentage =maleEmployee.CalculatePercentage(TotalEmployee);
                return maleEmployeePercentage;
            }
        }
        public EmployeeRepository(List<Employee> employeesList)
        {
            this.employeesList = employeesList;
        }

        public void DisplayEmployeeAvailabilityPercentage()
        {
            Console.WriteLine($"Total Employees = {TotalEmployee}");
            Console.WriteLine($"Total Male Employees percentage = {MaleEmployeePercentage.ToString("n2")}");
            Console.WriteLine($"Total Female Employees percentage = {FemaleEmployeePercentage.ToString("n2")}");
        }
    }
}    
