namespace CreatePatternUsingLoops
{
    class Program
    {
        public static void Main(string[] args)
        {
            //for (int i=0;i<5;i=i+2)
            //{
            //    for (int j=0;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < 5; i = i + 1)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("A");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------");
            for (int i = 0; i < 5; i = i + 1)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write("A");
                }
                Console.WriteLine();
            }

            Console.WriteLine("----------------------");
            char ch = 'A';
            for (int i = 0; i < 5; i = i + 1)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(ch);
                    ch++;
                }

                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for(int k=0;k<(2*i-1);k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
