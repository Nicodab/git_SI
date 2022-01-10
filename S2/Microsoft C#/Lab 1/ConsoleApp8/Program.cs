// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteTitle();
        }

        static void WriteTitle()
        {
            Console.WriteLine("Type in the title you want to display on the screen : ");
            string title = Console.ReadLine();
            string titleInCap = title.ToUpper();

            char[] characters = new char[titleInCap.Length];
            using (StringReader sr = new StringReader(titleInCap))
            {
                for (int i = 0; i < characters.Length; i++)
                {
                    // Read 1 character from the string into the array.
                    sr.Read(characters, i, 1); // sr.Read(array of char to read to fill, index of the string, count in the string)
                }
            }

            char [] characters2 = new char[(characters.Length*2)+1];
            int indexForCharacters = -1; // On le commence à -1 car il est incrémenté avant 
            for(int i = 0; i < characters2.Length; i++)
            {
                if (i % 2 == 0)
                {
                    characters2[i] = ' ';
                    indexForCharacters++;
                }

                else
                {
                    if (indexForCharacters < characters.Length) characters2[i] = characters[indexForCharacters];
                }
                    
            }

            char [] characters3 = new char[characters.Length];
            for (int i = 0; i < characters3.Length; i++)
            {
                characters3[i]= '-';
            }

            Console.Write(characters3);
            Console.Write(characters2);
            Console.Write(characters3);
        }
    }
}