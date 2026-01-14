using System;

class Program
{
    static void Main()
    {
        // Part 1: Using built-in Stack
        Console.WriteLine("=== Part 1: Using Built-in Stack ===");
        System.Collections.Generic.Stack<string> stack = new System.Collections.Generic.Stack<string>();
        
        // Push 3 items
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");
        
        // Pop one item and print
        Console.WriteLine("Popped: " + stack.Pop());
        
        // Print remaining stack
        Console.WriteLine("Remaining items:");
        foreach (var item in stack)
            Console.WriteLine(item);
        
        Console.WriteLine();
        
        // Part 2: Using custom ArrayStack
        Console.WriteLine("=== Part 2: Using Custom ArrayStack ===");
        ArrayStack<string> customStack = new ArrayStack<string>();
        
        // Push 3 items
        customStack.Push("First");
        customStack.Push("Second");
        customStack.Push("Third");
        
        // Pop one item and print
        Console.WriteLine("Popped: " + customStack.Pop());
        
        // Print remaining stack
        customStack.Print();
    }
}

// Custom ArrayStack class
class ArrayStack<T>
{
    private T[] items;
    private int top;
    private int capacity;
    
    public ArrayStack(int initialCapacity = 10)
    {
        capacity = initialCapacity;
        items = new T[capacity];
        top = -1; // -1 means empty stack
    }
    
    public void Push(T item)
    {
        // Resize if full
        if (top == capacity - 1)
        {
            int newCapacity = capacity * 2;
            T[] newArray = new T[newCapacity];
            Array.Copy(items, newArray, capacity);
            items = newArray;
            capacity = newCapacity;
        }
        
        items[++top] = item;
    }
    
    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");
        
        T item = items[top];
        items[top] = default(T);
        top--;
        return item;
    }
    
    public bool IsEmpty()
    {
        return top == -1;
    }
    
    public void Print()
    {
        Console.WriteLine("Stack contents (top to bottom):");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(items[i]);
        }
    }
}
