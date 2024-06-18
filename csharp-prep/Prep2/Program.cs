using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);
        
        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;

        string letter;
        if (number >= A )
        {
            letter = "A";
        }

        else if (number >= B)
        {
            letter = "B";
        }

        else if (number >= C)
        {
            letter = "C";
        }

        else if (number >= D)
        {
            letter = "D";
        }

        else 
        {
            letter = "F";
        }

        string sign = "";
        if (number >= A)
        {
            if (number < 93) 
            {
                sign = "-";
            }
        }

        else if (number >= B)
        {
            if (number >= 87)
            {
                sign = "+";
            }
            else if (number < 83) 
            {
                sign = "-";
            }
            else 
            {
                sign = "";
            }
        }

        else if (number >= C)
        {
            if (number >= 77)
            {
                sign = "+";
            }
            else if (number < 73) 
            {
                sign = "-";
            }
            else 
            {
                sign = "";
            }
        }

        else if (number >= D)
        {
            if (number >= 67)
            {
                sign = "+";
            }
            else if (number < 63) 
            {
                sign = "-";
            }
            else 
            {
                sign = "";
            }
        }

        string result;
        if (number >= C )
        {
        result = "Congratulations! You passed the class";
        }
        else
        {
        result = "You didn't pass the course";
        }

        Console.WriteLine($"Your grade is {letter}{sign}, {result}");
        }



}