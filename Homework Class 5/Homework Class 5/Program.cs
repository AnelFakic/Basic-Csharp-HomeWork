using System.Globalization;

namespace Homework_Class_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture=new CultureInfo("en-US");

            Console.WriteLine("Enter Birthday following this format: mm-dd-yyyy");
            string birthDay =Console.ReadLine();
            DateTime converted=DateTime.Parse(birthDay);

            int age = AgeCalculator(converted);
            Console.WriteLine($"Your Age is {age}");
        }

        public static int AgeCalculator(DateTime converted)
        {
            DateTime today = DateTime.Today;
            int age = today.Year -converted.Year;
            
            if (converted.Date >today.AddYears(-age))
            {
                age--;
                
            }

            return age;
        }

    }
}
