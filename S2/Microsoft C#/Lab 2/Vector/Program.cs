using System;


namespace Lab2
{

    class Program
    {
        static void Main(string[] args)
        {
            Vectors2D ve = new Vectors2D();
            Vectors2D va = new Vectors2D(1, 0);

            Console.WriteLine(ve.ToString());
            Console.WriteLine(va.ToString());
            Console.WriteLine(ve.equal(va));
            Console.WriteLine(va.norme());
        }
    }
}