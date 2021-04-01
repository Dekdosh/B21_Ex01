using System;

namespace B21_Ex01_4
{
    // <summary> This program gets an input of a string and checks if palindrome, divided by 4 and how many upper-case chars </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string with 10 characters:");
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

        /// <summary>This function returns if the input that has been given is meeting our criteria</summary>
        private static bool checkIfStringIsValid(string i_string)
        {
            bool flag = true;
            if (i_string.Length != 10)
            {
                flag = false;
            }

            if (char.IsDigit(i_string[0]))
            {
                for (int i = 1; i < 10; i++)
                {
                    if (!char.IsDigit(i_string[i]))
                    {
                        flag = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 1; i < 10; i++)
                {
                    if (char.IsDigit(i_string[i]))
                    {
                        flag = false;
                        break;
                    }
                }
            }

            if (flag == false)
            {
                Console.WriteLine("Wrong input! Please enter the string again:");
            }

            return flag;
        }

        /// <summary>This function checks if the string is a palindrome, in recursion</summary>
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

        /// <summary>This function checks if it's a number than if it's divided by 4</summary>
        private static bool IsDividedByFour(string i_string)
        {
            bool result;
            long number = long.Parse(i_string);
            if (number % 4 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        /// <summary>This function returns the number of upper case characters</summary>
        private static int HowManyUpper(string i_string)
        {
            int numOfUpper = 0;
            for(int i = 0; i < 10; i++)
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
