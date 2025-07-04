using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numberSquare = SquareNumber(userNumber);
        DisplayResult(userName, numberSquare);

    }
    // Display message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Ask and return user name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Ask and return user number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    // Square user number
    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }

    // Accept and display user name and squared number
    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}