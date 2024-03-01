namespace Anel_Fakic_Homework__2_AvgNum_and_Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1: AverageNumber");
            int num1 = 10;
            int num2 = 15;
            int num3 = 20;
            int num4 = 30;
            int sumOfNum= num1+ num2+num3+num4;
            int avgOfNum = sumOfNum / 4;
            Console.WriteLine($"The average number is : {avgOfNum}");

            Console.WriteLine("==================");

            Console.WriteLine("Part 2: Swap Numbers");
            Console.WriteLine("Input first number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Input second number:");
            string input2 =Console.ReadLine();

            int number1;
            int number2;
            int.TryParse(input1, out number1);
            int.TryParse(input2, out number2);

            input1 = Convert.ToString(number2);
            input2= Convert.ToString(number1);

            
            Console.WriteLine($"First number is:{input1}, the second number is:{input2}");
        }
    }
}