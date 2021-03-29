using System;

namespace B21_Ex01_4
{
    /// <summary> This program prints an hourglass shape of stars according to a size given by the user </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string with 10 charecters:");
            string input;
            input = Console.ReadLine();
            while (!checkIfStringIsValid(input))
            {
                input = Console.ReadLine();
            }
            if(IsPalindromeRec(input, 0, 9))
            {
                Console.WriteLine("The string is a palindrome");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome");
            }
           if (char.IsDigit(input[0]))
            {
                if (IsDividedByFour(input))
                {
                    Console.WriteLine("The number is divided by 4");
                }
                else
                {
                    Console.WriteLine("The number is not divided by 4");
                }
            }
            else
            {
                Console.WriteLine(HowManyUpper(input));
            }
        }

        private static bool checkIfStringIsValid(string i_string)
        {
            if (i_string.Length != 10)
            {
                Console.WriteLine("Wrong input! Please enter a string with 10 characters:");
                return false;
            }
            if (char.IsDigit(i_string[0]))
            {
                for (int i = 1; i < 10; i++)
                {
                    if (!char.IsDigit(i_string[i]))
                    {
                        Console.WriteLine("Wrong input! Please enter a string only digits / only english chars:");
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 1; i < 10; i++)
                {
                    if (char.IsDigit(i_string[i]))
                    {
                        Console.WriteLine("Wrong input! Please enter a string only digits / only english chars:"); 
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool IsPalindromeRec(string i_string, int i_left, int i_right)
        {
            if (i_left == i_right)
            {
                return true;
            }
            if (i_string[i_left] != i_string[i_right])
            {
                return false;
            }
            if (i_left < i_right)
            {
                return IsPalindromeRec(i_string, i_left + 1, i_right - 1);
            }
            return true;
        }

        private static bool IsDividedByFour(string i_string)
        {
            long number = Int64.Parse(i_string);
            if (number % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int HowManyUpper(string i_string)
        {
            int numOfUpper = 0;
            for(int i=0; i < 10; i++)
            {
                if (char.IsUpper(i_string[i]))
                {
                    numOfUpper++;
                }
            }
            return numOfUpper;
        }
    }
}
