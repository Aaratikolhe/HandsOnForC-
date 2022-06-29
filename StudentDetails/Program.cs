namespace StudentDetails
{
    class program
    {
        public static void Main(string[] args)
        {
            Student Ram = new Student(1, "Ram", 16, new Marks(88, 77, 66, 55, 85));
            Console.WriteLine("Total Marks of Ram= " + Ram.Marks.CalculateTotalMarks());

            List<Student> studentList = new List<Student>();
            studentList.Add(Ram);
            studentList.Add(new Student(2, "Seeta",15, new Marks(88, 77, 66, 55, 85)));
            studentList.Add(new Student(2, "Geeta",16, new Marks(58, 77, 76, 55, 75)));
            studentList.Add(new Student(3, "Tom",14, new Marks(86, 75, 69, 75, 79)));
            studentList.Add(new Student(4, "Tina",13, new Marks(74, 77, 66, 55, 85)));

            //string choice="continue";
            //while(choice!="quit")
            //{
            //    Console.WriteLine("Enter the ID of student");
            //    int id = Convert.ToInt32(Console.ReadLine());
            //    var nameList = studentList.Where(student => student.Id == id);
            //    foreach(var name in nameList)
            //         Console.WriteLine($"Name of student of ID number {id} is: " + name.Name);
            //    Console.WriteLine($"Enter 1 to continue and quit to exit");
            //    choice=Console.ReadLine();
            //}
            string choiceToContinueOrExit = "continue";
            while (choiceToContinueOrExit != "quit")
            {
                Console.WriteLine("Enter the ID of student");
                int id = Convert.ToInt32(Console.ReadLine());
                var studentListWithGivenID = studentList.Where(student => student.Id == id);
                if(studentListWithGivenID.Any())
                {
                    Console.WriteLine("*****Menu*****");
                    Console.WriteLine("Enter 1 to find age");
                    Console.WriteLine("Enter 2 to find Name");
                    Console.WriteLine("Enter 3 to find Marks");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                if (studentListWithGivenID.Any())
                                {
                                    foreach (var student in studentListWithGivenID)
                                        Console.WriteLine($"Age of student of ID number {id} is: " + student.Age);
                                }
                                else
                                    Console.WriteLine($"There is no student with id number {id} ");
                                break;
                            }
                        case 2:
                            {
                                if (studentListWithGivenID.Any())
                                {
                                    foreach (var student in studentListWithGivenID)
                                        Console.WriteLine($"Name of student of ID number {id} is: " + student.Name);
                                }
                                else
                                    Console.WriteLine($"There is no student with id number {id} ");
                                break;
                            }
                        case 3:
                            {
                                if (studentListWithGivenID.Any())
                                {
                                    foreach (var student in studentListWithGivenID)
                                    {
                                        Console.WriteLine($"History Marks of student of ID number {id} is: " + student.Marks.HistoryMarks);
                                        Console.WriteLine($"Physics Marks of student of ID number {id} is: " + student.Marks.PhysicsMarks);
                                        Console.WriteLine($"Science Marks of student of ID number {id} is: " + student.Marks.ScienceMarks);
                                        Console.WriteLine($"Maths Marks of student of ID number {id} is: " + student.Marks.MathsMarks);
                                        Console.WriteLine($"Geography Marks of student of ID number {id} is: " + student.Marks.GeographyMarks);
                                        Console.WriteLine("***************");
                                    }
                                }
                                else
                                    Console.WriteLine($"There is no student with id number {id} ");
                                break;
                            }
                        default:
                            {
                                if (studentListWithGivenID.Any())
                                {
                                    foreach (var student in studentListWithGivenID)
                                        Console.WriteLine($"Name of student of ID number {id} is: " + student.Name);
                                }
                                else
                                    Console.WriteLine($"There is no student with id number {id} ");
                                break;
                            }
                    }
                }
                else
                    Console.WriteLine($"There is no student with id number {id} ");
                Console.WriteLine($"Enter 1 to continue and quit to exit");
                choiceToContinueOrExit = Console.ReadLine();
            }
        }
    }
}