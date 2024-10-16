// I changed the animation for the breathing activity to have the words move across for the length of each breath.
// I also added some error handling in the main class to account for the user selecting an option not on the menu.
using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> listingPrompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        List<string> prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        List<string> questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };        

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity\n2. Start reflecting activity\n3. Start listing activity\n4. Quit");
            Console.Write("Select a choice from the menu: ");
            int userChoice = int.Parse(Console.ReadLine());


            if (userChoice == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity(0);
                breathingActivity.Run();
            }
            else if (userChoice == 2)
            {
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity(prompts, questions, 0);
                reflectingActivity.Run();

            }
            else if (userChoice == 3)
            {
                ListingActivity listingActivity = new ListingActivity(0, listingPrompts, 0);
                listingActivity.Run();
            }
            else if (userChoice == 4)
            {
                break;
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Invalid selection. Please type a number from the menu: ");
            }
            
        }
    }
}