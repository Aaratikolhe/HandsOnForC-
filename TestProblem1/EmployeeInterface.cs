using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProblem1.Models;

namespace TestProblem1
{
    public interface IEmployee
    {
        public List<Employee> GetEmployeeDetailsFromUser();

    }
}
