using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab2_1
{
    class Worker : Employee
    {
        private double Entrydate;
        public const double SMIG = 2500;
        private double salary;

        public Worker(string matricule, string birth, string firstname, string lastname,double entry) : base(matricule,birth,firstname,lastname)
        {
           Entrydate = entry;
        }

        public override double getSalary()
        {
            double currentDate = DateTime.Now.Year;
            double seniority = currentDate - Entrydate;
            salary = SMIG + seniority * 100;
            return salary;

        }

        public override void ToString()
        {
            
        }

       
    }
}
