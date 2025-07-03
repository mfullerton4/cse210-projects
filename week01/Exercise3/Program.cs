using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessNum = 0;

            while (guess != magicNum)
            {

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessNum++;

                if (guess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessNum} tries.");
                }
            }
            Console.Write("Do you want to play again? ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing!");
    }
}