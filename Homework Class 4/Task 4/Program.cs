namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] namesOfPeople = new string[0];

            do {
                Console.WriteLine("Enter a name:");
                string input = Console.ReadLine();

                Array.Resize(ref namesOfPeople, namesOfPeople.Length + 1);

                namesOfPeople[namesOfPeople.Length - 1] = input;

                Console.WriteLine("If you want to enter another name press \"y\" if not press \"n\"");
                
               string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                {
                    continue;
                }

                foreach (var people in namesOfPeople)
                {
                    Console.WriteLine(people);
                }

                break;

            } while (true);
        }
    }
}
