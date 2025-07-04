using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        

        List<int> numbers = new List<int>();
        int numberEntered = -1;

        // Ask user to enter list of numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished."); 
        while (numberEntered != 0)
        {
            Console.Write("Enter number: ");
            numberEntered = int.Parse(Console.ReadLine());
            if (numberEntered != 0)
            {
                numbers.Add(numberEntered);
            }
        }

        // Compute the sum, or total, of numbers in the list 
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average of the numbers in the list
        int average = (sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the maximum, or largest, number in the list
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // Stretch
        // Find the smallest positive number in the list
        int? smallestPositive = null;
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (smallestPositive == null || number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        // Find the minimum, or smallest, number in the list
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The smallest number is: {min}");

        // Sort the number in the list ans display the new, sorted list
        numbers.Sort();
        Console.WriteLine("\nThe sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}