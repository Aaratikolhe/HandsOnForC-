namespace StudentDetails
{
    class program
    {
        public static void Main(string[] args)
        {
            Student Ram=new Student(1,"Ram",new Marks(88,77,66,55,85));
            Console.WriteLine("Total Marks of Ram= "+Ram.Marks.CalculateTotalMarks());
        }
    }
}