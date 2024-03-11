using System.Reflection;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Hello from SEDC CODE 2024";
            Console.WriteLine($"Hi ur phrase is : {phrase} lets modify it");

            Substrings(phrase);


        }

        static void Substrings(string phrase)
        {
            Console.WriteLine("Enter a number for \"n\" to select strating index: ");
            string inputN;
            int n;
            int m;
            string substring = "";
            string finalSubstring = "";
            while (true){
                inputN = Console.ReadLine();
                if (!int.TryParse(inputN, out n))
                {
                    Console.WriteLine("Invalid N input try again");
                    continue;
                }
                if (n > phrase.Length)
                {
                    Console.WriteLine("\"n\" cannot be larger than the length of our phrase try a smaller number:");
                    continue;
                }
                substring = phrase.Substring(n);
                break;
            }

            Console.WriteLine("Now enter the \"m\" for the max length of the phrase");
            Console.WriteLine($"Make sur \"m\" is not larger than {substring.Length} ");
           

            while (true) {
                
                string inputM = Console.ReadLine();
                if (!int.TryParse(inputM, out m)) {
                    Console.WriteLine("Wrong M input try again");
                    continue;
                }
                if (m > phrase.Length)
                {
                    Console.WriteLine("\"m\" cannot be larger than the length of our phrase try a smaller number:");
                    continue;
                }

                    finalSubstring = substring.Substring(0, m);

                Console.WriteLine($"Your new phrase is: {finalSubstring}");
                Console.WriteLine($"Length of the new string is {finalSubstring.Length}");
                break;
            }
        }
    }
}
