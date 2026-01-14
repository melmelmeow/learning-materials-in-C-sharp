Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

Console.WriteLine("Dequeued: " + queue.Dequeue());

foreach (var item in queue)
    Console.WriteLine(item);
