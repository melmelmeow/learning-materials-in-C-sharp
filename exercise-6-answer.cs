using System;

class Program
{
    static void Main()
    {
        // Unsorted array for linear search
        int[] unsortedData = { 3, 7, 9, 2, 15, 4, 8, 12, 6, 11 };
        
        // Sorted array for binary search (must be sorted!)
        int[] sortedData = { 2, 3, 4, 6, 7, 8, 9, 11, 12, 15 };
        
        int target = 9;
        
        Console.WriteLine("=== LINEAR SEARCH ===");
        Console.WriteLine($"Array: [{string.Join(", ", unsortedData)}]");
        Console.WriteLine($"Searching for: {target}");
        
        int linearResult = LinearSearch(unsortedData, target);
        if (linearResult != -1)
            Console.WriteLine($"Found at index: {linearResult}");
        else
            Console.WriteLine("Not found");
        
        Console.WriteLine("\n=== BINARY SEARCH ===");
        Console.WriteLine($"Sorted Array: [{string.Join(", ", sortedData)}]");
        Console.WriteLine($"Searching for: {target}");
        
        int binaryResult = BinarySearch(sortedData, target);
        if (binaryResult != -1)
            Console.WriteLine($"Found at index: {binaryResult}");
        else
            Console.WriteLine("Not found");
        
        // Compare with built-in Array.BinarySearch
        Console.WriteLine("\n=== BUILT-IN BINARY SEARCH ===");
        int builtInResult = Array.BinarySearch(sortedData, target);
        if (builtInResult >= 0)
            Console.WriteLine($"Found at index: {builtInResult}");
        else
            Console.WriteLine("Not found");
        
        // Performance comparison
        Console.WriteLine("\n=== PERFORMANCE COMPARISON ===");
        CompareSearches(sortedData, target);
    }
    
    // Linear Search - works on any array
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == target) 
                return i;
        return -1;
    }
    
    // Binary Search - requires sorted array
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        
        while (left <= right)
        {
            int mid = left + (right - left) / 2; // Avoid overflow
            
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1; // Search in right half
            else
                right = mid - 1; // Search in left half
        }
        
        return -1; // Not found
    }
    
    // Compare the number of steps for each search
    static void CompareSearches(int[] sortedArr, int target)
    {
        Console.WriteLine("Searching for value 8 in sorted array:");
        
        // Count steps for linear search
        int linearSteps = 0;
        for (int i = 0; i < sortedArr.Length; i++)
        {
            linearSteps++;
            if (sortedArr[i] == 8) break;
        }
        Console.WriteLine($"Linear Search steps: {linearSteps}");
        
        // Count steps for binary search
        int binarySteps = 0;
        int left = 0;
        int right = sortedArr.Length - 1;
        bool found = false;
        
        while (left <= right)
        {
            binarySteps++;
            int mid = left + (right - left) / 2;
            
            if (sortedArr[mid] == 8)
            {
                found = true;
                break;
            }
            else if (sortedArr[mid] < 8)
                left = mid + 1;
            else
                right = mid - 1;
        }
        
        Console.WriteLine($"Binary Search steps: {binarySteps}");
        
        if (found)
            Console.WriteLine($"Binary search is {linearSteps - binarySteps} steps faster!");
        else
            Console.WriteLine("Value not found");
    }
}
