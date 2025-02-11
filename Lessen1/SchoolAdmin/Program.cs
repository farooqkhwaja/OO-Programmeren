namespace SchoolAdmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        
        private static void DemoStudents()
        {
            Student said = new Student();
            Student mieke = new Student();

            said.Name = "Said Aziz";
            said.Birthdate = new DateTime(2000, 6, 1);
            said.RegisterCourseResult("Programmeren",15); 
            said.RegisterCourseResult("Databanken",12);


            mieke.Name = "Mieke Vermeulen";
            mieke.Birthdate = new DateTime(1998, 1, 1);
            mieke.RegisterCourseResult("Communicatie",13);

            Console.WriteLine(said.GenerateNameCard());
            Console.WriteLine(said.DetermineWorkload());
        }
        }

        public static void DemoCourses()
        {
            Student aziz = new Student();
            aziz.Name = "SaidAziz";
            aziz.Birthdate = new DateTime(2000, 6, 1);
            List<Course> courses = new List<Course>();

            Course programmeren = new Course();
            programmeren.Title = "programmeren";
            Course databanken = new Course();
            databanken.Title = "databanken";

            programmeren.Students.Add(aziz);
            courses.Add(programmeren);

            programmeren.ShowOverview();
         
            //CourseResult result = new CourseResult()
        }
    }
}
