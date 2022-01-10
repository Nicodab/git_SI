using System;

namespace DateException
{
    class Progam
    {
        static void Main()
        {
            Boolean ok = true;
            do
            {
                try
                {
                    Console.WriteLine("Enter your Date of Birth :\nDay : ");
                    int day = int.Parse(Console.ReadLine());
                    if (day <= 0 || day > 31) throw new Exception("Invalid date");
                    Console.WriteLine("Month : ");
                    int month = int.Parse(Console.ReadLine());
                    if (month <= 0 || month > 12) throw new Exception("Invalid date");
                    Console.WriteLine("Year : ");
                    int year = int.Parse(Console.ReadLine());
                    if (year <= 1930 || year > 2022) throw new Exception("Invalid date");

                    Console.WriteLine("Date of birth : " + day + " / " + month + " / " + year);
                    ok = false;
                }

                catch (Exception ex)
                { Console.WriteLine("The date is invalid\n"); }
            } while (ok);
        }
    }
}