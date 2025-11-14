using System;



class Program

{

    static void Main(string[] args)

    {   

        // Ask the user for their first name and last name

        Console.WriteLine("What is your firt name?");

        string firstname = Console.ReadLine();



        // Ask the user for their last name

        Console.WriteLine("What is your last name?");

        string lastname = Console.ReadLine();



        Console.WriteLine($"Your name is {firstname}, {firstname} {lastname}.");

    }

}