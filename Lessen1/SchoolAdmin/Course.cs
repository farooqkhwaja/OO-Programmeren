using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Course
    {
        public int id;
        public string Title { get; set; }
        public List<Student> Students { get; set; }
        public byte CreditPoints { get; set; }
        public int MaxId { get; set; }
        public int Id { get { return id; } } 
        public List<Course> AllCourses { get; set; }


        public Course(string title, List<Student> students, byte creditPoints)
        {
            Title = title;
            Students = students;
            CreditPoints = creditPoints;
            id = MaxId++;
            AllCourses.Add(this);
        }

        public Course(string title, List<Student> students) : this(title, students, 3) { }

        public Course(string title) : this(title, new List<Student>()) { }

        public void ShowOverview()
        {
            Console.WriteLine($"{Title} ({Id}) ({CreditPoints})");

            foreach (var student in Students)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();
        }
    }
}
