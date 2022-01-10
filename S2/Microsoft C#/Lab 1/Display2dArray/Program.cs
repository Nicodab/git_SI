using System;

namespace Display2dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            Console.WriteLine("Enter the rows");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the columns");
            int columns = int.Parse(Console.ReadLine());

            int[,] tab = new int[rows,columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    tab[i, j] = counter;
                    counter++;
                }
            }
            display2dArray(tab, rows, columns);

        }

        static void display2dArray(int[,] tab, int ro, int co)
        {
            for (int i = 0; i < ro; i++)
            {
                for (int j = 0; j < co; j++)
                {
                    Console.Write(tab[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}