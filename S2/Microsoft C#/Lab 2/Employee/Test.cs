using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    public class Test
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("10101", "05/12/2000", "yanis", "chamson", 2001);
            /*            Console.WriteLine(worker.ToString); erreur 
             *            
             *        
             *            
             *          
            */

            Executive exec1 = new Executive("01011", "05/12/2000", "Yanis", "CHamson", 2);
            double salary = exec1.getSalary();
            Console.WriteLine(salary);  
        }
    }
}
