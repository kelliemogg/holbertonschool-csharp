using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> linx = new LinkedList<int>();
    
        if (size < 0)
            return (linx);
        for (int i = 0; i < size; i++)
        {
            linx.AddLast(i);
            Console.WriteLine(i);
        }
        return (linx);
    }
}
