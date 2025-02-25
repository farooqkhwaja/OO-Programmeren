namespace SchoolAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ReadTextFormatStudent();
            Console.WriteLine("Wat wil je doen? ");
            Console.WriteLine("1. DemonstreerStudenten uitvoeren");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    DemoStudents();
                    break;
                default:
                    break;
            }


        }
     
        public static void ReadTextFormatStudent()
        {
            Console.WriteLine("Geef de tekstvoorstelling van 1 student in CSV-formaat:");
            string input = Console.ReadLine();

            string[] parts = input.Split(';');
            string name = parts[0];

            int day = int.Parse(parts[1]);
            int month = int.Parse(parts[2]);
            int year = int.Parse(parts[3]);
             
            DateTime birthDate = new DateTime(year, month, day);

            Student student = new Student(name, birthDate);

            if (parts.Length > 4)
            {
                string course = "niets";
                byte result = 0;
                
                for (int i = 4; i < parts.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        course = parts[i];
                    }
                    else
                    {
                        result = Convert.ToByte(parts[i]);
                        student.RegisterCourseResult(course, result);

                    }
                }
            }
          

        }
        private static void DemoStudents()
        {
            Student said = new Student("Said Aziz", new DateTime(2000, 6, 1));
            Student mieke = new Student("Mieke Vermeulen", new DateTime(1998, 1, 1));

            said.RegisterCourseResult("Programmeren",15); 
            said.RegisterCourseResult("Databanken",12);
            mieke.RegisterCourseResult("Communicatie",13);

            Console.WriteLine(said.GenerateNameCard());
            Console.WriteLine(said.DetermineWorkload());
        }
        public static void DemoCourses()
        {
            List<Student> students = new List<Student>();

            Student aziz = new Student("SaidAziz", new DateTime(2000, 6, 1));

            List<Course> courses = new List<Course>();

            Course communicatie = new Course("communicatie", students, 6);
            Course programmeren = new Course("programmeren",students);

            courses.Add(programmeren);

            programmeren.ShowOverview();
         
            //CourseResult result = new CourseResult()
        }
    }
}
