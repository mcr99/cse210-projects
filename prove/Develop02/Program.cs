using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choice");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                WriteNewEntry(promptGenerator, journal);
                break;
                case "2":
                journal.DisplayAll();
                break;
                case "3":
                LoadJournalFromFile(journal);
                break;
                case "4":
                SaveJournalToFile (journal);
                break;
                case "5":
                running = false;
                break;
                default:
                Console.WriteLine("Invalid Choice. Please Try Again");
                break;
            }
        }
    }

    static void WriteNewEntry(PromptGenerator promptGenerator, Journal journal)
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        Entry entry = new Entry(date, prompt, response);
        journal.AddEntry(entry);

        Console.WriteLine("Your answer has been saved.");
    }

    static void SaveJournalToFile(Journal journal)
    {
        Console.Write("Enter filename to save journal: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
        Console.WriteLine($"Journal has been saved to {filename}");
    }

    static void LoadJournalFromFile(Journal journal)
    {
        Console.Write("Enter filename to load journal: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine($"Journal has been loaded from {filename}");
    }
}
