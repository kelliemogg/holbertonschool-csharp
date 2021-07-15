using System;
using System.Linq;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int total = 0;
        HashSet<int> uniqueNumbers = new HashSet<int>(myList);
        uniqueNumbers = myList.ToHashSet();
        
        foreach (int value in uniqueNumbers)
        {
            total += value;
        }
        return total;
    }
}
