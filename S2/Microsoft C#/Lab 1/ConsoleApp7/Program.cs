// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a number");
            try
            {
                int x = int.Parse(Console.ReadLine());
                int result = factoriel(x);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }

            
        }

         static int factoriel(int n)
        {
            int res = 1;

            if (n == 1)
                return res;
                
            else
                //int r = factoriel(n-1);
                res = factoriel(n - 1) * n;

            return res;

        }
    }
}
