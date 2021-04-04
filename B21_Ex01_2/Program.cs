using System;
using System.Text;

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
               StringBuilder stringToPrint = new StringBuilder();

               AppendCharsRecursively(i_counterOfSpaces, ' ', ref stringToPrint);
               AppendCharsRecursively(i_numOfLines, '*', ref stringToPrint);
               if (i_numOfLines > 1)
               {
                    Console.WriteLine(stringToPrint.ToString());
                    Hourglass(i_numOfLines - 2, i_counterOfSpaces + 1);
               }

               Console.WriteLine(stringToPrint.ToString());
          }

          /// <summary> Appends a given char a given number of times to string of type stringBuilder. </summary>
          /// <param name="i_numOfCharPrints"> The number of prints for the char. </param>
          /// <param name="i_charToPrint"> The char to print. </param>
          /// <param name="io_stringToBuild"> The string to append to. </param>
          private static void AppendCharsRecursively(int i_numOfCharPrints, char i_charToPrint, ref StringBuilder io_stringToBuild)
          {
               if (i_numOfCharPrints > 0)
               {
                    io_stringToBuild.Append(i_charToPrint);
                    AppendCharsRecursively(i_numOfCharPrints - 1, i_charToPrint, ref io_stringToBuild);
               }
          }
     }
}
