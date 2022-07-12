using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProblem1.AppConstant;
namespace TestProblem1.Models
{
    public class Circle
    {
        public double Radius { get;}

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculatePerimeterOfCircle()
        {
            return Constant.pie * 2 * Radius;
        }
    }
}
