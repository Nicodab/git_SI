using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    abstract class Employe
    {
        protected int matricule;
        protected string firstname;
        protected string lastname;
        protected string dateOfBirth;

        /// <summary>
        ///  Bu default nhjedvvedk
        /// </summary>
        public Employe(int mat, string first, string last, string date)
        {
            matricule = mat;
            firstname = first;
            lastname = last;
            dateOfBirth = date;

        }

        public string toString()
        {
            string str = "Employee n° " +  matricule + "\n Firstname: " + firstname + "\nLastname: " + lastname + "\nDate of Birth: " + dateOfBirth;
            return str;
        }
        abstract public int getSalary();
        // Copy 

    }
}