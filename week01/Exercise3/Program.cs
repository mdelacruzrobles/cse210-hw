using System;

class Program
{
    static void Main(string[] args)
    {   
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guessNumber = 0;

        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);

            if (guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }

        } while (guessNumber != number);

        Console.WriteLine("You guessed it!");
    }
}