Stack<string> stack = new Stack<string>();
stack.Push("First");
stack.Push("Second");
stack.Push("Third");

Console.WriteLine("Popped: " + stack.Pop());

foreach (var item in stack)
    Console.WriteLine(item);
