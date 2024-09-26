// I added a few things to the program to exceed requirements. I included additional questions to help the user add
// more detail to their entries and give more context to their experiences. I added some error handling to my if statement
// so that if the user selects a number outside of the range in the menu they will be alerted and redirected to select
// an apporpriate option. I also added the datetime now method to get the accurate date of the entry.
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>()
        {
            "What am I grateful for today?",
            "How did I see the hand of the Lord in my Life today?",
            "What was the best part of my day?",
            "What made me laugh today?",
            "If I had one thing I could do over today, what would it be?",
            "Who did I help today?",
            "What was the strongest emotion I felt today?",
            "Who was the most interesting person I interacted with today?",
            "What was my biggest accomplishment for today?"
        };

        PromptGenerator generator = new PromptGenerator(prompts);

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());

        Journal journal = new Journal();
        journal._entries = new List<Entry>();

        while (choice != 5)
        {
            if (choice == 1)
            {
                string randomPrompt = generator.GenerateRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write("> ");
                string userEntry = Console.ReadLine();


                Console.WriteLine("Where were you when this occurred? ");
                Console.Write("> ");
                string location = Console.ReadLine();
                Console.WriteLine("What were you doing when this happened? ");
                Console.Write("> ");
                string activity = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("MM/dd/yyyy");
                entry._promptText = randomPrompt;
                entry._entryText = userEntry;
                entry._userLocation = location;
                entry._userActivity = activity;

                journal.AddEntry(entry);
                
            }
            else if (choice == 2)
            {
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the filename?");
                string userFilename = Console.ReadLine();
                journal.LoadFromFile(userFilename);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename?");
                string userFilename = Console.ReadLine();
                journal.SaveToFile(userFilename);
            }
            else if (choice == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please type a number between 1 and 5");
            }
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
        }

    }
}