// I added the the ability for the user to select the verse they want to memorize. I also looked up how to center the 
// scripture horizontally in the console and implemented that for better readability for the user.

using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("John", 3, 16);
        Scripture scriptureText1 = new Scripture(reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
    
        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scriptureText2 = new Scripture(reference2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Console.WriteLine();
        Console.WriteLine("Please select verse to memorize:");
        Console.WriteLine($"Type 1 for {reference1.GetDisplayText()}. Type 2 for {reference2.GetDisplayText()}.");
        int choice = int.Parse(Console.ReadLine());


        int consoleHeight = Console.WindowHeight;

        int centerY = consoleHeight / 2;
            

        if (choice == 1)
        {
            while (!scriptureText1.IsCompletelyHidden())
            {
                Console.SetCursorPosition(0, centerY);
                Console.WriteLine(scriptureText1.GetDisplayText());
                scriptureText1.HideRandomWords(3);
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                if (Console.ReadLine().ToLower() == "quit")
                {
                    break;
                }
            }
            if (scriptureText1.IsCompletelyHidden())
            {
                Console.Clear();
            }
        }
       
       if (choice == 2)
       {
            while (!scriptureText2.IsCompletelyHidden())
            {
                Console.SetCursorPosition(0, centerY);
                Console.WriteLine(scriptureText2.GetDisplayText());
                scriptureText2.HideRandomWords(3);
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");
                if (Console.ReadLine().ToLower() == "quit")
                {
                    break;
                }
            }
            if (scriptureText2.IsCompletelyHidden())
            {
                Console.Clear();
            }
       }
       
    }
}