// See https://aka.ms/new-console-template for more information
using System;

namespace Part2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the index of the fibonacci term");
            int rang = int.Parse(Console.ReadLine());
            
            Console.WriteLine(fibonacci(rang));
        }

        // Fibonacci
        // --> 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55
        static int fibonacci(int n)
        {

            if (n == 0) throw new ArgumentException("Fibonacci function is not defined for " + n);
            if (n == 1 || n == 2)    return 1;

            else
                return fibonacci(n - 2) + fibonacci(n - 1);
        }
    }
}