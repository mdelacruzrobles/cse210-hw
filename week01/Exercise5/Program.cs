using System;
using System.Reflection.Metadata;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName()
    {
        string userName;
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        int userNumber;
        Console.Write("Please enter your favorite number: ");
        userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int number)
    {
        int square;
        square = number * number;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Brother {name}, the square of your number is {square}");
    
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user = PromptUserName();
        int number = PromptUserNumber();
        int squareNumberUser = SquareNumber(number);
        DisplayResult(user, squareNumberUser);
    }
}