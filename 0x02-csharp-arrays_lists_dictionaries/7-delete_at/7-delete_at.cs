using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index > myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        for (int i = 0; i <= index; i++)
        {
            if (i == index)
            {
            myList.Remove(i);
            }
        }
        return myList;
    }
}
