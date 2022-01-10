// See https://aka.ms/new-console-template for more information

using System;

namespace DateComparison
{
    class Program
    {
        static void Main()
        {
            DateTime depart;
            DateTime arrivee;
            Boolean valid = false;
            do
            {
                DateTime[] dates;
                try
                {
                    dates = departureAndArrival();
                    valid = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!valid);
        }

        public static DateTime[] departureAndArrival()
        {
            Console.WriteLine("Enter the Departure date\n");
            DateTime[] dates = new DateTime [2]; // 0: Departure, 1: Arrival
            int index = 0;
            Console.Write("Departure Date? ");
            dates[index] =  promptDate(); // 0: Departure
            index++;
            Console.Write("Arrival Date? ");
            dates[index] = promptDate(); // 1: Arrival
            if (dates[1] < dates[0]) throw new FormatException("\nArrival must be greater than Departure, please try again...\n\n-----------------------------------------------------\n" );
            return dates;
        }

        // Just to prompt 1 date
        public static DateTime promptDate()
        {
            DateTime ret;
            while (true)
            {
                //Console.Write("Departure Date? ");
                var dte = Console.ReadLine();
                if (DateTime.TryParse(dte, out ret))
                    return ret;
            }
        }
    }
}