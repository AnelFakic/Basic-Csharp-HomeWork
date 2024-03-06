using System.Linq.Expressions;

namespace Class_3_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int number1;
            int number2;
            string mathOpp;

            while (true)
            {
                Console.WriteLine("Please Input First number");
                string inputA = Console.ReadLine();
                 if(int.TryParse(inputA,out number1))
                {
                    break;
                }
                Console.WriteLine("Wrong first input try again");
            }

            while (true)
            {
                Console.WriteLine("Please Input Second number");
                string inputB = Console.ReadLine();
                if (int.TryParse(inputB, out number2))
                {
                    break;
                }
                Console.WriteLine("Wrong Secong input try again");
            }

            while (true)
            {
                Console.WriteLine("Please choose the mathOppematical operation you want to do buy choosing:`*`, `/, `+`, `-` ");
               mathOpp= Console.ReadLine();
                if ((mathOpp =="+")||(mathOpp=="-")|| (mathOpp == "*") || (mathOpp == "/"))
                {
                    break;
                }
                Console.WriteLine("Wrong mathOpp input try again buy choosing:`*`, `/, `+`, `-` \"");
            }

            switch (mathOpp)
            {
                case "+":
                    Console.WriteLine($"{number1}+{number2}={number1 + number2}");
                    break; 
                case "-": Console.WriteLine($"{number1}-{number2}={number1 - number2}");
                    break;
                case "*":
                    Console.WriteLine($"{number1}*{number2}={number1 * number2}" );
                    break;
                    case "/":
                    Console.WriteLine($"{number1}/{number2}={number1 / number2}");
                    break;
            }

        }
    }
}
