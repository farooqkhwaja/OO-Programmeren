using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class CourseResult
    {
        private string name;
        public string Name { get { return name; } }
        public byte Result { get; set; }

        public CourseResult(string name, byte result)
        {
            this.name = name;
            Result = result;
        }

    }
}
