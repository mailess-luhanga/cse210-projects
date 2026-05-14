using System;

// Exceeding Requirements:
// - Added mood tracking to each journal entry
// - Added keyword search feature
// - Improved file saving using CSV formatting
// - Added extra prompts

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load journal");
            Console.WriteLine("4. Save journal");
            Console.WriteLine("5. Search journal");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an option: ");

            bool validInput = int.TryParse(Console.ReadLine(), out choice);

            if (!validInput)
            {
                Console.WriteLine("Please enter a valid number.\n");
                continue;
            }

            if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"\nPrompt: {prompt}");
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Console.Write("How are you feeling today? ");
                string mood = Console.ReadLine();

                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                journal.AddEntry(newEntry);

                Console.WriteLine("Entry added successfully.\n");
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                journal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("Enter filename to load: ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }
            else if (choice == 4)
            {
                Console.Write("Enter filename to save: ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }
            else if (choice == 5)
            {
                Console.Write("Enter keyword to search: ");
                string keyword = Console.ReadLine();

                Console.WriteLine();
                journal.SearchEntries(keyword);
            }
            else if (choice == 6)
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
            }
        }
    }
}