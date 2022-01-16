using System;

namespace Delegation
{
    class Program
    {
        public delegate void AvgChanged(double avg);
        static void Main(string[] args)
        {
            Student student = new Student("Chamson Yanis", 17, 7);
            Prof p = new Prof(student, "Soltani Roozbeh");
            Registrar r = new Registrar(student, "Donald Trump");
            AvgChanged avgChanged = new AvgChanged(student.recordGrade);
            avgChanged += p.report;
            avgChanged += r.report;

            avgChanged.Invoke(student.getAverage());

            avgChanged -= r.report;
            avgChanged.Invoke(student.getAverage());

            /* !!!!!!!!!!!!!!!!!!!!!! The delegation works here !!!!!!!!!!!!!!
            Console.WriteLine(student.getAverage());
            avgChanged(20);
            Console.WriteLine(student.getAverage());
            */
        }
    }
}