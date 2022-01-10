// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            getInt("Enter your age : ", 0, 150);
           
        }

        static void getInt(string msg, int min, int max)
        {
            try
            {
                Console.Write(msg);
                int number = int.Parse(Console.ReadLine()); 
                if (number < min) Console.WriteLine("Not valid, you're answer must be no less than 0");
                if (number > max) Console.WriteLine("Not valid, you're answer must be no more than 150");
                else Console.WriteLine(number);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}