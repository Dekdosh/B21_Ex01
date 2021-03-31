using System;

namespace B21_Ex01_6
{
    // <summary> This program gets an input of a positive, 6 digit, integer and prints the biggest & the smallest digits, how many divided by 3 and how many biggest than left digit</summary>
    public class Program
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

        /// <summary>This function returns if the input that has been given is meeting our criteria</summary>
        private static bool checkIfInputIsValid(string i_input)
        {
            bool flag = true;
            if (i_input.Length == 7 && i_input[0] == '-')
            {
                Console.WriteLine("Wrong input! Please enter a positive number:");
                flag = false;
            }
            else if (i_input.Length != 6)
            {
                Console.WriteLine("Wrong input! Please enter a number with 6 digits:");
                flag = false;
            }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    if (!char.IsDigit(i_input[i]))
                    {
                        Console.WriteLine("Wrong input! Please enter only digits:");
                        flag = false;
                        break;
                    }
                }
            }

            return flag;
        }

        /// <summary>This function prints the biggest digit and then the smallest digit</summary>
        private static void printsBiggestAndSmallestDigits(string i_input)
        {
            int numberInput = Int32.Parse(i_input);
            int currentBiggestDigit = numberInput % 10;
            int currentSmallestDigit = numberInput % 10;
            numberInput /= 10;
            for (int i = 1; i < 6; i++)
            {
              if(currentBiggestDigit < (numberInput % 10))
              {
                  currentBiggestDigit = numberInput % 10;
              }
              
              if (currentSmallestDigit > (numberInput % 10))
              {
                  currentSmallestDigit = numberInput % 10;
              }

              numberInput /= 10;
            }

            Console.WriteLine("The biggest digit is: {0}", currentBiggestDigit);
            Console.WriteLine("The smallest digit is: {0}", currentSmallestDigit);
        }

        /// <summary>This function prints the number of digits that divide by 3</summary>
        private static void printsHowManyDividedByThree(string i_input)
        {
            int numberInput = Int32.Parse(i_input);
            short numOfDividedByThree = 0;
            for (int i = 0; i < 6; i++)
            {
                if((numberInput % 10) % 3 == 0)
                {
                    numOfDividedByThree++;
                }

                numberInput /= 10;
            }

            Console.WriteLine("The number of digits divided by three is: {0}", numOfDividedByThree);
        }

        /// <summary>This function prints the number of digits that are bigger than the left digit</summary>
        private static void printsHowManyBiggerThanLeftDigit(string i_input)
        {
            int numberInput = Int32.Parse(i_input);
            short numOfBiggerThanLeftDigit = 0;
            int leftDigit = numberInput / 100000;
            for (int i = 0; i < 5; i++)
            {
                if(numberInput % 10 > leftDigit)
                {
                    numOfBiggerThanLeftDigit++;
                }

                numberInput /= 10;
            }

            Console.WriteLine("The number of digits bigger than the left digit: {0}", numOfBiggerThanLeftDigit);
        }
    }
}
