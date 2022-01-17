using System ;

namespace lab2_1
{
     abstract  public class Employee
    {
        protected string Matricule;
        protected  string Birth;
        protected string FirstName;
        protected string Lastname ;

        //Constuctor

        public Employee()
        {

        }

        public Employee(string matricule, string birth, string firstname,string lastname)
        {
           Matricule = matricule;
           Birth = birth;
           FirstName = firstname;  
           Lastname = lastname;    
        }

        /// abstract methods
        /// 

       /* public abstract string getMatricule();
     
        public abstract void setMatricule(string mat);
   

        public abstract string getBirth();
       
        public abstract void setBirth(string birth);
     

        public abstract string getFirstName();
        

        public abstract void setFirstName(string firstname);
      

        public abstract string getLastName();
       
        public  abstract void setLastName(string lastname);
        
*/
        public abstract double getSalary();
        
        public abstract  void ToString();



            
    }


}