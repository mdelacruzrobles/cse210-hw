using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        string letter = "";
        int numberConversion = int.Parse(grade);
        if (numberConversion >= 90)
        {
            letter = "A";
        }
        else if (numberConversion >= 80 && numberConversion < 90)
        {
            letter = "B";
        }
        else if (numberConversion >= 70 && numberConversion < 80)
        {
            letter = "C";
        }
        else if (numberConversion >= 60 && numberConversion < 70)
        {
            letter = "D";
        }
        else if (numberConversion < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade letter is {letter}");

        if (numberConversion >= 70)
        {
            Console.WriteLine("You have passed");
        }
        else
        {
            Console.WriteLine("Try harder next time");
        }
    }
}