// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> list = new List<int>();
                List<int> mode = new List<int>();
                Console.WriteLine("Enter number of data points: ");
                int input = int.Parse(Console.ReadLine());
                int amount = 0;

                /// Building list
                for (int i = 0; i < input; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    amount += num;
                    list.Add(num);
                }
                Console.WriteLine(String.Join(",", list));
                //list.ForEach(Console.WriteLine); // Same as above
                float mean = amount / (float) input;
                Console.WriteLine("This is the mean : " + mean);

                // If the number of points is even
                if (input %2 == 0)
                {
                    int middle = input / 2; // C'est ok commme une list commence à 0
                    float median = ((float)list[middle-1] + (float) list[middle]) / 2;
                    Console.WriteLine("This is the median : " + median);
                }
                else
                {
                    int middle = input / 2; // C'est ok commme une list commence à 0
                    float median = list[middle];
                    Console.WriteLine("This is the median : " + median);
                }

                Console.WriteLine("This is the mode: ");
                int repetionMax = 0;
                List <int> l = new List<int>();
                for (int i = 0; i<input; i++)
                {
                    int occurrence = 0;
                    for (int j = 0; j < input; j++)
                    {
                        if (list[j] == list[i])
                        {
                            occurrence++;
                        }
                    }
                    if (occurrence >= repetionMax)
                    {
                        repetionMax = occurrence;
                        l.Add(list[i]);
                    }
                }
                List <int> modeList = l.Distinct().ToList();
                Console.WriteLine(String.Join(",", modeList));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
