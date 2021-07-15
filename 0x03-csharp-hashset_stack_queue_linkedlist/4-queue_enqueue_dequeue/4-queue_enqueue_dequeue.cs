using System;
using System.Collections.Generic;
using System.Linq;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Boolean condT = true;
        int count = 0;
        count = aQueue.Count;
        Console.WriteLine($"Number of items: {count}");
        if (aQueue.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine($"First item: {aQueue.Peek()}");
        if (aQueue.Contains(search) == condT)
        {
            Console.WriteLine($"Queue contains \"{search}\": True");
            do
            {
                aQueue.Dequeue();
            } while (aQueue.Contains(search) == condT && aQueue.Count > 0);
        }
        else
            Console.WriteLine($"Stack contains \"{search}\": False");
        aQueue.Enqueue(newItem);
        return aQueue;
    }
}
