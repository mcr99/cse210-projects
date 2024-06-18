using System;

class Program
{
    static void Main(string[] args)
    {


 //       Console.Write("What is the magic number? ");
 //       string magicNumber = Console.ReadLine();
 //       int mNumber = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 101);

        int yGuess;
        string answer ;

        do
        {

        Console.Write("What is your guess? ");
        string yourGuess = Console.ReadLine();
        yGuess = int.Parse(yourGuess);

        if (yGuess < mNumber)
        {
            answer = "Higher";
        }

        else if (yGuess > mNumber)
        {
            answer = "Lower";
        }

        else 
        {
            answer = "You guessed it!";
        }

        Console.WriteLine(answer);

        } while (yGuess != mNumber);

    }
}