using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicNumber = Console.ReadLine();
        // int magicNumberInt = int.Parse(magicNumber);
        Random randomGenerator = new Random();
        int magicNumberInt = randomGenerator.Next(1, 101);
        bool run = true;

        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);

            
            if (guessNumber < magicNumberInt) {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumberInt) {
                Console.WriteLine("Lower");
            }
            else {
                Console.WriteLine("You guessed it!");
                run = false;
            }
        }while (run == true);

    }
}