// See https://aka.ms/new-console-template for more information
using System;

namespace Part2
{
    class Program
    { 
        static void Main (string[] args)
        {
            Random rand = new Random();
            Boolean found = false;
            do
            {
                int x = rand.Next(1, 6);
                Console.WriteLine("Guess the number that is between 1 and 6 : ");
                int number = int.Parse(Console.ReadLine());
                if (number ==  x)   found = true;
            }while (!found);
            
            Console.WriteLine("Congrats you have guessed the right number");
        }
            
    }
}