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
        public static double CalculatePercentage(this int total, double femalePercentage,double malePercentage)
        {
            double percentage =  femalePercentage+malePercentage;
            return percentage;
        }
    }
}
