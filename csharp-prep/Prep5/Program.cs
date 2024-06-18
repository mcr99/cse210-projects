using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = promptUserName();
        int favoriteNumber = promptUserNumber();
        int square = squareNumbers(favoriteNumber);
        
        DisplayResult(userName, square);

    }

        static void DisplayWelcome()
        {
        Console.WriteLine("Welcome to the program! ");
        }


        static string promptUserName()
        {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
        }

        static int promptUserNumber ()
        {
        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        int favNumber = int.Parse(favoriteNumber);
        return favNumber;
        }

        static int squareNumbers (int square)
        {
            int squareNumber = square * square;
            return squareNumber;
        }

        static void DisplayResult (string userName, int square)
        {
            Console.WriteLine($"Brother {userName}, the square of your number is: {square}");
            
        }



}