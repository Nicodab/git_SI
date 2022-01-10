using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Vector3D : Vectors2D
    {
        private int z;
        public Vector3D (int x, int y, int z) : base (x, y)
        {
            this.z = z;
        }

    }
}
