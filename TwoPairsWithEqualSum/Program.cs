namespace TwoPairsWithEqualSum
{
    class program
    {
        public static Dictionary<int,List<Pair>> FindPairsWithSameSum(int[] array)
        {
            int sum = 0;
            Dictionary<int, List<Pair>> map = new Dictionary<int,List<Pair>>();
            List<Pair> pairList = new List<Pair>();
            for (int i = 0; i < array.Length-1; i++)
            {
                int sum1= array[i]+array[i+1];
                for(int j=i+2;j < array.Length-2; j++)
                {
                    if(sum==sum1)
                    {
                        map[sum] = pairList;
                    }
                    sum = array[j] + array[j+1];
                    if (map.ContainsKey(sum))
                    {
                        Pair pair = new Pair(array[i], array[j]);
                        pairList.Add(pair);
                        map[sum] = pairList;
                    }
                        
                    
                }
            }
            //foreach(KeyValuePair(sum,pairList) in map)
            foreach(var item in map)
            {
                Console.WriteLine(item.Key+" : " );
                foreach (var pair in pairList)
                    Console.WriteLine(pair);
            }
            return map;
        }
        public static void Main(string[] args)
        {
            int[] array = { 3, 2, 8, 9, 4, 11, 6, 9 };
            Dictionary<int,List<Pair>> equalSumPairs= FindPairsWithSameSum(array);
            //List<Pair> pairs =
        }
    }
    class Pair
    {
        public int FirstElement { get; }
        public int SecondElement { get; }

        public Pair(int firstElement,int secondElement)
        {
            FirstElement = firstElement;
            SecondElement = secondElement;
        }

        public override string? ToString()
        {
            return $"( {FirstElement}  {SecondElement} )";
        }
    }












//        public static void FindSubsetWithSameSum(int[] array)
//        {
//            int sum1 = 0;
//            int sum2 = 0;
//            List<int> list1 = new List<int>();
//            List<int> list2 = new List<int>();
//            for (int i = 0; i < array.Length - 1; i++)
//            {
//                sum1 = array[i] + array[i + 1];
//                if (i < (array.Length - 1) - 2)
//                {
//                    sum2 = 0;
//                    for (int j = i + 1; j < array.Length - 1; j++)
//                    {
//                        if (sum1 != sum2)
//                        {
//                            sum2 = array[j] + array[j + 1];
//                        }
//                        if (sum1 == sum2)
//                        {
//                            list2.Add(array[j]);
//                            list2.Add(array[j + 1]);

        //                        }
        //                    }
        //                }
        //                if (!list1.Any() && sum1 == sum2)
        //                {
        //                    list1.Add(array[i]);
        //                    list1.Add(array[i + 1]);
        //                }

        //            }

        //            foreach (int items in list1)
        //            {
        //                Console.Write(items + " ");
        //            }
        //            Console.WriteLine();
        //            foreach (int items in list2)
        //            {
        //                Console.Write(items + " ");
        //            }
        //            //List<Array> arrays = new List<Array>();

        //        }

        //        public static void Main(string[] args)
        //        {
        //            int[] array = { 3,2,8,9,4, 11, 6, 9 };
        //            FindSubsetWithSameSum(array);


        //        }
        //    }
        //}
        //        public static List<int> FindSubsetWithSameSum(int[] array)
        //        {
        //            int sum1 = 0;
        //            int sum2 = 0;
        //            List<int> list1 = new List<int>();
        //            for (int i = 0; i < array.Length - 1; i++)
        //            {
        //                sum1 = array[i] + array[i + 1];
        //                if (i < (array.Length - 1) - 2)
        //                {
        //                    sum2 = 0;
        //                    for (int j = i + 1; j < array.Length - 1; j++)
        //                    {
        //                        if (sum1 != sum2)
        //                        {
        //                            sum2 = array[j] + array[j + 1];
        //                        }
        //                        if (sum1 == sum2)
        //                        {
        //                            list1.Add(array[j]);
        //                            list1.Add(array[j + 1]);

        //                        }
        //                    }
        //                }
        //                if (!list1.Any() &&sum1 == sum2)
        //                {
        //                    list1.Add(array[i]);
        //                    list1.Add(array[i + 1]);
        //                }
        //            }
        //            return list1;

        //        }

        //        public static void Main(string[] args)
        //        {
        //            int[] array = { 2, 3, 4, 11, 6, 9 };
        //            List<int> list= FindSubsetWithSameSum(array);
        //            foreach (int items in list)
        //            {
        //                Console.Write(items + " ");
        //            }
        //            for(int i = 0; i < list.Count; i++)
        //            {
        //                Console.Write(list[i]+" ");
        //                if (i % 2 == 0)
        //                    Console.WriteLine();
        //            }

        //        }
    //}
}