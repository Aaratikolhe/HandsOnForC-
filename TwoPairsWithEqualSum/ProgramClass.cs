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
            int[] array = { 8, 9, 4, 11, 7, 10, 11, 6 };
            List<Pair> listOfEqualSumPairs=FindPairsWithSameSum(array);
            foreach (Pair pair in listOfEqualSumPairs)
                Console.WriteLine(pair.ToString());
        }

        private static List<Pair> FindPairsWithSameSum(int[] array)
        {
            int sum1 = 0;
            int sum2 = 0;
            int flag = 0;
            List<Pair> pairList = new List<Pair>();
            for (int i = 0; i < array.Length - 1; i++)
            {
                flag = 0;
                sum1 = array[i] + array[i + 1];
                pairList.Add(new Pair(array[i], array[i + 1]));
                for (int j = i + 1; j < array.Length-1; j++)
                {
                    sum2 = array[j] + array[j + 1];

                    if (sum1 == sum2&& !pairList.Contains(new Pair(array[j], array[j + 1])))
                    {
                        pairList.Add(new Pair(array[j], array[j + 1]));
                        flag = 1;
                    }
                    
                }
                if (flag==0)
                {
                    pairList.RemoveAt(pairList.Count - 1);
                }

            }
            return pairList;
            
        }
    }
    class Pair
    {
        public int FirstElement { get; }
        public int SecondElement { get; }

        public Pair(int firstElement, int secondElement)
        {
            FirstElement = firstElement;
            SecondElement = secondElement;
        }
        public override string? ToString()
        {
            return $"( {FirstElement}  {SecondElement} )";
        }
    }
}
