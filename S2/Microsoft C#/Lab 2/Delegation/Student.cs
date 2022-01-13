using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    public delegate void AvgChanged(double average);
    class Student
    {
        //public int Id { get; set; }

        string fullname;
        double average;
        int courses;

        // Default
        public Student()
        {
            this.fullname = "";
            this.average = 0;
            this.courses = 0;
        }
        // Parametized
        public Student (string fullname, double average, int courses)
        {
            this.fullname = fullname;
            this.average = average;
            this.courses = courses;
        }

        public void recordGrade(double newGrade)
        {
            average = (average * courses + newGrade) / (courses + 1);
        }

        // Getters
        public double getAverage()
        {
            return average;
        }

        public string getName()
        {
            return fullname;
        }

        public int getCourses()
        {
            return courses;
        }

        // Setters


    }
}
