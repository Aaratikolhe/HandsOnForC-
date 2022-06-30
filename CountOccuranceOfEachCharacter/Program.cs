namespace CountOccuranceOfEachCharacter
{
    class Program
    {
        public static void Main(string[] args)
        {
            string str = "Wwelcome To India";
            int count=0;
            var str2 = str.ToLower().Distinct();
            foreach (char ch in str2)
            {
                count = CalculateOccuranceOfEachCharacter(str, ch);
                
                Console.WriteLine($"Occurance of character {ch} = " + count);
            }
        }
        public static int CalculateOccuranceOfEachCharacter(string str, char ch)
        {
            int count = 0;
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
