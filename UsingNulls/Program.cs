namespace UsingNulls
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter first name");
            string? firstName = Console.ReadLine();
            string? uppercaseFirstName = firstName?.ToUpperInvariant() ?? "first name is null";
            Console.WriteLine($"First Name in upper case:- {uppercaseFirstName} ");
            string lastName = getLastNameFromUser() ?? getLastNameFromUser() ?? "Invalid last name";
            Console.WriteLine($"Full name: {firstName} + {lastName}");
            Console.WriteLine("Enter a number to find if even or odd using Conditional operator");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IdentifyEvenOddNumber(num));

            Console.WriteLine("Using ref keyword");
            int number = 10;
            CalculateFactorial(ref number);
            Console.WriteLine($"Factorial of given number using ref keyword= {number}");

            Console.WriteLine("Using out keyword");
            findAddititionSubtraction(out int firstNumber, out int secondNumber, out int addition, out int subtraction);
            Console.WriteLine("firstNumber Number = " + firstNumber);
            Console.WriteLine("secondNumber Number = " + secondNumber);
            Console.WriteLine("Addition of two Numbers = " + addition);
            Console.WriteLine("Subtraction of two numbers " + subtraction);

            Console.WriteLine("Using ref return keyword");
            //int n = 0;
            //ref int incrementedNumber = ref IncrementGivenNumber(n);
            StudentRepository st = new StudentRepository();
            int index = 1;
            ref var student = ref st.getStudentByIndex(1);
        }
        //public static ref int IncrementGivenNumber(int n)
        //{
        //    int num = n + 10;
        //    return ref num;
        //}

        private static int findAddititionSubtraction(out int firstNumber, out int secondNumber, out int addition, out int subtraction)
        {
            int divison;
            firstNumber = 10;
            secondNumber = 5;
            addition = firstNumber + secondNumber;
            subtraction = firstNumber - secondNumber;
            divison = firstNumber / secondNumber;
            return divison;
        }

        private static void CalculateFactorial(ref int number)
        {
            int limit = number;
            for (int i = 1; i < limit; i++)
            {
                number = number * i;
            }
        }

        public static string getLastNameFromUser()
        {
            Console.WriteLine("enter last name");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public static string IdentifyEvenOddNumber(int num)
        {
            string result = num % 2 == 0 ? "Even number" : "Odd number";
            return result;
        }

    }
}

