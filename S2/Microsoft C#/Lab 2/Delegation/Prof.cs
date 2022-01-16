using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    class Prof
    {
        private Student student;
        private string name;

        public Prof()
        {
            student = null;
            name = "no name";
        }

        public Prof(Student student, string name)
        {
            this.student = student;
            this.name = name;
        }

        public void report(double average)
        {
            Console.WriteLine("My name is " + name + " as a prof, I received the new average of Student named " + student.getName() + " successfully");
        }
    }
}