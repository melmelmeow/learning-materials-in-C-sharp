using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Original test array
        int[] arr1 = { 5, 1, 4, 2 };
        int[] arr2 = { 5, 1, 4, 2 };
        
        Console.WriteLine("Original array: [5, 1, 4, 2]");
        Console.WriteLine();
        
        // Bubble Sort
        Console.WriteLine("=== BUBBLE SORT ===");
        Console.Write("Before: ");
        PrintArray(arr1);
        BubbleSort(arr1);
        Console.Write("After:  ");
        PrintArray(arr1);
        
        Console.WriteLine();
        
        // Selection Sort
        Console.WriteLine("=== SELECTION SORT ===");
        Console.Write("Before: ");
        PrintArray(arr2);
        SelectionSort(arr2);
        Console.Write("After:  ");
        PrintArray(arr2);
        
        Console.WriteLine();
        
        // Performance comparison with larger array
        Console.WriteLine("=== PERFORMANCE COMPARISON ===");
        ComparePerformance();
    }
    
    // Bubble Sort
    static void BubbleSort(int[] arr)
    {
        int comparisons = 0;
        int swaps = 0;
        
        for (int i = 0; i < arr.Length - 1; i++)
        {
            // Track if any swaps happened in this pass
            bool swapped = false;
            
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                comparisons++;
                if (arr[j] > arr[j + 1])
                {
                    // Swap elements
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swaps++;
                    swapped = true;
                }
            }
            
            // If no swaps happened, array is already sorted
            if (!swapped)
                break;
        }
        
        Console.WriteLine($"Comparisons: {comparisons}, Swaps: {swaps}");
    }
    
    // Selection Sort
    static void SelectionSort(int[] arr)
    {
        int comparisons = 0;
        int swaps = 0;
        
        for (int i = 0; i < arr.Length - 1; i++)
        {
            // Find the minimum element in unsorted part
            int minIndex = i;
            
            for (int j = i + 1; j < arr.Length; j++)
            {
                comparisons++;
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            
            // Swap the found minimum with the first element
            if (minIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
                swaps++;
            }
        }
        
        Console.WriteLine($"Comparisons: {comparisons}, Swaps: {swaps}");
    }
    
    // Print array
    static void PrintArray(int[] arr)
    {
        Console.WriteLine($"[{string.Join(", ", arr)}]");
    }
    
    // Compare performance with larger array
    static void ComparePerformance()
    {
        // Create a larger random array
        int size = 1000;
        Random rand = new Random();
        int[] testArray = new int[size];
        
        for (int i = 0; i < size; i++)
        {
            testArray[i] = rand.Next(1, 10000);
        }
        
        // Make copies for each sort
        int[] bubbleArray = (int[])testArray.Clone();
        int[] selectionArray = (int[])testArray.Clone();
        
        // Measure Bubble Sort time
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        BubbleSortTimed(bubbleArray);
        stopwatch.Stop();
        long bubbleTime = stopwatch.ElapsedMilliseconds;
        
        // Measure Selection Sort time
        stopwatch.Restart();
        SelectionSortTimed(selectionArray);
        stopwatch.Stop();
        long selectionTime = stopwatch.ElapsedMilliseconds;
        
        Console.WriteLine($"Array size: {size} random elements");
        Console.WriteLine($"Bubble Sort time: {bubbleTime} ms");
        Console.WriteLine($"Selection Sort time: {selectionTime} ms");
        
        if (bubbleTime < selectionTime)
            Console.WriteLine($"Bubble Sort is {selectionTime - bubbleTime} ms faster");
        else if (selectionTime < bubbleTime)
            Console.WriteLine($"Selection Sort is {bubbleTime - selectionTime} ms faster");
        else
            Console.WriteLine("Both took the same time");
        
        // Show first 10 elements to verify sorting
        Console.Write("\nFirst 10 elements after sorting: ");
        for (int i = 0; i < 10 && i < bubbleArray.Length; i++)
        {
            Console.Write(bubbleArray[i] + " ");
        }
        Console.WriteLine("...");
    }
    
    // Bubble Sort without counting (for timing)
    static void BubbleSortTimed(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
    
    // Selection Sort without counting (for timing)
    static void SelectionSortTimed(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            
            if (minIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }
}
