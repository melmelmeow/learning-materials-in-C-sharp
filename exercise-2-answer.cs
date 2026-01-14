using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create and populate LinkedList
        LinkedList<int> numbers = new LinkedList<int>();
        numbers.AddLast(5);
        numbers.AddLast(10);
        numbers.AddLast(15);

        // Remove 10
        numbers.Remove(10);

        // Print the list
        Console.WriteLine("LinkedList after removing 10:");
        foreach (var n in numbers)
            Console.WriteLine(n);

        // Search for numbers
        Console.WriteLine("\nSearch results:");
        SearchNumber(numbers, 5);
        SearchNumber(numbers, 10);
        SearchNumber(numbers, 15);
        SearchNumber(numbers, 20);
    }

    // Method to search for a number in the LinkedList
    static void SearchNumber(LinkedList<int> list, int numberToFind)
    {
        // Method 1: Using Contains() - simplest approach
        if (list.Contains(numberToFind))
        {
            Console.WriteLine($"Number {numberToFind} is FOUND in the LinkedList.");
        }
        else
        {
            Console.WriteLine($"Number {numberToFind} is NOT FOUND in the LinkedList.");
        }
    }
}
