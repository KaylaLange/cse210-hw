using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber;
        int userGuess;
        string response;

        do
        {
            magicNumber = randomGenerator.Next(1, 101);
            userGuess = -1;
            response = "";
            int guessCount = 0;

            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                guessCount++;

                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                    Console.WriteLine("");
                    Console.Write("Do you want to play again? ");
                    response = Console.ReadLine();
                }
            }
        } while (response == "yes");

    }
}