using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.WriteLine("What is your grade percentage?");
        int grade = int.Parse(Console.ReadLine());
        string letter;
        int sign = grade % 10;
        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";

        }
        else if (grade >= 80)
        {
            letter = "B";

        }
        else if (grade >= 70)
        {
            letter = "C";

        }
        else if (grade >= 60)
        {
            letter = "D";

        }
        else
        {
            letter = "F";
        }
        // Determine the sign of the letter grade
        if (sign >= 7 && letter != "A" && letter != "F")
        {
            letter += "+";
        }
        else if (sign < 3 && letter != "F")
        {
            letter += "-";
        }
        // Display the letter grade
        Console.WriteLine($"Your letter grade is {letter}.");
        // Determine if the user passed the class
        if (grade < 70)
        {
            Console.WriteLine("Sorry do  did not pass the class, try again next term.");

        }
        else
        {
            Console.WriteLine("Congratulations you passed the class!");
        }

       


    }
}