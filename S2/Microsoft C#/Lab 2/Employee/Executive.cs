using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
     class Executive : Employee
    {
        private int index;
        private double salary;

        public Executive(string matricule, string birth, string firstname, string lastname, int ind) : base(matricule, birth, firstname, lastname)
        {
            index = ind;


        }


        public override double getSalary()
        {
            if (index == 1)
                salary = 13000;
            if (index == 2)
                salary = 15000;
            if (index == 3)
                salary = -17000;
            if (index == 4)
                salary = 20000;
            return salary;
                    
        }

        public override void ToString()
        {
            Console.WriteLine(FirstName + " " + Lastname + "has a salary of : " + salary);

        }
    }
}
