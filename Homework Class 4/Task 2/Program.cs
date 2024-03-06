using System.ComponentModel.Design;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] g1Students = {"Marko","Janko","Stanko"};
            string[] g2Students = { "Hari", "Mata", "Hari" };

            Console.WriteLine("Press `1` to see students in G1 or press `2` to see students in G2");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    for (int i = 0; i < g1Students.Length; i++)
                    {
                        Console.WriteLine(g1Students[i]);
                    }
                    break;
                    case "2":
                    for (int i = 0; i < g2Students.Length; i++)
                    {
                        Console.WriteLine(g2Students[i]);
                    }
                    break;
                default:
                    Console.WriteLine("Error Wrong input, please restart app and try again because im layz and did bother making a while(true) ");
                    break;
            }
        }
    }
}
