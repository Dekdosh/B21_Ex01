using System;

namespace B21_Ex01_3
{
    /// <summary> This program prints an hourglass shape of stars according to a size given by the user </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            int numOfLines = getInputFromUser();

            changeNumberToOdd(ref numOfLines);
            B21_Ex01_2.Program.Hourglass(numOfLines, 0);
        }

        /// <summary> Get a number of lines from the user for the sand machine. checks if input is valid. </summary>
        /// <returns> Input number of lines from the user. </returns>
        private static int getInputFromUser()
        {
            string userInput;
            int numOfLines;

            do
            {
                Console.WriteLine("Please enter the number of lines for the sand machine:");
                userInput = Console.ReadLine();
            }
            while (!int.TryParse(userInput, out numOfLines));

            return numOfLines;
        }

        /// <summary> If given number is even then add one </summary>
        /// <param name="io_number"> The given number to check. </param>
        private static void changeNumberToOdd(ref int io_number)
        {
            if (io_number % 2 == 0)
            {
                io_number++;
            }
        }
    }
}
