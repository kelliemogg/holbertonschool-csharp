using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> lists = new List<int>();
        for (int i = 0; i < size; i++)
        {
            lists.Add(i);
            Console.Write(i);
            if (i < size - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
        return lists;
    }
}
