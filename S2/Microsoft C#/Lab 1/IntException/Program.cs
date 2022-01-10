using System;

namespace IntException
{
    class Program
    {
        static void Main()
        {
            Boolean  ok = false;

            do
            {
                try
                {
                    Console.WriteLine("Enter an integer : ");
                    int x = int.Parse(Console.ReadLine());
                    ok = true;
                }

                catch (Exception ex)
                { Console.WriteLine("Integer ! "); }

            } while(!ok);
        }
    }
}