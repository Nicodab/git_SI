// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice;
            do
            {
                //Boolean bool;
                Console.WriteLine("Choose an option\n");
                Console.WriteLine("I. Inches to Centimeters");
                Console.WriteLine("G. Gallons to Liters");
                Console.WriteLine("M. Miles to Kilometers");
                Console.WriteLine("P. Pound to Kilograms");
                Console.WriteLine("X. Exit");
                choice = char.Parse(Console.ReadLine());
                int val;
                switch (choice)
                {
                    case 'I':
                        Console.WriteLine("Value : ");
                        val = int.Parse(Console.ReadLine());
                        Console.WriteLine(val*2.54);
                        break;
                    case 'G':
                        Console.WriteLine("Value : ");
                        val = int.Parse(Console.ReadLine());
                        Console.WriteLine(val * 4.54);
                        break;
                    case 'M':
                        Console.WriteLine("Value : ");
                        val = int.Parse(Console.ReadLine());
                        Console.WriteLine(val / 1.6);
                        break;
                    case 'P':
                        Console.WriteLine("Value : ");
                        val = int.Parse(Console.ReadLine());
                        Console.WriteLine(val * 0.45);
                        break;
                    default:
                        Console.WriteLine("Please choose from the menu");
                        break;
                }
            } while (choice != 'X');
        }
    }
}
