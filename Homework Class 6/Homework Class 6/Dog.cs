
namespace Homework_Class_6
{
    public class Dog
    {
        public string DogName { get; set; }
        public string DogBreed { get; set; }
        public string DogColor { get; set; }

        public Dog(string dogName,string breed,string dogColor )
        {
            DogName = dogName;
            DogBreed= breed;
            DogColor = dogColor;
            
        }
        public string DogCommand() 
        {
             string selectedCommand ="placeHolder";
            while (true)
            {
                 string command = Console.ReadLine();
                if (command=="1" || command== "2" || command=="3")
                {
                    switch (command)
                    {
                        case "1":
                            selectedCommand="The dog is now eating";
                            
                         break;
                        case "2":
                            selectedCommand= "The dog is now playing";
                            
                            break;
                        case "3":
                            selectedCommand="The dog is chasing its tail";
                            
                         break;
                    }
                    Console.WriteLine(selectedCommand);
                    return selectedCommand;
                }
                
                else { 
                Console.WriteLine("Wrong Input Try Again");
                continue;
                }

            }
        }


    }
}
