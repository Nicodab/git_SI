using System;


namespace Lab2
{

    class Program
    {
        static void Main(string[] args)
        {
            Vector2D vector2D = new Vector2D();
            Vector3D ve = new Vector3D();
            Vector3D va = new Vector3D(2, 0, 4);
            Vector3D vector3D = new Vector3D(va);

            Console.WriteLine(va.norme());

            /*Console.WriteLine(ve.ToString());
            Console.WriteLine(va.ToString());
            Console.WriteLine(ve.equal(va));
            Console.WriteLine(va.norme());*/
        }
    }
}