using System;

class Program
{
    static void Main(string[] args)
    {
        // Used in part 1 & 2 where user input the magic number 
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());

        // Used in stretch #2 to see if user would like to play again
        string playAgain = "Yes";
        while (playAgain == "Yes")
        {
            // Part #3
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int userGuess = 0;
            // Used in stretch #1 to keep track of total guesses
            int guessCount = 0;
            // Part #3
            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = int.Parse(Console.ReadLine());
                // Stretch #1
                guessCount = guessCount + 1;
                // Core requirement and stretch
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            // Stretch #1
            Console.WriteLine($"It took you {guessCount} guesses");
        // Stretch #2
        Console.Write("Do you want to play again? ");
        playAgain = Console.ReadLine();
        }
    
    }
}    