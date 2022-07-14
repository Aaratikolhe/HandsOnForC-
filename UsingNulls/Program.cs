namespace UsingNulls
{
    class Program
    {
        public static void Main()
        {
            //string message = null;
            //#nullable disable
            string? message = null;
            Console.WriteLine(message);
            Student student = new Student()
            {
                FirstName = "Arti",
                LastName = null
            };
            //Student student = new Student(null,"Kolhe");
            //Student student = new Student("Aarati", null);
            Console.WriteLine(student.FirstName ?? "No value for firstName");
            Console.WriteLine(student.FirstName!.Length);
            Console.WriteLine(student.LastName);
            ExitProgramIfNull(student.LastName, "Last name");

            Console.WriteLine(student.ToUpperName());
        }

        public static void ExitProgramIfNull(string? lastName, string description)
        {
            if(lastName is null)
            {
                Console.WriteLine(description+" is null.Exiting the program...");
                Environment.Exit(0);
            }
        }
    }
}

