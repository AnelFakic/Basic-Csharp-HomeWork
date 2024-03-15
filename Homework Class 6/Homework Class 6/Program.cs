using System.Threading.Channels;

namespace Homework_Class_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName;
            string dogBreed;
            string dogColor;
            string selectedCommand;

            Console.WriteLine("Hello,Please enter infromation about your Dog");
            Console.WriteLine("Name:");
            dogName = Console.ReadLine();
            Console.WriteLine("Breed:");
            dogBreed = Console.ReadLine();
            Console.WriteLine("Color:");
            dogColor = Console.ReadLine();

            Dog urDog = new Dog(dogName,dogBreed,dogColor);

            Console.WriteLine($"Dog Name: {urDog.DogName} \n Dog Breed: {urDog.DogBreed} \n Dog Color: {urDog.DogColor}");

            Console.WriteLine("Give ur dog a command, If u want him to eat press \"1\" " +
                "\n If you want him to play press \"2\"  \n If you want him to run prees \"3\"");


            urDog.DogCommand();
           



        }
    }
}
