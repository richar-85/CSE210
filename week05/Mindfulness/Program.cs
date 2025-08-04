using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false; // Controls the main loop; stays true until user chooses to quit

        while (!exit)
        {
            Console.Clear(); // Clear the console screen for a clean menu display

            // Display the main menu options
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Start Exercising Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine(); // Get user input
            Activity activity = null; // Placeholder for selected activity

            // Instantiate and run the selected activity
            if (input == "1")
            {
                activity = new BreathingActivity();
                activity.Run();
            }
            else if (input == "2")
            {
                activity = new ReflectingActivity();
                activity.Run();
            }
            else if (input == "3")
            {
                activity = new ListingActivity();
                activity.Run();
            }
            else if (input == "4")
            {
                activity = new ExercisingActivity();
                activity.Run();
            }
            
            else if (input == "5") // Added exit condition
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                exit = true;
            }
            // Added to handles invalid input
            else
            {
                Console.WriteLine("Invalid input. Press Enter to try again.");
                Console.ReadLine();
            }

            // Added pause and prompt user before returning to the menu, unless exiting
            if (!exit && activity != null)
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}