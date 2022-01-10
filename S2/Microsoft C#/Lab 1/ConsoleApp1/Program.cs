// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Price? ");
                string price = Console.ReadLine();
                int pr = int.Parse(price);

                Console.WriteLine("Paid? ");
                string paid = Console.ReadLine();
                int pa = int.Parse(paid);

                int change = pa - pr;
                if (change < 0) Console.WriteLine("Not enough...");
                else if (change == 0) Console.WriteLine("No change ");
                else
                {
                    int[] array = { 100, 50, 20, 10, 5, 2, 1 };
                    
                    List<int> bills = new List<int>();
                    bool exactAmount = false;
                    int amount = 0;
                    int index = 0;
                    do {
                        // Si c'est + grand grand que ce qu'il reste à payer
                        if (array[index] > change - amount)
                        {
                            if (index < array.Length - 1) index++;
                            
                        }
                        else
                        {
                            if (array[index] == change - amount)
                            {
                                bills.Add(array[index]);
                                amount += array[index];
                                
                            }
                            else{
                                bills.Add(array[index]);
                                amount += array[index];
                            }

                            if (amount == change) exactAmount = true;
                        }
                    }while(!exactAmount);
                
                    Console.WriteLine("Your change is " + change);
                    Console.WriteLine(String.Join(",", bills.ToArray()) );    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "\nPlease enter a number");
            }
            
            Console.ReadKey();
        }
    }
}

