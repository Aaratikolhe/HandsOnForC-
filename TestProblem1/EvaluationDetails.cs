namespace TestProblem1
{
    public class EvaluationDetails
    {
        List<Employee> employeesList;

        public int TotalEmployee { get; set; }
 
        public double FemaleEmployeePercentage { get; set; }

        public double MaleEmployeePercentage{ get; set; }
        public EvaluationDetails(List<Employee> employeesList)
        {
            this.employeesList = employeesList;
            TotalEmployee=employeesList.Count;
            double femaleEmployee = employeesList.Where(employee => employee.Gender == "Female").Count();
            FemaleEmployeePercentage = (femaleEmployee / TotalEmployee) * 100;
            double maleEmployee = employeesList.Where(employee => employee.Gender == "Male").Count();
            MaleEmployeePercentage = (maleEmployee / TotalEmployee) * 100;
        }

        public double calculateEmployeeAvailabilityPercentage()
        {
            double employeeAvailabilityPercentage=TotalEmployee.CalculatePercentage(FemaleEmployeePercentage, MaleEmployeePercentage);
            return employeeAvailabilityPercentage;
        }
    }
}    
