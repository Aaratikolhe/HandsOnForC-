namespace FindSubsetArray
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] array = { 9, 4, 7, 1, -2, 6, 5 };
            int[] subsetArray = { 7,1,-2,6,4};
            bool result = FindIfArrayPassedIsSubsetOrNot(array, subsetArray);
            if (result)
                Console.WriteLine("The passed array subset of given array");
            else
                Console.WriteLine("The passed array is not subset of given array");

        }

        private static bool FindIfArrayPassedIsSubsetOrNot(int[] array, int[] subsetArray)
        {
            int i = 0;
            int j = 0;
            while (i < array.Length && j < subsetArray.Length)
            {
                if (array[i] == subsetArray[j])
                {
                    i++;
                    j++;
                    if (j == subsetArray.Length)
                        return true;

                }
                else
                {
                    i = i - j + 1;
                    j = 0;
                }

            }
            return false;

        }
    }
}