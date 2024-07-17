using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
            switch (choice)
            {
                case 1:
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                break;

                case 2: 
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                break;

                case 3: 
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                break;

                case 4:
                Console.WriteLine("Exiting... ");
                return;

                default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
            }

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
      
    }
}
