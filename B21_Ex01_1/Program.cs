using System;

namespace B21_Ex01_1
{
    /// <summary> This program gets three binary number from the user, then prints them in decimal.
    /// also checks other parameters related to the numbers and prints the data. </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            string number1, number2, number3;

            getBinaryNumbersFromUser(out number1, out number2, out number3);
            printDecimalNumbers(number1, number2, number3);
            printAverageDigitsOfNumbers(number1, number2, number3);
            printAmountPowerOfTwoNumbers(number1, number2, number3);

            int decimalNumber1 = convertBinaryToDecimal(number1);
            int decimalNumber2 = convertBinaryToDecimal(number2);
            int decimalNumber3 = convertBinaryToDecimal(number3);

            printAmountAscendingSeries(decimalNumber1, decimalNumber2, decimalNumber3);
            printBiggestNumbers(decimalNumber1, decimalNumber2, decimalNumber3);
            printSmallestNumbers(decimalNumber1, decimalNumber2, decimalNumber3);
        }

        /// <summary> Getting three binary numbers from the user. Checks if input is valid. </summary>
        /// <param name="o_number1"> The first number from the user. </param>
        /// <param name="o_number2"> The second number from the user. </param>
        /// <param name="o_number3"> The third number from the user. </param>
        private static void getBinaryNumbersFromUser(out string o_number1, out string o_number2, out string o_number3)
        {
            Console.WriteLine("Please enter three binary numbers:");
            getSingleInputFromUser(out o_number1);
            getSingleInputFromUser(out o_number2);
            getSingleInputFromUser(out o_number3);
        }

        /// <summary> Getting a single input of binary number from the user. Checks if input is valid. </summary>
        /// <param name="o_number"> The input number from the user. </param>
        private static void getSingleInputFromUser(out string o_number)
        {
            string input;

            do
            {
                input = Console.ReadLine();
            }
            while (!checkIfStringIsValid(input));

            o_number = input;
        }

        /// <summary> Checks if given string is 7 characters long and that is a binary number. </summary>
        /// <param name="i_string"> The string that is being tested. </param>
        /// <returns> True if string is valid, false is not. </returns>
        private static bool checkIfStringIsValid(string i_string)
        {
            if(i_string.Length != 7)
            {
                Console.WriteLine("Wrong input! Please enter a binary number:");

                return false;
            }

            for (int i = 0; i < i_string.Length; i++)
            {
                if (i_string[i] != '1' && i_string[i] != '0')
                {
                    Console.WriteLine("Wrong input! Please enter a binary number:");

                    return false;
                }
            }

            return true;
        }

        /// <summary> Converts three binary numbers to decimal, then prints them. </summary>
        /// <param name="i_number1"> The first binary number. </param>
        /// <param name="i_number2"> The second binary number. </param>
        /// <param name="i_number3"> The third binary number. </param>
        private static void printDecimalNumbers(string i_number1, string i_number2, string i_number3)
        {
            Console.WriteLine("The Decimal numbers are:");
            Console.WriteLine(convertBinaryToDecimal(i_number1));
            Console.WriteLine(convertBinaryToDecimal(i_number2));
            Console.WriteLine(convertBinaryToDecimal(i_number3));
        }

        /// <summary> Converts a binary number to decimal and returns it. </summary>
        /// <param name="i_binaryNum"> The binary number to convert. </param>
        /// <returns> Returns the converted decimal number. </returns>
        private static int convertBinaryToDecimal(string i_binaryNum)
        {
            int sum = 0;

            for (int i = 0; i < i_binaryNum.Length; i++)
            {
                if(i_binaryNum[i] == '1')
                {
                    if(i == i_binaryNum.Length - 1)
                    {
                        sum++;
                    }
                    else
                    {
                        sum += (int)Math.Pow(2, i_binaryNum.Length - 1 - i);
                    }
                }
            }

            return sum;
        }

        /// <summary> Prints the average number of zeros and ones digits from three given numbers</summary>
        /// <param name="i_number1"> The first binary number. </param>
        /// <param name="i_number2"> The second binary number. </param>
        /// <param name="i_number3"> The third binary number. </param>
        private static void printAverageDigitsOfNumbers(string i_number1, string i_number2, string i_number3)
        {
            float zeroAverage = 0, oneAverage = 0;

            countDigitsOfBinaryNumber(i_number1, ref zeroAverage, ref oneAverage);
            countDigitsOfBinaryNumber(i_number2, ref zeroAverage, ref oneAverage);
            countDigitsOfBinaryNumber(i_number3, ref zeroAverage, ref oneAverage);
            zeroAverage /= 3;
            oneAverage /= 3;
            Console.WriteLine("The average number of zeros in the binary numbers is: {0}", zeroAverage);
            Console.WriteLine("The average number of ones in the binary numbers is: {0}", oneAverage);
        }

        /// <summary> Prints the number of zeros and ones digits from a given number</summary>
        /// <param name="i_number"> The binary number. </param>
        /// <param name="io_zeroCounter"> Total number of zeros. </param>
        /// <param name="io_oneCounter"> Total number of ones. </param>
        private static void countDigitsOfBinaryNumber(string i_number, ref float io_zeroCounter, ref float io_oneCounter)
        {
            for (int i = 0; i < i_number.Length; i++)
            {
                if (i_number[i] == '1')
                {
                    io_oneCounter++;
                }
                else
                {
                    io_zeroCounter++;
                }
            }
        }

        /// <summary> Prints the amount of numbers that are a power of two. </summary>
        /// <param name="i_number1"> The first binary number. </param>
        /// <param name="i_number2"> The second binary number. </param>
        /// <param name="i_number3"> The third binary number. </param>
        private static void printAmountPowerOfTwoNumbers(string i_number1, string i_number2, string i_number3)
        {
            int counter = 0;

            counter += isBinaryNumberPowerOftwo(i_number1);
            counter += isBinaryNumberPowerOftwo(i_number2); 
            counter += isBinaryNumberPowerOftwo(i_number3);
            if (counter == 1)
            {
                Console.WriteLine("There is 1 number that is a power of two.");
            }
            else
            {
                Console.WriteLine("There are {0} numbers that are a power of two.", counter);
            }
        }

        /// <summary> Checks if a number is a power of two. </summary>
        /// <param name="i_number"> The given number to check. </param>
        /// <returns> Returns 1 if the number is a power of two, 0 if not. </returns>
        private static int isBinaryNumberPowerOftwo(string i_number)
        {
            bool isOneFound = false;

            for (int i = 0; i < i_number.Length; i++)
            {
                if(i_number[i] == '1')
                {
                    if (!isOneFound)
                    {
                        isOneFound = true;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            return 1;
        }

        /// <summary> Prints the amount of numbers that are an ascending series. </summary>
        /// <param name="i_number1"> The first number. </param>
        /// <param name="i_number2"> The second number. </param>
        /// <param name="i_number3"> The third number. </param>
        private static void printAmountAscendingSeries(int i_number1, int i_number2, int i_number3)
        {
            int counter = 0;

            counter += isNumberAscendingSeries(i_number1);
            counter += isNumberAscendingSeries(i_number2);
            counter += isNumberAscendingSeries(i_number3);
            if (counter == 1)
            {
                Console.WriteLine("There is 1 number that is an ascesnding series.");
            }
            else
            {
                Console.WriteLine("There are {0} numbers that are ascesnding series.", counter);
            }
        }

        /// <summary> Checks if a number is an ascending series. </summary>
        /// <param name="i_number"> The given number to check. </param>
        /// <returns> Returns 1 if the number is an ascending series, 0 if not. </returns>
        private static int isNumberAscendingSeries(int i_number)
        {
            int previousDigit = 10;

            while (i_number > 0)
            {
                if((i_number % 10) > previousDigit)
                {
                    return 0;
                }

                previousDigit = i_number % 10;
                i_number /= 10;
            }

            return 1;
        }

        /// <summary> Prints the biggest number out of three given numbers. </summary>
        /// <param name="i_number1"> The first number. </param>
        /// <param name="i_number2"> The second number. </param>
        /// <param name="i_number3"> The third number. </param>
        private static void printBiggestNumbers(int i_number1, int i_number2, int i_number3)
        {
            int max;

            max = (i_number1 > i_number2) ? i_number1 : i_number2;
            max = (max > i_number3) ? max : i_number3;

            Console.WriteLine("The bisggest number is {0}.", max);
        }

        /// <summary> Prints the smallest number out of three given numbers. </summary>
        /// <param name="i_number1"> The first number. </param>
        /// <param name="i_number2"> The second number. </param>
        /// <param name="i_number3"> The third number. </param>
        private static void printSmallestNumbers(int i_number1, int i_number2, int i_number3)
        {
            int min;

            min = (i_number1 < i_number2) ? i_number1 : i_number2;
            min = (min < i_number3) ? min : i_number3;

            Console.WriteLine("The smallest number is {0}.", min);
        }
    }
}
