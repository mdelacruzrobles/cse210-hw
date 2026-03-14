using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        int sum = 0;
        int average = 0;
        int largest = 0;
        Console.Write("Enter number; ");
        number = int.Parse(Console.ReadLine());
        while (number != 0)
        {
            numbers.Add(number);
            Console.Write("Enter number; ");
            number = int.Parse(Console.ReadLine());
        }

        foreach (int i in numbers)
        {
            sum = sum + i;
            if(i > largest)
            {
                largest = i;
            }
        }
        average = sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}