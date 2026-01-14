using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create and populate the queue
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        
        // Dequeue one element
        Console.WriteLine("Dequeued: " + queue.Dequeue());
        
        // Print the queue
        Console.WriteLine("\nQueue contents (front to back):");
        foreach (var item in queue)
            Console.WriteLine(item);
        
        // Use method to print front element without removing it
        Console.WriteLine("\nUsing PeekFront method:");
        PeekFront(queue);
        
        // Also show built-in Peek method
        Console.WriteLine("\nUsing built-in Peek method:");
        if (queue.Count > 0)
        {
            Console.WriteLine("Front element: " + queue.Peek());
        }
    }
    
    // Method to print the front element without removing it
    static void PeekFront(Queue<int> q)
    {
        if (q.Count == 0)
        {
            Console.WriteLine("Queue is empty!");
            return;
        }
        
        // Since we can't access elements by index in a Queue,
        // we need to use the Peek method or create a workaround
        
        // Method 1: Using built-in Peek (simplest)
        Console.WriteLine("Front element: " + q.Peek());
        
        // Method 2: Manual approach (without using Peek)
        // foreach (var item in q)
        // {
        //     Console.WriteLine("Front element: " + item);
        //     break; // Only get the first element
        // }
    }
}
