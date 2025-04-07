// Program:    PCAD_Project_1.1.3
// Date:       7 APR 2025
// Programmer: Thomas A. Morrison

using System;
using System.Globalization;
namespace PCAD_Project_1_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            double quotientNumber = firstNumber / secondNumber;
            double remainderNumber = firstNumber % secondNumber;

            Console.WriteLine($"The quotient of {firstNumber} and {secondNumber} is {quotientNumber}.");
            Console.WriteLine($"The modulus of {firstNumber} and {secondNumber} is {remainderNumber}.");
        }
    }
}