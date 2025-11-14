using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();   // create random generator
        int mgkno = random.Next(1, 101); // pick number between 1–100
        int guess = -1;
        int attempts = 0;

        Console.WriteLine("🎮 Welcome to the Magic Number Game!");
        Console.WriteLine("Try to guess the number between 1 and 100.");
        Console.WriteLine("Type 'q' anytime to quit.\n");

        while (guess != mgkno)
        {
            Console.Write("What is your guess? ");
            string input = Console.ReadLine();

            // quit option
            if (input.ToLower() == "q")
            {
                Console.WriteLine($"👋 You quit the game. The number was {mgkno}.");
                break;
            }

            // check valid number
            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("⚠ Invalid input. Please enter a number or 'q' to quit.\n");
                continue;
            }

            attempts++;

            if (guess < mgkno)
            {
                Console.WriteLine("Guess Higher!!\n");
            }
            else if (guess > mgkno)
            {
                Console.WriteLine("Guess Lower!!\n");
            }
            else
            {
                Console.WriteLine($"🎉 You guessed correctly in {attempts} tries!");
                Console.WriteLine("🏆 You win!");
            }
        }
    }
}