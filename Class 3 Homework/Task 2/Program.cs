namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input First Number");
            string input1 = Console.ReadLine();
            Console.WriteLine("Input Second Number");
            string input2 = Console.ReadLine();

            int.TryParse(input1, out int CountUp);
            int.TryParse(input2, out int CountDown);

            Console.WriteLine("Counting Up");
            for (int i = 1; i <= CountUp; i++)
            {
                
                Console.WriteLine(i);
            }
            Console.WriteLine("Counting Down");
            for (int i = 0;i < CountDown; CountDown--)
            {
               
                Console.WriteLine(CountDown);
            }

        }
    }
}
