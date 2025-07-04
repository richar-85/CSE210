using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for grade percentage
        Console.Write("Enter grade percentage: ");
        string gradePercent = Console.ReadLine();

        string letter = "";
        string gradeSign = "";

        // Determine and display letter grade
        int x = int.Parse(gradePercent);
        if (x >= 0 && x <= 100)
        {
            if (x >= 90)
            {
                letter = "A";
            }
            else if (x >= 80)
            {
                letter = "B";
            }
            else if (x >= 70)
            {
                letter = "C";
            }
            else if (x >= 60)
            {
                letter = "D";
            }
            else if (x < 60)
            {
                letter = "F";
            }
            Console.WriteLine($"Your geade is: {letter}");

            // Specify grade to pass class and provide congratulation
            if (x >= 70)
            {
                Console.WriteLine("Congratulation! You Pass");
            }

            // Provide encouragement if passing grade is not achieved
            else
            {
                Console.WriteLine("Please build on this effort to improve your grade");
            }

            // Stretch
            // Determine letter grade sign
            if (x >= 60)
            {
                int lastDigit = x % 10;
                if (lastDigit >= 7)
                {
                    gradeSign = "+";

                }

                else if (lastDigit < 3)
                {
                    gradeSign = "-";

                }
                Console.WriteLine($"Fianal grade is: {letter}{gradeSign}");

            }
        }

        // Check for not specified grade entered
        else
        {
            Console.WriteLine("Invalid percentage input");
        }
        
    }
}