using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    class Registrar
    {
        private Student student;
        private string name;

        public Registrar()
        {
            student = null;
            name = "no name";
        }

        public Registrar(Student student, string name)
        {
            this.student = student;
            this.name = name;
        }

        public void report(double average)
        {
            Console.WriteLine("My name is " + name + " as a registrar, I received the new average of Student named " + student.getName() + " successfully");
        }
    }
}