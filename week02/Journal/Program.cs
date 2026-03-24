using System;
using System.Data.Common;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                if(choice == 1)
                {
                    string prompt = generator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string userResponse = Console.ReadLine();
                    Entry entry = new Entry();
                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = userResponse;
                    journal.AddEntry(entry);
                }
                else if (choice == 2)
                {
                    journal.DisplayAll();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("What is the filename?");
                    string nameFile = Console.ReadLine();
                    journal.LoadFromFile(nameFile);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("What is the filename?");
                    string nameFile = Console.ReadLine();
                    journal.SaveToFile(nameFile);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Goodbye");
                }
                else
                {
                    Console.WriteLine("Please choose a number between 1 and 5.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        

    }
}