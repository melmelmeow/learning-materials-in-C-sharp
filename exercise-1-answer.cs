using System;

class Program
{
    static void Main()
    {
        // Create array of 5 student names
        string[] students = { "Ana", "Ben", "Carl", "Dana", "Eli" };

        // Print original array
        Console.WriteLine("Original students:");
        foreach (var s in students)
            Console.WriteLine(s);

        // Replace the 3rd student with "ElderSlyLich"
        students[2] = "ElderSlyLich";

        // Print updated array
        Console.WriteLine("\nAfter update:");
        foreach (var s in students)
            Console.WriteLine(s);

        // Search function to find if "Dana" exists (using Array.Exists)
        Console.WriteLine("\nSearching for 'Dana':");
        
        if (Array.Exists(students, student => student == "Dana"))
        {
            Console.WriteLine("Student 'Dana' exists in the array.");
        }
        else
        {
            Console.WriteLine("Student 'Dana' does NOT exist in the array.");
        }
    }
}
