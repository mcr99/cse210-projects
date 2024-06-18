using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int lNumbers = -1 ;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
        Console.Write("Enter numbers: ");
        string listOfNumbers = Console.ReadLine();
        lNumbers = int.Parse(listOfNumbers);

            if (lNumbers != 0)
            {
                numbers.Add(lNumbers);
            }
        } while (lNumbers != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number; 
        }

        float average = ((float)sum) / numbers.Count;

        int largest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");


    }
}