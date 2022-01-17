using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
     class Boss : Employee
    {
        private double turnover;
        private double percentage;
        private double salary;

       public Boss(string matricule, string birth, string firstname, string lastname, double turn, double percent) : base(matricule, birth, firstname, lastname)
        {
            turnover = turn;
            percentage = percent;

        }

        public override double getSalary()
        {
            salary = turnover*percentage/100; 
            return salary;
        }
        
        public override void ToString()
        {
            Console.WriteLine(FirstName + " " + Lastname + "has a salary of : " + salary);
    
        }
    }
}
