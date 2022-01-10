using System;


/// <summary>
///  JARRIVE PAS LE TRIANGLE DE PASCALE CEST TROP DURE A GERER LE REMPLISSAGE DU TABLEAU 2D
/// </summary>
namespace pascalTriangle
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Size of Pascal Triangle? ");
                int size = int.Parse(Console.ReadLine());
                int [,] pascaltriangle = new int[size,size]; // 2D of size rows & colmuns
                int zeroRow = 0;
                int zeroCol = 1;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        //Console.WriteLine("TRACE : (" + i + "," + j + ")");
                        if (j == 0) pascaltriangle[i, j] = 1;
                        else if (i == zeroRow && j == zeroCol)
                        {
                            zeroRow++;
                            zeroCol++;
                            pascaltriangle[i, j] = 0;
                        }
                        else if (i == 0) pascaltriangle[i, j] = 0;
                        else
                        {
                            pascaltriangle[i, j] = pascaltriangle[i - 1, j] + pascaltriangle[i, j - 1];
                        }
                    }
                }

                display2dArray(pascaltriangle, size);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        static void display2dArray(int[,] tab, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(tab[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}