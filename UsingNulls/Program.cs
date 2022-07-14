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
            //Student student = new Student()
            //{
            //    FirstName = null,
            //    LastName = "Kolhe"
            //};
            //Student student = new Student(null,"Kolhe");
            Student student = new Student("Aarati", "Kolhe");
            Console.WriteLine(student.FirstName ?? "No value for firstName");
            Console.WriteLine(student.FirstName!.Length);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.ToUpperName());
        }
    }
}

