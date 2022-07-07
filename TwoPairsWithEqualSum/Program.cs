namespace TwoPairsWithEqualSum
{
    class program
    {
        public static Dictionary<int, List<Pair>> FindPairsWithSameSum(int[] array)
        {
            int sum = 0;
            Dictionary<int, List<Pair>> map = new Dictionary<int, List<Pair>>();
           
            for (int i = 0; i < array.Length - 1; i++)
            {
                sum = array[i] + array[i+1];
                List<Pair> pairList = new List<Pair>();
                if (!map.ContainsKey(sum))
                {
                    pairList.Add(new Pair(array[i], array[i + 1]));
                    map.Add(sum, pairList);
                }
                    
                for (int j = i + 1; j < array.Length-1; j++)
                {
                    sum = array[j] + array[j+1];
                    Pair pair = new Pair(array[j], array[j+1]);
                    if (map.ContainsKey(sum) && map[sum].Count<2)
                    {
                        pairList.Add(pair);
                        map[sum] = pairList;
                    }
                    
                }                             
            }
        return map;
        }
        public static void Main(string[] args)
        {
            int[] array = { 10,5,3, 2, 8, 9, 4, 11, 6, 9 ,1,4};
            Dictionary<int, List<Pair>> equalSumPairs = FindPairsWithSameSum(array);
            foreach (var item in equalSumPairs)
            {
                Console.WriteLine(item.Key + " : ");
                item.Value.ForEach(Console.WriteLine);
            }
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
