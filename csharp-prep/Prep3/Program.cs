using System;

class Program
{
    static void Main(string[] args)
    {
       
        // In Parts 1 and 2, the magic number is defined by user input:
        // Console.Write("What's the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // In Part 3, we generate a magic number randomly.

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // While Loop
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}