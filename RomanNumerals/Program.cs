using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            string romanNumber = "MDCCCLXXXVIII";
            Console.WriteLine(Program.ConversionResults(romanNumber));
        }
        static int ConvertLetter(char letter)
        {
            if (letter == 'I')
            {
                return 1;
            }
            else if (letter == 'V')
            {
                return 5;
            }
            else if (letter == 'X')
            {
                return 10;
            }
            else if (letter == 'L')
            {
                return 50;
            }
            else if (letter == 'C')
            {
                return 100;
            }
            else if (letter == 'D')
            {
                return 500;
            }
            else if (letter == 'M')
            {
                return 1000;
            }
            return -1;

        }
        static int ConversionResults(string romanNum)
        {
            romanNum = romanNum.ToUpper();
            int result = 0;
            foreach (var letter in romanNum)
            {
                result += ConvertLetter(letter);
            }

            if (romanNum.Contains("IV") || romanNum.Contains("IX"))
            {
                result = result - 2;
            }
            if (romanNum.Contains("XL") || romanNum.Contains("XC"))
            {
                result = result - 20;
            }
            if (romanNum.Contains("CD") || romanNum.Contains("CM"))
            {
                result = result - 200;
            }
            return result;

        }


    }
}
