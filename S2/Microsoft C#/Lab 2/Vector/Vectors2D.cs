using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public  class Vectors2D 
    {

        protected int x;
        protected int y;
        protected static int nb_vectors; 

        // <Default
        public Vectors2D()
        {
            nb_vectors++;
            x = 0;
            y = 0;
        }

        // Parametized
        public Vectors2D(int x, int y)
        {
            nb_vectors++;
            this.x = x;
            this.y = y;
        }
        // Copy 
        public Vectors2D(Vectors2D v)
        {
            nb_vectors++;
            v.x = x;
            v.y = y;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public int get_nb_vector()
        {
            return nb_vectors;
        }





        public void setCoords(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public string ToString()
        {
            string str = "This is a 2D Vector with x: " + x + " and " + " y: " + y;
            return str;
        }

        public Boolean equal(Vectors2D v)
        {
            return x == v.x && y == v.y;
        }

        public double norme ()
        {
            double xCarre = x * x;
            double yCarre = y * y;
            double norm =  Math.Sqrt(xCarre + yCarre);
            return norm;
        }
    }
}
