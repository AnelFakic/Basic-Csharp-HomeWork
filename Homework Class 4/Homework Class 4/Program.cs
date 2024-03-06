namespace Homework_Class_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // array[6]
            int[] emptySumArry= new int[6];
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter number:");
                emptySumArry[i]=int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < emptySumArry.Length; i++)
            {
                sum = sum + emptySumArry[i];
                
            }
            Console.WriteLine($"The sum of all array elemts is {sum}");
        }
    }
}
