namespace TestProblem1
{
    public class EvaluationDetails
    {
        List<Employee> employeesList;

        private int totalEmployee;

        public int TotalEmployee 
        { get { return totalEmployee; }
          set
            { 
                totalEmployee = employeesList.Count;
            } }

        private double femaleEmployeePercentage;

        public double FemaleEmployeePercentage
        {
            get { return femaleEmployeePercentage; }
            set
            {
                int femaleEmployee = employeesList.Where(employee => employee.Gender == "Female").Count();
                femaleEmployeePercentage = (femaleEmployee / totalEmployee) * 100;
            }
        }
        private double maleEmployeePercentage;

        public double MaleEmployeePercentage
        {
            get { return maleEmployeePercentage; }
            set
            {
                int femaleEmployee = employeesList.Where(employee => employee.Gender == "Female").Count();
                maleEmployeePercentage = (femaleEmployee / totalEmployee) * 100;
            }
        }
        public EvaluationDetails(List<Employee> employeesList)
        {
            this.employeesList = employeesList;
        }

        public double calculateEmployeeAvailabilityPercentage()
        {
            double employeeAvailabilityPercentage=totalEmployee.CalculatePercentage(femaleEmployeePercentage, maleEmployeePercentage);
            return employeeAvailabilityPercentage;
        }
    }
}    
