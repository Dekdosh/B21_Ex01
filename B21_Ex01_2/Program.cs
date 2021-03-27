using System;

namespace B21_Ex01_2
{
    /// <summary> This program prints an hourglass shape of 5 lines </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Hourglass(5, 0);
        }

        /// <summary> Prints an hourglass shape with a given number of lines </summary>
        /// <param name="i_numOfLines"> The given number lines for the hourglass. </param>
        /// <param name="i_counterOfSpaces"> A counter for the spaces at the beginning of each line. </param>
        public static void Hourglass(int i_numOfLines, int i_counterOfSpaces)
        {
            if(i_numOfLines > 1)
            {
                printCharsRecursively(i_counterOfSpaces, ' ');
                printCharsRecursively(i_numOfLines, '*');
                Console.WriteLine();
                Hourglass(i_numOfLines - 2, i_counterOfSpaces + 1);
            }

            printCharsRecursively(i_counterOfSpaces, ' ');
            printCharsRecursively(i_numOfLines, '*');
            Console.WriteLine();
        }

        /// <summary> Prints a given char a given number of times. </summary>
        /// <param name="i_numOfCharPrints"> The number of prints for the char. </param>
        /// <param name="i_charToPrint"> The char to print. </param>
        private static void printCharsRecursively(int i_numOfCharPrints, char i_charToPrint)
        {
            if (i_numOfCharPrints > 0)
            {
                Console.Write(i_charToPrint);
                printCharsRecursively(i_numOfCharPrints - 1, i_charToPrint);
            } 
        }
    }
}
