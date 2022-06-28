namespace RemoveDuplicateFromString
{
    class Program
    {
        //public static void Main(string[] args)
        //{
        //    string str = "Welcome to the World";
        //    int count = 0;
        //    IEnumerable<char> distinctChar = RemoveDuplicateElement(str);
        //    foreach(char c in distinctChar)
        //        Console.WriteLine(c);

        //}
        //public static IEnumerable<char> RemoveDuplicateElement(string str)
        //{
        //    var str2 = str.Distinct();
        //    return str2;
        //}
        
        public static void Main(string[] args)
        {
            string str = "  Welcome to the World";
            int count = 0;
            string distinctCharString = RemoveDuplicateElement(str);
            Console.WriteLine(distinctCharString);

        }
        public static string RemoveDuplicateElement(string str)
        {
            string newString="";
            for(int i=0;i<str.Length;i++)
            {
                if(!newString.Contains(str[i]))
                {
                    newString+=str[i];
                }
            }

            return newString.Trim();
        }

    }
}
