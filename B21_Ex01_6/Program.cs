using System;

namespace B21_Ex01_6
{
    /// <summary> This program gets an input of a positive, 6 digit, integer and prints the biggest & the smallest digits, how many divided by 3 and how many bigget than left digit</summary>
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer with 6 digits:");
            string input;
            input = Console.ReadLine();
            while (!checkIfInputIsValid(input))
            {
                input = Console.ReadLine();
            }
            printsBiggestAndSmallestDigits(input);
            printsHowManyDividedByThree(input);
            printsHowManyBiggerThanLeftDigit(input);
        }

        private static bool checkIfInputIsValid(string i_input)
        {
            if (i_input.Length != 6)
            {
                Console.WriteLine("Wrong input! Please enter a number with 6 digits:");
                return false;
            }
            if(i_input[0]== '-')
            {
                Console.WriteLine("Wrong input! Please enter a positive number:");
                return false;
            }
            for (int i = 0; i < 6; i++)
            {
                if (!char.IsDigit(i_input[i]))
                {
                    Console.WriteLine("Wrong input! Please enter only digits:");
                    return false;
                }
            }
            return true;
        }

        private static void printsBiggestAndSmallestDigits(string i_input)
        {
            int numberInput = Int32.Parse(i_input);
            int currentBiggestDigit = numberInput % 10;
            int currentSmallestDigit = numberInput % 10;
            numberInput /= 10;
            for (int i = 1; i < 6; i++)
            {
              if(currentBiggestDigit< (numberInput % 10))
                {
                    currentBiggestDigit = numberInput % 10;
                }
              if (currentSmallestDigit > (numberInput % 10))
                {
                    currentSmallestDigit = numberInput % 10;
                }
              numberInput /= 10;
            }
            Console.WriteLine("The biggest digit is: " + (currentBiggestDigit).ToString());
            Console.WriteLine("The smallest digit is: "+ (currentSmallestDigit).ToString());
        }

        private static void printsHowManyDividedByThree(string i_input)
        {
            int numberInput = Int32.Parse(i_input);
            short numOfDividedByThree = 0;
            for (int i = 0; i < 6; i++)
            {
                if((numberInput % 10) %3 == 0)
                {
                    numOfDividedByThree++;
                }
                numberInput /= 10;
            }
            Console.WriteLine("The number of digits divided by three is: " + (numOfDividedByThree).ToString());
        }
        private static void printsHowManyBiggerThanLeftDigit(string i_input)
        {
            int numberInput = Int32.Parse(i_input);
            short numOfBiggerThanLeftDigit = 0;
            int leftDigit = numberInput / (100000);
            for (int i = 0; i < 5; i++)
            {
                if((numberInput%10) > leftDigit)
                {
                    numOfBiggerThanLeftDigit++;
                }
                numberInput /= 10;
            }
            Console.WriteLine("The number of digits bigger than the left digit: " + (numOfBiggerThanLeftDigit).ToString());
        }
    }
}
