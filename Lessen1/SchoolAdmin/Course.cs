using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Course
    {
        public string Title;
        public List<Student> Students;

        public void ShowOverview()
        {
            Console.WriteLine(Title);

            foreach (var student in Students)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine();
        }
    }
}
