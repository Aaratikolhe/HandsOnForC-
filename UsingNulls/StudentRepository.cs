namespace UsingNulls
{
    public class StudentRepository
    {
        private List<Student>? studentList;//= new List<Student>();
            //{   new Student(1,"Aarati","Kolhe",26),
            //    new Student(2,"Bhuvan","Kolhe",25),
            //    new Student(3,"Yash","Kolhe",264)
            //};
        private Student noStudent = null;
        public void getAllStudent()
        {
            foreach (var student in studentList)
            {
                Console.WriteLine($"{student.FirstName}, by {student.LastName}");
            }
            Console.WriteLine();
        }
        public ref Student getStudentByIndex(int id)
        {
            //foreach (var student in studentList)
            //{
            //    if (id == student.Id)
            //        return ref student;
            //}
            //return ref null;
            Student student = studentList.ElementAt[id];
            return ref student;

        }
        
    }
}
