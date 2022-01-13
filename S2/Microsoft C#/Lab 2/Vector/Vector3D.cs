using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Vector3D : Vector2D
    {
        private int z;
        // 
        public Vector3D() : base()
        {
            this.z = 0;
        }
        // Parametized
        public Vector3D (int x, int y, int z) : base (x, y)
        {
            this.z = z;
        }
        // Copy
        public Vector3D (Vector3D v3D) : base(v3D.x, v3D.y)
        {
            z = v3D.z;
        }

        // Nb of total vectors
        public int get_nb_vector()
        {
            return nb_vectors;
        }

        // Setter
        public void setCoords(int _x, int _y, int _z)
        {
            // From the parent
            setCoords(_x, _y);
            // For the child
            z = _z;
        }

        public string ToString()
        {
            string str = "This is a 3D Vector with x: " + x + " and " + " y: " + y + " z : " + z;
            return str;
        }

        public Boolean equal(Vector3D v)
        {
            return (x == v.x) && (y == v.y) && (z == v.z);
        }

        public double norme()
        {
            double xCarre = x * x;
            double yCarre = y * y;
            double zCarre = z * z;
            double norm = Math.Sqrt(xCarre + yCarre + zCarre);
            return norm;
        }
    }
}
