using System.Runtime.CompilerServices;

namespace Homework_Class_7
{
    internal class Program
    {

        static void NumbersStat()
        {
            string numberStatus = "float";
            string negativeOrPostive = "Negative";
            string evenOrOdd = "even";
            string inputedNumber = Console.ReadLine();

            if (inputedNumber.Contains('.') || inputedNumber.Contains(','))
            {
                float.TryParse(inputedNumber, out float resultFloat);

                if (resultFloat >= 0)
                {
                    negativeOrPostive = "Postive";
                }

                Console.WriteLine($"The number {inputedNumber} is a {numberStatus} and {negativeOrPostive} a decimal cannot be even nor odd");
            }
            else
            {
                int.TryParse(inputedNumber, out int resultInt);
                numberStatus = "integer";
                if (resultInt >= 0)
                {
                    negativeOrPostive = "Postive";
                }
                if (resultInt % 2 != 0)
                {
                    evenOrOdd = "Odd";
                }
                Console.WriteLine($"The number {inputedNumber} is a {numberStatus} and {negativeOrPostive} and {evenOrOdd}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a number");

            NumbersStat();
        }
    }
}
