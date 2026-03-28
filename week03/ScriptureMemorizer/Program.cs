using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nephi", 31, 20);
        string verseText = "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: ye shall have eternal life.";
        Scripture scripture = new Scripture(reference, verseText);
        string input = "";
        Random random = new Random();
        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            input = Console.ReadLine();
            if (input != "quit")
            {
                scripture.HideRandomWords(4);
            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}