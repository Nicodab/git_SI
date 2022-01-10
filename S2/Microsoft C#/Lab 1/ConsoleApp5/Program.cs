// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the Circle's radius");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose the coordonates x and y :\nx: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("y : ");
            double y = double.Parse(Console.ReadLine());

            double xCarre = Math.Pow(x, 2);
            double yCarre = Math.Pow(y, 2);

            double distance = Math.Sqrt(xCarre + yCarre);

            if (distance < radius) Console.WriteLine("The point is in the circle");
            else if (distance == radius) Console.WriteLine("The point lies on the circle's border");
            else Console.WriteLine("The point is outside of the circle");
        }
    }
}