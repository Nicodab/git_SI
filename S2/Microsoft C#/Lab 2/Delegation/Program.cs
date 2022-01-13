using System;

namespace Delegation
{
    class Program
    {
        static void Main (string [] args)
        {
            Student student = new Student();
            AvgChanged avgChanged = new AvgChanged(student.recordGrade);

            /* !!!!!!!!!!!!!!!!!!!!!! The delegation works here !!!!!!!!!!!!!!
            Console.WriteLine(student.getAverage());
            avgChanged(20);
            Console.WriteLine(student.getAverage());
            */
        }
    }
}