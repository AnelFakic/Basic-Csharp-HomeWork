using System.ComponentModel.Design;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] g1Students = { "Marko", "Janko", "Stanko" };
            string[] g2Students = { "Hari", "Mata", "Hari" };
            string input;

            while (true)
            {

                Console.WriteLine("Press `1` to see students in G1 or press `2` to see students in G2");
                input = Console.ReadLine();
                if (input == "1" || input == "2")
                {
                    break;
                }
                Console.WriteLine("Wrong Input try again");
            }
            switch (input)
            {
                case "1":
                    Console.WriteLine("Students in G1:");
                    for (int i = 0; i < g1Students.Length; i++)
                    {
                        Console.WriteLine(g1Students[i]);
                    }
                    break;
                case "2":
                    Console.WriteLine("Students in G2:");
                    for (int i = 0; i < g2Students.Length; i++)
                    {
                        Console.WriteLine(g2Students[i]);
                    }
                    break;
            }
        }
    }
}
