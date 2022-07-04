using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPairsWithEqualSum
{
    public class ProgramClass
    {
        public static void Main(string[] args)
        {
            int[] array = { 3, 2, 8, 9, 4, 11, 6, 9 };
            FindPairsWithSameSum(array);
        }

        private static void FindPairsWithSameSum(int[] array)
        {
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 0; i < array.Length-1; i++)
            {
                
                    sum1 = array[i] + array[i + 1];
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        sum2 = array[i] + array[j];
                    }
                    if(sum1==sum2)
                {
                    Console.WriteLine(array[i]+ array[j]));
                }
                
                
            }
        }
    }
}
