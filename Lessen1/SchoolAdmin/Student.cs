using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class Student
    {
        public string Name;
        public DateTime Birthdate;
        public uint Studentnumber;
        public List<CourseResult> courseResult = new List<CourseResult>();
        public uint Studentcounter = 1;

        public string GenerateNameCard()
        {
            return $"{Name} (STUDENT)";
        }
        public byte DetermineWorkload()
        {
            byte counter = 0;
            foreach (var item in courseResult)
            {
                counter += 10;
            }
            return counter;

        }
        public void RegisterCourseResult(string course, byte result)
        {
            CourseResult courseresult = new CourseResult();

            if(result > 20)
            {
                Console.WriteLine("Ongeldig cijfer!");
            }
            else
            {
                CourseResult itemToAdd = new CourseResult();
                itemToAdd.Name = course;
                itemToAdd.Result = result;

                courseResult.Add(itemToAdd);

            }
           
            // method 2

            //bool isFound = false;
            //foreach (var item in courseResult)
            //{
            //    if (item.Name == course)
            //    {
            //        isFound = true;
            //    }
            //}
            //if (isFound)
            //{
            //    Console.WriteLine("Deze course bestaat niet");
            //}
            //else
            //{
            //    CourseResult itemToAdd = new CourseResult();
            //    itemToAdd.Name = course;
            //    itemToAdd.Result = result;

            //    courseResult.Add(itemToAdd);
            //}

        }

    }
}
