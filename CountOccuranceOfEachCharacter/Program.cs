namespace CountOccuranceOfEachCharacter
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "Welcome";
            int count=0;
            var str2 = str.Distinct();
            foreach (char ch in str2)
            {
                count = CalculateOccuranceOfEachCharacter(str, ch);
                
                Console.WriteLine($"Occurance of character {ch} = " + count);
            }
        }
        public static int CalculateOccuranceOfEachCharacter(string str, char ch)
        {
            int count = 0;
            string copyString = str;
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == ch)
                {
                    count++;
                }

            }

            return count;
        }
    }
}
