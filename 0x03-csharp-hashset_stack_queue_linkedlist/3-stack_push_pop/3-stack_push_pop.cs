using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Boolean condT = true;
        int count = 0;
        count = aStack.Count;
        Console.WriteLine($"Number of items: {count}");
        Console.WriteLine($"Top item: {aStack.Peek()}");
        if (aStack.Contains(search) == condT)
        {
            Console.WriteLine($"Stack contains \"{search}\": True");
            do
            {
                aStack.Pop();
            } while (aStack.Contains(search) == condT && aStack.Count > 0);
        }
        else
            Console.WriteLine($"Stack constains {search}: False");
        aStack.Push(newItem);
        if (aStack == null)
            Console.WriteLine("Stack is empty");
        return aStack;
    }
}
