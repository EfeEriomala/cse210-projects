using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your  grade percentage? ");
        string answer =Console.ReadLine();
        int score = int.Parse(answer);

        string letter = "";
        
        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is :{letter}");

        if (score >= 70)
        {
            Console.WriteLine($"Congratulations! You got a: {letter}  you Passed.");
        }
        else
        {
            Console.WriteLine($"Sorry. You got a: {letter} You didnt make the cut. Try Harder next time");
        }
    }
}